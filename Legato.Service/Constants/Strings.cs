﻿namespace Legato.Service.Constants
{
    public static class Strings
    {
        public static string LowerBoundMustBePresent => "Lower bound must be present.";

        public static string UpperBoundMustBePresent => "Upper bound must be present.";

        public static string LowerBoundMustBeLessOrEqual => "Lower bound must be less or equal than upper bound.";

        public static string FilterStringIsInvalid => "Filter string is invalid.";

        public static string SortingParamsInvalid => "Both sort header and direction must be present.";

        public static string SortHeaderIsInvalid => "Sort header value is invalid.";

        public static string SortDirectionIsInvalid => "Sort direction value is invalid.";

        public static string UsernameAndPasswordAreRequired => "Username and password are required.";

        public static string UsernameIsIncorrect(string username) => $@"Username '{username}' is incorrect.";

        public static string GuitarIsInvalid => "Guitar data is invalid.";

        public static string AccessTokenIsMissing => "Access token is missing";

        public static string AccessTokenIsInvalid => "Access token is invalid";
    }
}