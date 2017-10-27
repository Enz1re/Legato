import angular from 'angular';

import { MainDirective } from './src/legato/MainDirective';
import { ClassicalDirective } from './src/classical/ClassicalDirective';
import { WesternDirective } from './src/western/WesternDirective';
import { ElectricDirective } from './src/electric/ElectricDirective';
import { BassDirective } from './src/bass/BassDirective';
import { LegatoValidatePriceDirective } from './src/validatePrice/LegatoValidatePriceDirective';
import { LegatoLoadingDirective } from './src/loading/LegatoLoadingDirective';
import { LegatoLoaderDirective } from './src/loading/LegatoLoaderDirective';

import { MainController } from './src/legato/MainController';
import { ClassicalController } from './src/classical/ClassicalController';
import { WesternController } from './src/western/WesternController';
import { ElectricController } from './src/electric/ElectricController';
import { BassController } from './src/bass/BassController';

const directivesModuleName = 'legato.directives';

angular.module(directivesModuleName, [])
    // directive declarations
    .directive('legato', MainDirective.create())
    .directive('classical', ClassicalDirective.create())
    .directive('western', WesternDirective.create())
    .directive('electric', ElectricDirective.create())
    .directive('bass', BassDirective.create())
    .directive('legatoValidatePrice', LegatoValidatePriceDirective.create())
    .directive('legatoLoading', LegatoLoadingDirective.create())
    .directive('legatoLoader', LegatoLoaderDirective.create())
    // controller declarations
    .controller('MainController', MainController)
    .controller('ClassicalController', ClassicalController)
    .controller('WesternController', WesternController)
    .controller('ElectricController', ElectricController)
    .controller('BassController', BassController);

export default directivesModuleName;