namespace Legato.DAL.Constants
{
    public static class Messages
    {
        public static string NotFound(string entity) => $@"{entity} was not found in the database.";

        public static string NotAuthenticated(string entity) => $@"{entity} is not authenticated.";
    }
}
