import angular from 'angular';

import MainDirective from './src/MainDirective';
import ClassicalDirective from './src/ClassicalDirective';
import WesternDirective from './src/WesternDirective';
import ElectricDirective from './src/ElectricDirective';
import BassDirective from './src/BassDirective';

const directivesModuleName = 'legato.directives';

angular.module(directivesModuleName, [])
    .directive('legato', MainDirective)
    .directive('classical', ClassicalDirective)
    .directive('western', WesternDirective)
    .directive('electric', ElectricDirective)
    .directive('bass', BassDirective);

export {
    MainDirective,
    ClassicalDirective,
    WesternDirective,
    ElectricDirective,
    BassDirective
};

export default directivesModuleName;