import angular from 'angular';

import { MainDirective } from './src/legato/MainDirective';
import { ClassicalDirective } from './src/classical/ClassicalDirective';
import { WesternDirective } from './src/western/WesternDirective';
import { ElectricDirective } from './src/electric/ElectricDirective';
import { BassDirective } from './src/bass/BassDirective';
import { LegatoValidatePriceDirective } from './src/validatePrice/LegatoValidatePriceDirective';
import { LegatoLoadingDirective } from './src/loading/LegatoLoadingDirective';
import { LegatoLoaderDirective } from './src/loading/LegatoLoaderDirective';


const directivesModuleName = 'legato.directives';

angular.module(directivesModuleName, [])
    .directive('legato', MainDirective.create())
    .directive('classical', ClassicalDirective.create())
    .directive('western', WesternDirective.create())
    .directive('electric', ElectricDirective.create())
    .directive('bass', BassDirective.create())
    .directive('legatoValidatePrice', LegatoValidatePriceDirective.create())
    .directive('legatoLoading', LegatoLoadingDirective.create())
    .directive('legatoLoader', LegatoLoaderDirective.create());

export {
    MainDirective,
    ClassicalDirective,
    WesternDirective,
    ElectricDirective,
    BassDirective,
    LegatoValidatePriceDirective,
    LegatoLoadingDirective,
    LegatoLoaderDirective
};

export default directivesModuleName;