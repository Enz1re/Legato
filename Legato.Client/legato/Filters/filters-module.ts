import angular from "angular";

import BooleanFilter from "./src/BooleanFilter";

const filtersModuleName = "legato.filters";

angular.module(filtersModuleName, [])
    .filter("boolean", BooleanFilter);

export default filtersModuleName;