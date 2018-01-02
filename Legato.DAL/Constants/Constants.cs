using System;


namespace Legato.DAL.Constants
{
    static class Constants
    {
        internal const string AddGuitarClaim = "AddGuitar";
        internal const string RemoveGuitarClaim = "RemoveGuitar";
        internal const string EditGuitarClaim = "EditGuitar";
        internal const string ChangeDisplayAmountClaim = "ChangeDisplayAmount";
        internal const string BlockUserClaim = "BlockUser";
        internal const string GetListOfUsersClaim = "GetListOfUsers";
        internal const string GetCompromisedAttemptsClaim = "GetCompromisedAttempts";
        internal const string RemoveCompromisedAttemptsClaim = "RemoveCompromisedAttempts";

        internal static string[] SoundboxNames => new[] { "Single", "Humbucker" };

        internal static byte[] StringNumbers => new byte[] { 6, 7, 8, 10, 12 };

        internal static byte[] BassStringNumbers => new byte[] { 1, 4, 5, 7, 8, 10 };

        internal static string[] ClassicalGuitarStringTypes => new[] { "Nylon", "Fluorocarbon" };

        internal static string DefaultConnectionStringName => "DumbshitConnection";

        internal static DateTime Now() => DateTime.UtcNow;
    }
}