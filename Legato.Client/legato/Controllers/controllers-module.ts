import angular from 'angular';

import MainController from './src/MainController';
import ClassicalController from './src/ClassicalController';
import WesternController from './src/WesternController';
import ElectroController from './src/ElectroController';
import BassController from './src/BassController';

const controllersModuleName = 'legato.controllers';

angular.module(controllersModuleName, [])
    .controller('MainController', MainController)
    .controller('ClassicalController', ClassicalController)
    .controller('WesternController', WesternController)
    .controller('ElectroController', ElectroController)
    .controller('BassController', BassController);

export {
    MainController,
    ClassicalController,
    WesternController,
    ElectroController,
    BassController
};

export default controllersModuleName;