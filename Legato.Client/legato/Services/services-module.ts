import angular from 'angular';

import HttpService from './src/HttpService';

const servicesModuleName = 'legato.services';

angular.module(servicesModuleName, [])
    .service('HttpService', HttpService);

export {
    HttpService
};

export default servicesModuleName;