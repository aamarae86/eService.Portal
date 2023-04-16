using eService.Portal.Debugging;

namespace eService.Portal
{
    public class PortalConsts
    {
        public const string LocalizationSourceName = "Portal";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "9a625a58b1e14830b57dfe4de5deda46";
    }
}
