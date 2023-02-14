namespace ProTraxx.Shared.Dto.Authentication
{
    public class AuthenticateProTraxx
    {
        public int PERSON_ID { get; set; }
        public string FIRST_NAME { get; set; }
        public string LAST_NAME { get; set; }
        public string EMAIL { get; set; }
        public int CatalogUserID { get; set; }
        public int LoginUserID { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string CUSTOMER_URL { get; set; }
        public string SUPPORT_EMAIL { get; set; }
        public string CATALOG_URL { get; set; }
        public int STATE_ID { get; set; }
        public string PERS_INFO_UPDATED { get; set; }
        public int USER_ID { get; set; }
        public string PASSWORD { get; set; }
        public int USER_GROUP_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public string MIDDLE_INIT { get; set; }
        public string Token { get; set; } = "";
        public AuthenticateProTraxx authenticateProTraxx { get; set; }

        //public bool IsDeleting { get; set; } = false;

        public AuthenticateProTraxx() { }

        public AuthenticateProTraxx(AuthenticateProTraxx Authenticate)
        {
            PERSON_ID = Authenticate.PERSON_ID;
            FIRST_NAME = Authenticate.FIRST_NAME;
            LAST_NAME = Authenticate.LAST_NAME;
            EMAIL = Authenticate.EMAIL;
            CatalogUserID = Authenticate.CatalogUserID;
            LoginUserID = Authenticate.LoginUserID;
            CUSTOMER_NAME = Authenticate.CUSTOMER_NAME;
            CUSTOMER_URL = Authenticate.CUSTOMER_URL;
            SUPPORT_EMAIL = Authenticate.SUPPORT_EMAIL;
            CATALOG_URL = Authenticate.CATALOG_URL;
            STATE_ID = Authenticate.STATE_ID;
            PERS_INFO_UPDATED = Authenticate.PERS_INFO_UPDATED;
            USER_ID = Authenticate.USER_ID;
            PASSWORD = Authenticate.PASSWORD;
            USER_GROUP_ID = Authenticate.USER_GROUP_ID;
            CUSTOMER_ID = Authenticate.CUSTOMER_ID;
            MIDDLE_INIT = Authenticate.MIDDLE_INIT;
            Token = "";
        }
    }
}
