import angular from 'angular';

import MainController from './src/MainController';
import ClassicalController from './src/ClassicalController';
import WesternController from './src/WesternController';
import ElectricController from './src/ElectricController';
import BassController from './src/BassController';
import GuitarController from './src/GuitarController';

const controllersModuleName = 'legato.controllers';

angular.module(controllersModuleName, [])
    .controller('MainController', MainController)
    .controller('ClassicalController', ClassicalController)
    .controller('WesternController', WesternController)
    .controller('ElectricController', ElectricController)
    .controller('BassController', BassController);

export {
    MainController,
    ClassicalController,
    WesternController,
    ElectricController,
    BassController,
    GuitarController
};

export default controllersModuleName;