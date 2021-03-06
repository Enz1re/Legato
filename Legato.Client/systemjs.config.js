﻿System.config({
    baseURL: "/",
    defaultJSExtensions: true,
    transpiler: "typescript",
    paths: {
        "*": "legato/*",
        "npm:*": "node_modules/*"
    },
    map: {
        app: "legato",
        "angular": "npm:angular/angular.min.js",
        "angular-mocks": "npm:angular-mocks/ngMock.js",
        "angular-animate": "npm:angular-animate/index.js",
        "angular-cookies": "npm:angular-cookies/index.js",
        "angular-ui-router": "npm:angular-ui-router/release/angular-ui-router.min.js",
        "angular-ui-bootstrap": "npm:angular-ui-bootstrap/index.js",
        "ng-file-upload": "npm:ng-file-upload/index.js"
    },
    meta: {
        "angular": {
            format: "global",
            exports: "angular"
        },
    },
    packages: {
        app: {
            main: "legato/legato-module.js",
            defaultExtension: "js"
        },
        "angular-mocks": {
            main: "npm:angular-mocks/ngMock.js",
            defaultExtension: "js"
        },
        "angular-animate": {
            main: "npm:angular-animate/index.js",
            defaultExtension: "js"
        },
        "angular-cookies": {
            main: "npm:angular-cookies/index.js",
            defaultExtension: "js"
        },
        "angular-ui-bootstrap": {
            main: "npm:angular-ui-bootstrap/index.js",
            defaultExtension: "js"
        },
    }
});
