import angular from 'angular';

import MainDirective from './src/legato/MainDirective';
import ClassicalDirective from './src/classical/ClassicalDirective';
import WesternDirective from './src/western/WesternDirective';
import ElectricDirective from './src/electric/ElectricDirective';
import BassDirective from './src/bass/BassDirective';
import LegatoValidatePriceDirective from './src/validatePrice/LegatoValidatePriceDirective';

const directivesModuleName = 'legato.directives';

angular.module(directivesModuleName, [])
    .directive('legato', MainDirective)
    .directive('classical', ClassicalDirective)
    .directive('western', WesternDirective)
    .directive('electric', ElectricDirective)
    .directive('bass', BassDirective)
    .directive('legatoValidatePrice', LegatoValidatePriceDirective);

export {
    MainDirective,
    ClassicalDirective,
    WesternDirective,
    ElectricDirective,
    BassDirective
};

export default directivesModuleName;