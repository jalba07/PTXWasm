namespace ProTraxx.Shared.Dto.Utilities
{
    public class APIAppSettingsDto
    {
        public class AppSettings
        {
            public string AllowedHosts { get; set; }
            public ConnectionStrings ConnectionStrings { get; set; }
            public ErrorSettings ErrorSettings { get; set; }
            public LogSettings LogSettings { get; set; }
            public SystemSettings SystemSettings { get; set; }
        }

        public class ConnectionStrings
        {
            public string PTXTRNSDB { get; set; }
            public string PTXRPLDB { get; set; }
        }

        public class ErrorSettings
        {
            public string Email { get; set; }
            public string LogDir { get; set; }
        }

        public class LogSettings
        {
            public LogLevel LogLevel { get; set; }
        }

        public class LogLevel
        {
            public string Default { get; set; }
            public string MicrosoftAspNetCore { get; set; }
        }


        public class SystemSettings
        {
            public bool PlaceHolder { get; set; }
        }
    }
}
