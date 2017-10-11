import angular from 'angular';

import MainDirective from './src/MainDirective';
import ClassicalDirective from './src/ClassicalDirective';
import WesternDirective from './src/WesternDirective';
import ElectroDirective from './src/ElectroDirective';
import BassDirective from './src/BassDirective';

const directivesModuleName = 'legato.directives';

angular.module(directivesModuleName, [])
    .directive('legato', MainDirective)
    .directive('classical', ClassicalDirective)
    .directive('western', WesternDirective)
    .directive('electric', ElectroDirective)
    .directive('bass', BassDirective);

export {
    MainDirective,
    ClassicalDirective,
    WesternDirective,
    ElectroDirective,
    BassDirective
};

export default directivesModuleName;