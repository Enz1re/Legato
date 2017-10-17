import angular from 'angular';

import BooleanFilter from './src/BooleanFilter';
import PriceFilter from './src/PriceFilter';
import VendorFilter from './src/VendorFilter';
import SortByFilter from './src/SortByFilter';

const filtersModuleName = 'legato.filters';

angular.module(filtersModuleName, [])
    .filter('boolean', BooleanFilter)
    .filter('byPrice', PriceFilter)
    .filter('byVendors', VendorFilter)
    .filter('sortBy', SortByFilter);

export default filtersModuleName;