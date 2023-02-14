namespace ProTraxx.Shared.Dto.SessionState
{
    public class SessionStateDto : DataModelBase
    {
        [LocalStorage("cid")]
        public int? cid { get; set; }

        [LocalStorage("pid")]
        public int? pid { get; set; }

        [LocalStorage("uid")]
        public int? uid { get; set; }

        [LocalStorage("username")]
        public string username { get; set; }

        [LocalStorage("email")]
        public string email { get; set; }

        [LocalStorage("token")]
        public string token { get; set; }

        [LocalStorage("forgotpass_token")]
        public string forgotpass_token { get; set; }
    }
}
