namespace Legato.Service.Constants
{
    public static class Strings
    {
        internal const string ClaimType = "LegatoClaim";
        internal const string AddGuitarClaim = "AddGuitar";
        internal const string RemoveGuitarClaim = "RemoveGuitar";
        internal const string EditGuitarClaim = "EditGuitar";
        internal const string ChangeDisplayAmounClaim = "ChangeDisplayAmount";
        internal const string BlockUserClaim = "BlockUser";
        internal const string GetListOfUsers = "GetListOfUsers";
        internal const string GetCompromisedAttempts = "GetCompromisedAttempts";
        internal const string RemoveCompromisedAttempts = "RemoveCompromisedAttempts";

        public static string LowerBoundMustBePresent => "Lower bound must be present.";

        public static string UpperBoundMustBePresent => "Upper bound must be present.";

        public static string LowerBoundMustBeLessOrEqual => "Lower bound must be less or equal than upper bound.";

        public static string FilterStringIsInvalid => "Filter string is invalid.";

        public static string SortingParamsInvalid => "Both sort header and direction must be present.";

        public static string SortHeaderIsInvalid => "Sort header value is invalid.";

        public static string SortDirectionIsInvalid => "Sort direction value is invalid.";

        public static string UsernameAndPasswordAreRequired => "Username and password are required.";

        public static string DisplayAmountIsInvalid => "Display amount must be greater than 10 and lower than 1000";

        public static string UsernameIsIncorrect(string username) => $@"Username '{username}' is incorrect.";

        public static string GuitarIsInvalid => "Guitar data is invalid.";

        public static string AccessTokenIsMissing => "Access token is missing";

        public static string AccessTokenIsInvalid => "Access token is invalid";

        public static string AuthSchemeIsInvalid => "Invalid authentication scheme is used. Use 'Bearer' scheme";

        public static string AccessTokenIsBanned => "This access token is banned. Please contact your system administrator or re-login";

        public static string FailedToIssueToken => "Failed to issue access token. Please try again later";

        public static string FailedToLogOff => "Failed to log off the user. Please try again later";

        public static string UserSessionIsAlreadyBanned => "User session is already banned.";

        public static string Unauthorized => "You are not authorized to perform this action";

        public static string FailedToBlockUser(string username) => $@"Failed to ban access token for user '{username}'. Please try again later";

        public static string AntiforgeryTokenIsMissing => "Antiforgery token for this request is missing.";

        public static string AntiforgeryTokenIsInvalid => "Antiforgery token for this request is invalid.";
    }
}