using System;
using System.ComponentModel.DataAnnotations;

namespace ProTraxx.Shared.Dto
{
	[Serializable]
	public class UserDto
    {
        public int USER_TYPE_ID { get; set; }

        public int PERSON_ID { get; set; }

        public bool EMPLOYEE_IND { get; set; }

        public int CUSTOMER_ID { get; set; }

        public DateTime BIRTH_DATE { get; set; }


        public string FIRST_NAME { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Last Name cannot have less than 3 characters and more than 20 characters in length")]
        public string LAST_NAME { get; set; }
        [Display(Name = "Email*:")]
        [Required(ErrorMessage = "You must specify your Email.")]
        public string EMAIL { get; set; }

        public string CUSTOMER_NAME { get; set; }

        public string CUSTOMER_URL { get; set; }



        public string USER_NAME { get; set; }



        public string PASSWORD { get; set; }

        public string ADDRESS { get; set; }
        public string CITY { get; set; }
        public string TOWN { get; set; }
        public UserDto()
        {
        }
    }
}
