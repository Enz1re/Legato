module.exports = function(config) {
  config.set({
    basePath: '',
    frameworks: ['systemjs', 'jasmine'],
	plugins: [
      require('karma-systemjs'),
      require('karma-jasmine'),
      require('karma-chrome-launcher'),
	  require('karma-jasmine-html-reporter')
    ],
	client: {
      clearContext: false // leave Jasmine Spec Runner output visible in browser
    },
    files: [{
		pattern: "legato/**/*.js"
    }],
    systemjs: {
		configFile: 'systemjs.config.js',

		// Patterns for files that you want Karma to make available, but not loaded until a module requests them. eg. Third-party libraries. 
		serveFiles: [
			'legato/**/*.*'
		],

		// SystemJS configuration specifically for tests, added after your config file. 
		// Good for adding test libraries and mock modules 
		includeFiles: [
			'node_modules/angular/angular.min.js'
		],
		testFileSuffix: 'spec.js',
		config: {
			paths: {
				"typescript": "node_modules/typescript/lib/typescript.js",
				"systemjs": "node_modules/systemjs/dist/system.js",
				'angular-mocks': 'node_modules/angular-mocks/angular-mocks.js',
				'system-polyfills': 'node_modules/systemjs/dist/system-polyfills.js',
			}
		}
    },
    reporters: ['kjhtml', 'progress'],
	mime: {
		'text/javascript': ['js'],
		'text/x-typescript': ['ts', 'tsx']
    },
    port: 9876,
    colors: true,
    logLevel: config.LOG_INFO,
    autoWatch: true,
    browsers: ['Chrome'],
    singleRun: false,
    concurrency: Infinity
  })
};