import angular from "angular";

import { ContextMenuEvents } from "./ContextMenuEvents";


export class LegatoContextMenuDirective implements ng.IDirective {
    private contextMenus = [];
    private clickedElement = null;
    private emptyText = "empty";
    private defaultItemText = "New Item";

    constructor(private $rootScope, private $parse: ng.IParseService, private $q: ng.IQService, private $sce: ng.ISCEService,
        private $document: ng.IDocumentService, private $window: ng.IWindowService) {

    }

    link($scope: ng.IScope, element: JQLite, attrs: ng.IAttributes) {
        const shouldDisplay = $scope.$eval(attrs.contextMenuIf);
        if (!shouldDisplay) {
            return;
        }

        let openMenuEvents = ['contextmenu'];
        this.emptyText = $scope.$eval(attrs.contextMenuEmptyText) || 'empty';
        const data = $scope.$eval(attrs.contextMenuData);
        
        if (attrs.contextMenuOn && typeof attrs.contextMenuOn === 'string') {
            openMenuEvents = attrs.contextMenuOn.split(',');
        }

        angular.forEach(openMenuEvents, (openMenuEvent) => {
            element.on(openMenuEvent.trim(), e => {
                if (!attrs.allowEventPropagation) {
                    event.stopPropagation();
                    event.preventDefault();
                }

                if (this.isTouchDevice() && element.attr('draggable') === 'true') {
                    return false;
                }

                // Remove if the user clicks outside
                this.$document.find('body').on('mousedown', this.removeOnOutsideClickEvent.bind(this));
                // Remove the menu when the scroll moves
                this.$document.on('scroll', this.removeOnScrollEvent.bind(this));

                this.clickedElement = event.currentTarget;
                angular.element(this.clickedElement).addClass('context');

                $scope.$apply(() => {
                    let options = $scope.$eval(attrs.contextMenu);
                    let customClass = attrs.contextMenuClass;
                    let modelValue = $scope.$eval(attrs.model);
                    let orientation = attrs.contextMenuOrientation;

                    this.$q.when(options).then(promisedMenu => {
                        if (angular.isFunction(promisedMenu)) {
                            //  support for dynamic items
                            promisedMenu = promisedMenu.call($scope, $scope, event, modelValue);
                        }
                        let params = {
                            '$scope': $scope,
                            'event': event,
                            'options': promisedMenu,
                            'modelValue': modelValue,
                            'data': data,
                            'level': 0,
                            'customClass': customClass,
                            'orientation': orientation
                        };

                        this.$rootScope.$broadcast(ContextMenuEvents.ContextMenuOpening, { context: this.clickedElement });
                        this.renderContextMenu(params);
                    });
                });

                // Remove all context menus if the scope is destroyed
                $scope.$on('$destroy', e => {
                    this.removeAllContextMenus(e);
                });
            });
        });
    }

    static create(): ng.IDirectiveFactory {
        const directive: ng.IDirectiveFactory = ($rootScope: ng.IRootScopeService, $parse: ng.IParseService, $q: ng.IQService,
                                                 $sce: ng.ISCEService, $document: ng.IDocumentService, $window: ng.IWindowService) =>
            new LegatoContextMenuDirective($rootScope, $parse, $q, $sce, $document, $window);
        directive.$inject = ["$rootScope", "$parse", "$q", "$sce", "$document", "$window"];
        return directive;
    }

    private createAndAddOptionText(params) {
        // Destructuring:
        let $scope = params.$scope;
        let item = params.item;
        let event = params.event;
        let modelValue = params.modelValue;
        let $promises = params.$promises;
        let nestedMenu = params.nestedMenu;
        let $li = params.$li;
        let leftOriented = String(params.orientation).toLowerCase() === 'left';
        let optionText = null;

        if (item.html) {
            if (angular.isFunction(item.html)) {
                // runs the function that expects a jQuery/jqLite element
                optionText = item.html($scope);
            } else {
                // Assumes that the developer already placed a valid jQuery/jqLite element
                optionText = item.html;
            }
        } else {
            let $a = angular.element('<a>');
            let $anchorStyle = {
                textAlign: leftOriented ? 'right' : 'left',
                paddingRight:  '8px',
                fontSize:  '18px'
            };

            $a.css($anchorStyle);
            $a.addClass('dropdown-item');
            $a.attr({ tabindex: '-1', href: '#' });

            let textParam = item.text || item[0];
            let text = this.defaultItemText;

            if (typeof textParam === 'string') {
                text = textParam;
            } else if (typeof textParam === 'function') {
                text = textParam.call($scope, $scope, event, modelValue);
            }

            let $promise = this.$q.when(text);
            $promises.push($promise);

            $promise.then(pText => {
                if (nestedMenu) {
                    let $arrow;
                    let $boldStyle: any = {
                        fontFamily: 'monospace',
                        fontWeight: 'bold',
                    };

                    if (leftOriented) {
                        $arrow = '&lt;';
                        $boldStyle.float = 'left';
                    } else {
                        $arrow = '&gt;';
                        $boldStyle.float = 'right';
                    }

                    let $bold = angular.element('<strong style="font-family:monospace;font-weight:bold;float:right;">' + $arrow + '</strong>');
                    $bold.css($boldStyle);
                    $a.css('cursor', 'default');
                    $a.append($bold);
                }
                $a.append(pText);
            });

            optionText = $a;
        }

        $li.append(optionText);

        return optionText;
    }

    /**
     * Process each individual item
     *
     * Properties of params:
     * - $scope
     * - event
     * - modelValue
     * - level
     * - item
     * - $ul
     * - $li
     * - $promises
     */
    private processItem(params) {
        let nestedMenu = this.extractNestedMenu(params);
        // if html property is not defined, fallback to text, otherwise use default text
        // if first item in the item array is a function then invoke .call()
        // if first item is a string, then text should be the string.
        let text = this.defaultItemText;
        let currItemParam = angular.extend({}, params);
        let item = params.item;
        let enabled = item.enabled === undefined ? item[2] : item.enabled;

        currItemParam.nestedMenu = nestedMenu;
        currItemParam.enabled = this.resolveBoolOrFunc(enabled, params);
        currItemParam.text = this.createAndAddOptionText(currItemParam);

        this.registerCurrentItemEvents(currItemParam);
    }

    /*
     * Registers the appropriate mouse events for options if the item is enabled.
     * Otherwise, it ensures that clicks to the item do not propagate.
     */
    private registerCurrentItemEvents(params) {
        // Destructuring:
        let item = params.item;
        let $ul = params.$ul;
        let $li = params.$li;
        let $scope = params.$scope;
        let modelValue = params.modelValue;
        let level = params.level;
        let data = params.data;
        let event = params.event;
        let text = params.text;
        let nestedMenu = params.nestedMenu;
        let enabled = params.enabled;
        let orientation = String(params.orientation).toLowerCase();
        let customClass = params.customClass;

        if (enabled) {
            let openNestedMenu = e => {
                this.removeContextMenus(level + 1);
                /*
                 * The object here needs to be constructed and filled with data
                 * on an "as needed" basis. Copying the data from event directly
                 * or cloning the event results in unpredictable behavior.
                 */
                /// adding the original event in the object to use the attributes of the mouse over event in the promises
                let ev = {
                    pageX: orientation === 'left' ? event.pageX - $ul[0].offsetWidth + 1 : event.pageX + $ul[0].offsetWidth - 1,
                    pageY: $ul[0].offsetTop + $li[0].offsetTop - 3,
                    // eslint-disable-next-line angular/window-service
                    view: event.view || window,
                    target: event.target,
                    event: e
                };

                /*
                 * At this point, nestedMenu can only either be an Array or a promise.
                 * Regardless, passing them to `when` makes the implementation singular.
                 */
                this.$q.when(nestedMenu).then(promisedNestedMenu => {
                    if (angular.isFunction(promisedNestedMenu)) {
                        //  support for dynamic subitems
                        promisedNestedMenu = promisedNestedMenu.call($scope, $scope, event, modelValue, text, $li, data);
                    }
                    let nestedParam = {
                        $scope: $scope,
                        event: ev,
                        options: promisedNestedMenu,
                        modelValue: modelValue,
                        level: level + 1,
                        orientation: orientation,
                        customClass: customClass
                    };
                    this.renderContextMenu(nestedParam);
                });
            };

            $li.on('click', e => {
                if (e.which === 1) {
                    e.preventDefault();
                    $scope.$apply(() => {
                        let cleanupFunction = () => {
                            angular.element(event.currentTarget).removeClass('context');
                            this.removeAllContextMenus(e);
                        };
                        let clickFunction = angular.isFunction(item.click)
                            ? item.click
                            : (angular.isFunction(item[1])
                                ? item[1]
                                : null);

                        if (clickFunction) {
                            let res = clickFunction.call($scope, $scope, event, modelValue, text, $li, data);
                            if (res === undefined || res) {
                                cleanupFunction();
                            }
                        } else {
                            cleanupFunction();
                        }
                    });
                }
            });

            $li.on('mouseover', e => {
                $scope.$apply(() => {
                    if (nestedMenu) {
                        openNestedMenu(e);
                    } else {
                        this.removeContextMenus(level + 1);
                    }
                });
            });
        } else {
            this.setElementDisabled($li);
        }
    }

    /**
     * @param params - an object containing the `item` parameter
     * @returns an Array or a Promise containing the children,
     *          or null if the option has no submenu
     */
    private extractNestedMenu(params) {
        let item = params.item;

        if (item.children) {
            if (angular.isFunction(item.children)) {
                // Expects a function that returns a Promise or an Array
                return item.children();
            } else if (angular.isFunction(item.children.then) || angular.isArray(item.children)) {
                // Returns the promise
                // OR, returns the actual array
                return item.children;
            }

            return null;

        } else {
            // nestedMenu is either an Array or a Promise that will return that array.
            return angular.isArray(item[1]) ||
                (item[1] && angular.isFunction(item[1].then)) ? item[1] : angular.isArray(item[2]) ||
                    (item[2] && angular.isFunction(item[2].then)) ? item[2] : angular.isArray(item[3]) ||
                        (item[3] && angular.isFunction(item[3].then)) ? item[3] : null;
        }
    }

    /**
     * Responsible for the actual rendering of the context menu.
     *
     * The parameters in params are:
     * - $scope = the scope of this context menu
     * - event = the event that triggered this context menu
     * - options = the options for this context menu
     * - modelValue = the value of the model attached to this context menu
     * - level = the current context menu level (defauts to 0)
     * - customClass = the custom class to be used for the context menu
     */
    private renderContextMenu(params) {
        // Destructuring:
        let $scope = params.$scope;
        let event = params.event;
        let options = params.options;
        let modelValue = params.modelValue;
        let level = params.level;
        let customClass = params.customClass;

        // Initialize the container. This will be passed around
        let $ul = this.initContextMenuContainer(params);
        params.$ul = $ul;

        // Register this level of the context menu
        this.contextMenus.push($ul);

        /*
         * This object will contain any promises that we have
         * to wait for before trying to adjust the context menu.
         */
        let $promises = [];
        params.$promises = $promises;

        angular.forEach(options, item => {
            if (item === null) {
                this.appendDivider($ul);
            } else {
                // If displayed is anything other than a function or a boolean
                let displayed = this.resolveBoolOrFunc(item.displayed, params);

                // Only add the <li> if the item is displayed
                if (displayed) {
                    let $li = angular.element('<li>');
                    let itemParams = angular.extend({}, params);
                    itemParams.item = item;
                    itemParams.$li = $li;

                    if (typeof item[0] === 'object') {
                        // custom.initialize($li, item);
                    } else {
                        this.processItem(itemParams);
                    }
                    if (this.resolveBoolOrFunc(item.hasTopDivider, itemParams, false)) {
                        this.appendDivider($ul);
                    }
                    $ul.append($li);
                    if (this.resolveBoolOrFunc(item.hasBottomDivider, itemParams, false)) {
                        this.appendDivider($ul);
                    }
                }
            }
        });

        if ($ul.children().length === 0) {
            let $emptyLi = angular.element('<li>');
            this.setElementDisabled($emptyLi);
            $emptyLi.html('<a>' + this.emptyText + '</a>');
            $ul.append($emptyLi);
        }

        this.$document.find('body').append($ul);

        this.doAfterAllPromises(params);

        this.$rootScope.$broadcast(ContextMenuEvents.ContextMenuOpened, {
            context: this.clickedElement,
            contextMenu: $ul,
            params: params
        });
    }

    /**
     * calculate if drop down menu would go out of screen at left or bottom
     * calculation need to be done after element has been added (and all texts are set; thus the promises)
     * to the DOM the get the actual height
     */
    private doAfterAllPromises(params) {
        // Desctructuring:
        let $ul = params.$ul;
        let $promises = params.$promises;
        let level = params.level;
        let event = params.event;
        let leftOriented = String(params.orientation).toLowerCase() === 'left';

        this.$q.all($promises).then(() => {
            let topCoordinate = event.pageY;
            let menuHeight = angular.element($ul[0]).prop('offsetHeight');
            let winHeight = this.$window.scrollY + event.view.innerHeight;
            /// the 20 pixels in second condition are considering the browser status bar that sometimes overrides the element
            if (topCoordinate > menuHeight && winHeight - topCoordinate < menuHeight + 20) {
                topCoordinate = event.pageY - menuHeight;
                /// If the element is a nested menu, adds the height of the parent li to the topCoordinate to align with the parent
                if (level && level > 0) {
                    topCoordinate += event.event.currentTarget.offsetHeight;
                }
            } else if (winHeight <= menuHeight) {
                // If it really can't fit, reset the height of the menu to one that will fit
                angular.element($ul[0]).css({ 'height': winHeight - 5, 'overflow-y': 'scroll' });
                // ...then set the topCoordinate height to 0 so the menu starts from the top
                topCoordinate = 0;
            } else if (winHeight - topCoordinate < menuHeight) {
                let reduceThresholdY = 5;
                if (topCoordinate < reduceThresholdY) {
                    reduceThresholdY = topCoordinate;
                }
                topCoordinate = winHeight - menuHeight - reduceThresholdY;
            }

            let leftCoordinate = event.pageX;
            let menuWidth = angular.element($ul[0]).prop('offsetWidth');
            let winWidth = event.view.innerWidth + window.pageXOffset;
            let padding = 5;

            if (leftOriented) {
                if (winWidth - leftCoordinate > menuWidth && leftCoordinate < menuWidth + padding) {
                    leftCoordinate = padding;
                } else if (leftCoordinate < menuWidth) {
                    let reduceThresholdX = 5;
                    if (winWidth - leftCoordinate < reduceThresholdX + padding) {
                        reduceThresholdX = winWidth - leftCoordinate + padding;
                    }
                    leftCoordinate = menuWidth + reduceThresholdX + padding;
                } else {
                    leftCoordinate = leftCoordinate - menuWidth;
                }
            } else {
                if (leftCoordinate > menuWidth && winWidth - leftCoordinate - padding < menuWidth) {
                    leftCoordinate = winWidth - menuWidth - padding;
                } else if (winWidth - leftCoordinate < menuWidth) {
                    let reduceThresholdX = 5;
                    if (leftCoordinate < reduceThresholdX + padding) {
                        reduceThresholdX = leftCoordinate + padding;
                    }
                    leftCoordinate = winWidth - menuWidth - reduceThresholdX - padding;
                }
            }

            $ul.css({
                display: 'block',
                position: 'absolute',
                left: leftCoordinate + 'px',
                top: topCoordinate + 'px'
            });
        });
    }

    /**
     * Creates the container of the context menu (a <ul> element),
     * applies the appropriate styles and then returns that container
     *
     * @return a <ul> jqLite/jQuery element
     */
    private initContextMenuContainer(params) {
        // Destructuring
        let customClass = params.customClass;

        let $ul = angular.element('<ul>');
        $ul.addClass('dropdown-menu');
        $ul.attr({ 'role': 'menu' });
        $ul.css({
            display: 'block',
            position: 'absolute',
            left: params.event.pageX + 'px',
            top: params.event.pageY + 'px',
            'z-index': 10000
        });

        if (customClass) { $ul.addClass(customClass); }

        return $ul;
    }

    private isTouchDevice() {
        return 'ontouchstart' in window || navigator.maxTouchPoints; // works on most browsers | works on IE10/11 and Surface
    }

    /**
     * Removes the context menus with level greater than or equal
     * to the value passed. If undefined, null or 0, all context menus
     * are removed.
     */
    private removeContextMenus(level?) {
        while (this.contextMenus.length && (!level || this.contextMenus.length > level)) {
            let cm = this.contextMenus.pop();
            this.$rootScope.$broadcast(ContextMenuEvents.ContextMenuClosed, { context: this.clickedElement, contextMenu: cm });
            cm.remove();
        }
        if (!level) {
            this.$rootScope.$broadcast(ContextMenuEvents.ContextMenuAllClosed, { context: this.clickedElement });
        }
    }

    private removeOnScrollEvent(e) {
        this.removeAllContextMenus(e);
    }

    private removeOnOutsideClickEvent(e) {
        let $curr = angular.element(e.target);
        let shouldRemove = true;

        while ($curr.length) {
            if ($curr.hasClass('dropdown-menu')) {
                shouldRemove = false;
                break;
            } else {
                $curr = $curr.parent();
            }
        }
        if (shouldRemove) {
            this.removeAllContextMenus(e);
        }
    }

    private removeAllContextMenus(e) {
        this.$document.find('body').off('mousedown', this.removeOnOutsideClickEvent.bind(this));
        this.$document.off('scroll', this.removeOnScrollEvent.bind(this));
        angular.element(this.clickedElement).removeClass('context');
        this.removeContextMenus();
        this.$rootScope.$broadcast('');
    }

    private isBoolean(a) {
        return a === false || a === true;
    }

    /** Resolves a boolean or a function that returns a boolean
     * Returns true by default if the param is null or undefined
     * @param a - the parameter to be checked
     * @param params - the object for the item's parameters
     * @param defaultValue - the default boolean value to use if the parameter is
     *  neither a boolean nor function. True by default.
     */
    private resolveBoolOrFunc(a, params, defaultValue = true) {
        let item = params.item;
        let $scope = params.$scope;
        let event = params.event;
        let modelValue = params.modelValue;

        defaultValue = this.isBoolean(defaultValue) ? defaultValue : true;

        if (this.isBoolean(a)) {
            return a;
        } else if (angular.isFunction(a)) {
            return a.call($scope, $scope, event, modelValue);
        } else {
            return defaultValue;
        }
    }

    private appendDivider($ul) {
        let $li = angular.element('<li>');
        $li.addClass('divider');
        $ul.append($li);
    }

    private setElementDisabled($li) {
        $li.on('click', e => {
            e.preventDefault();
        });

        $li.addClass('disabled');
    }
}