using System;
using System.ComponentModel.DataAnnotations;

namespace ProTraxx.Shared.Dto
{
    //private readonly CryptoHelper _crypto;
    //CryptoHelper crypto = new CryptoHelper();
    public class UserProfileDto
    {
        public int USER_TYPE_ID { get; set; }

        public int PERSON_ID { get; set; }

        public bool EMPLOYEE_IND { get; set; }

        public int CUSTOMER_ID { get; set; }

        public DateTime BIRTH_DATE { get; set; }

        public string MIDDLE_INITIAL { get; set; }

        public string FIRST_NAME { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string LAST_NAME { get; set; }
        [Display(Name = "Email*:")]


        [Required(ErrorMessage = "Email is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EMAIL { get; set; }

        public string CUSTOMER_NAME { get; set; }

        public string CUSTOMER_URL { get; set; }


        public string COMMUNICATION_EMAIL { get; set; }

        public string USER_NAME { get; set; }
        public string PASSWORD { get; set; }
        public int POSITION_ID { get; set; }
        public int TITLE_ID { get; set; }
        public int GRADE_ID { get; set; }
        public int COUNTRY_ID { get; set; }
        public int DISTRICT_LOCATION_ID { get; set; }
        public string PERS_INFO_UPDATED { get; set; }
        public int STATE_ID { get; set; }
        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string TOWN { get; set; }
        public UserProfileDto() { }

        public UserProfileDto(UserProfileDto UserProfileDto)
        {
            USER_TYPE_ID = UserProfileDto.USER_TYPE_ID;
            PERSON_ID = UserProfileDto.PERSON_ID;
            EMPLOYEE_IND = UserProfileDto.EMPLOYEE_IND;
            CUSTOMER_ID = UserProfileDto.CUSTOMER_ID;
            BIRTH_DATE = UserProfileDto.BIRTH_DATE;
            MIDDLE_INITIAL = UserProfileDto.MIDDLE_INITIAL;
            FIRST_NAME = UserProfileDto.FIRST_NAME;
            LAST_NAME = UserProfileDto.LAST_NAME;
            EMAIL = UserProfileDto.EMAIL;
            CUSTOMER_NAME = UserProfileDto.CUSTOMER_NAME;
            CUSTOMER_URL = UserProfileDto.CUSTOMER_URL;
            COMMUNICATION_EMAIL = UserProfileDto.COMMUNICATION_EMAIL;
            USER_NAME = UserProfileDto.USER_NAME;
            // string result = crypto.DecryptR(user.PASSWORD);
            PASSWORD = UserProfileDto.PASSWORD;
            POSITION_ID = UserProfileDto.POSITION_ID;
            TITLE_ID = UserProfileDto.TITLE_ID;
            GRADE_ID = UserProfileDto.GRADE_ID;
            COUNTRY_ID = UserProfileDto.COUNTRY_ID;
            DISTRICT_LOCATION_ID = UserProfileDto.DISTRICT_LOCATION_ID;
            PERS_INFO_UPDATED = UserProfileDto.PERS_INFO_UPDATED;
            STATE_ID = UserProfileDto.STATE_ID;
            ADDRESS = UserProfileDto.ADDRESS;
            CITY = UserProfileDto.CITY;
            TOWN = UserProfileDto.TOWN;

        }

        //public string GetDecPassword(string pASSWORD)
        //{
    }
}
