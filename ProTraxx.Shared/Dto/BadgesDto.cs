using System.Net.Http;

namespace ProTraxx.Shared.Dto
{
    public class BadgesDto
    {
        public int BADGE_ASSERTION_ID { get; set; }
        public string BADGE_NAME { get; set; }
        public string BADGE_ASSERTION_IRI { get; set; }
        public string BADGE_CRITERIA_IRI { get; set; }
        public string BADGE_DISPLAY_ITEM { get; set; }
        
             public string BADGE_ISSUER_ID { get; set; }
        public string ASSERTION_UID { get; set; }
        public string ASSERTION_ISSUEDATE { get; set; }
        public string PERSON_NAME { get; set; }
        public string PERSON_EMAIL { get; set; }
        public string PERSON_PHONE { get; set; }
        public string LOCATION { get; set; }
        public string TITLE { get; set; }
        public int PROTRAXX_TABLE_ID { get; set; }
        public string BADGE_CLASS_IRI { get; set; }
        public string BADGE_CLASS_NAME { get; set; }
        public string VERIFICATION_TYPE { get; set; }
        public int MODULE_TYPE_ID { get; set; }
        public string BADGE_MODULE_TYPE { get; set; }
        public string BADGE_IMAGE_IRI { get; set; }
        public string IMAGE_CAPTION { get; set; }
        public string IMAGE_AUTHOR { get; set; }
        public string BADGE_EVIDENCE_IRI { get; set; }
        public int BADGE_CLASS_ID { get; set; }
        public int BADGE_IMAGE_ID { get; set; }
        public int BADGE_EVIDENCE_ID { get; set; }
        public string ASSERTION_IMAGE { get; set; }
        public string ASSERTION_RAW_JSON_STRING { get; set; }
        public string ASSERTION_IMAGE_URL_TEXT { get; set; }
        public string ISSUED_TO { get; set; }
      
    public string BADGE_ISSUER_NAME { get; set; }

    public string ISSUER_LOGO { get; set; }

    public string ISSUER_URL { get; set; }
}
}