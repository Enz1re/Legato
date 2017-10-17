import angular from 'angular';

import MainDirective from './src/legato/MainDirective';
import ClassicalDirective from './src/classical/ClassicalDirective';
import WesternDirective from './src/western/WesternDirective';
import ElectricDirective from './src/electric/ElectricDirective';
import BassDirective from './src/bass/BassDirective';

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