class ContextMenuItem {
    text: string;
    displayed?: () => boolean | boolean;
    click: ($itemScope, $event, modelValue, text, $li, data) => void;
}

export interface IContextMenuService {
    guitarOptions: ContextMenuItem[];
    userOptions: ContextMenuItem[];
    attemptOptions: ContextMenuItem[];
}