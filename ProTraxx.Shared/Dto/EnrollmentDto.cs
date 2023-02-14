using System;

namespace ProTraxx.Shared.Dto
{
    public class EnrollmentDto
    {
        public bool ALLOW_IPDP_PUBLIC_VIEW_IND { get; set; }
        public bool EVALUATION_REQUIRED_IND { get; set; }
        public bool LEARNING_COMMUNITY_FORUMS_IND { get; set; }
        public bool LEARNING_COMMUNITY_FORUMS_PUBLIC_VIEW_IND { get; set; }
        public bool LEARNING_COMMUNITY_IND { get; set; }
        public bool LEARNING_COMMUNITY_IPDP_IND { get; set; }
        public bool LEARNING_COMMUNITY_IPDP_PUBLIC_VIEW_IND { get; set; }
        public bool LEARNING_COMMUNITY_PARTICIPANT_TRACKING_IND { get; set; }
        public bool LEARNING_COMMUNITY_PUBLIC_VIEW_IND { get; set; }
        public bool LEARNING_COMMUNITY_TRACKING_PUBLIC_VIEW_IND { get; set; }
        public bool PRE_EVALUATION_REQUIRED_IND { get; set; }
        public Boolean ECOMMERCE_IND { get; set; }
        public DateTime ENROLLMENT_DATE { get; set; }
        public DateTime SCHEDULE_DATE { get; set; }
        public int ACTIVITY_CLASS_EVALUATION_TYPE_ID { get; set; }
        public int ACTIVITY_CLASS_ID { get; set; }
        public int ACTIVITY_ID { get; set; }
        public int AWARD_STATUS_ID { get; set; }
        public int AWARD_TYPE_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public int ENROLLMENT_ID { get; set; }
        public int FORM_ID { get; set; }
        public int LEARNING_COMMUNITY_ID { get; set; }
        public int LMS_COURSE_ID { get; set; }
        public int LMS_ENROLLMENT_ID { get; set; }
        public int LMS_INSTANCE_ID { get; set; }
        public int LMS_TYPE_ID { get; set; }
        public int PAYMENT_ID { get; set; }
        public int PAYMENT_METHOD_ID { get; set; }
        public int PERSON_ID { get; set; }
        public int PRE_EVALUATION_TYPE_ID { get; set; }
        public int PRE_FORM_ID { get; set; }
        public int TRANSACTION_ID { get; set; }
        public int USER_ID { get; set; }
        public string ACTIVITY_CLASS_TYPE { get; set; }
        public string ACTIVITY_NAME { get; set; }
        public string ATTENDANCE_STATUS { get; set; }
        public string AWARD_AMOUNT { get; set; }
        public string AWARD_IND { get; set; }
        public string AWARD_STATUS { get; set; }
        public string AWARD_STATUS_WITH_URL { get; set; }
        public string AWARD_TYPE { get; set; }
        public string CLASS_COMPLETED_DATE { get; set; }
        public string CUSTOMER_NAME { get; set; }
        public string DELETE_IND { get; set; }
        public string DESCR { get; set; }
        public string DETAIL_IND { get; set; }
        public string EMAIL { get; set; }
        public string ENROLLMENT_STATUS_ID { get; set; }
        public string EVALUATION_IND { get; set; }
        public string FISCAL_YEAR { get; set; }
        public string IMAGE_URL { get; set; }
        public string INSTRUCTOR_IN_CLASS { get; set; }
        public string LMS_URL { get; set; }
        public string ORDER_ID { get; set; }
        public string PAYMENT_NAME { get; set; }
        public string PRE_EVALUATION_IND { get; set; }
        public string PRICE { get; set; }
        public string STATUS { get; set; }
        public string SUB_TITLE { get; set; }
        public string TAX_NUMBER { get; set; }
        public string TRANSACTION_NUMBER { get; set; }
        public string WAITLIST_IND { get; set; }
        public string ACTIVITY_CODE { get; set; }

        public EnrollmentDto()
        {
        }

        public EnrollmentDto(EnrollmentDto EnrollmentDto)
        {
            ALLOW_IPDP_PUBLIC_VIEW_IND = EnrollmentDto.ALLOW_IPDP_PUBLIC_VIEW_IND;
            EVALUATION_REQUIRED_IND = EnrollmentDto.EVALUATION_REQUIRED_IND;
            LEARNING_COMMUNITY_FORUMS_IND = EnrollmentDto.LEARNING_COMMUNITY_FORUMS_IND;
            LEARNING_COMMUNITY_FORUMS_PUBLIC_VIEW_IND = EnrollmentDto.LEARNING_COMMUNITY_FORUMS_PUBLIC_VIEW_IND;
            LEARNING_COMMUNITY_IND = EnrollmentDto.LEARNING_COMMUNITY_IND;
            LEARNING_COMMUNITY_IPDP_IND = EnrollmentDto.LEARNING_COMMUNITY_IPDP_IND;
            LEARNING_COMMUNITY_IPDP_PUBLIC_VIEW_IND = EnrollmentDto.LEARNING_COMMUNITY_IPDP_PUBLIC_VIEW_IND;
            LEARNING_COMMUNITY_PARTICIPANT_TRACKING_IND = EnrollmentDto.LEARNING_COMMUNITY_PARTICIPANT_TRACKING_IND;
            LEARNING_COMMUNITY_PUBLIC_VIEW_IND = EnrollmentDto.LEARNING_COMMUNITY_PUBLIC_VIEW_IND;
            LEARNING_COMMUNITY_TRACKING_PUBLIC_VIEW_IND = EnrollmentDto.LEARNING_COMMUNITY_TRACKING_PUBLIC_VIEW_IND;
            PRE_EVALUATION_REQUIRED_IND = EnrollmentDto.PRE_EVALUATION_REQUIRED_IND;
            ECOMMERCE_IND = EnrollmentDto.ECOMMERCE_IND;
            ENROLLMENT_DATE = EnrollmentDto.ENROLLMENT_DATE;
            SCHEDULE_DATE = EnrollmentDto.SCHEDULE_DATE;
            ACTIVITY_CLASS_EVALUATION_TYPE_ID = EnrollmentDto.ACTIVITY_CLASS_EVALUATION_TYPE_ID;
            ACTIVITY_CLASS_ID = EnrollmentDto.ACTIVITY_CLASS_ID;
            ACTIVITY_ID = EnrollmentDto.ACTIVITY_ID;
            AWARD_STATUS_ID = EnrollmentDto.AWARD_STATUS_ID;
            AWARD_TYPE_ID = EnrollmentDto.AWARD_TYPE_ID;
            CUSTOMER_ID = EnrollmentDto.CUSTOMER_ID;
            ENROLLMENT_ID = EnrollmentDto.ENROLLMENT_ID;
            FORM_ID = EnrollmentDto.FORM_ID;
            LEARNING_COMMUNITY_ID = EnrollmentDto.LEARNING_COMMUNITY_ID;
            LMS_COURSE_ID = EnrollmentDto.LMS_COURSE_ID;
            LMS_ENROLLMENT_ID = EnrollmentDto.LMS_ENROLLMENT_ID;
            LMS_INSTANCE_ID = EnrollmentDto.LMS_INSTANCE_ID;
            LMS_TYPE_ID = EnrollmentDto.LMS_TYPE_ID;
            PAYMENT_ID = EnrollmentDto.PAYMENT_ID;
            PAYMENT_METHOD_ID = EnrollmentDto.PAYMENT_METHOD_ID;
            PERSON_ID = EnrollmentDto.PERSON_ID;
            PRE_EVALUATION_TYPE_ID = EnrollmentDto.PRE_EVALUATION_TYPE_ID;
            PRE_FORM_ID = EnrollmentDto.PRE_FORM_ID;
            TRANSACTION_ID = EnrollmentDto.TRANSACTION_ID;
            USER_ID = EnrollmentDto.USER_ID;
            ACTIVITY_CLASS_TYPE = EnrollmentDto.ACTIVITY_CLASS_TYPE;
            ACTIVITY_NAME = EnrollmentDto.ACTIVITY_NAME;
            ATTENDANCE_STATUS = EnrollmentDto.ATTENDANCE_STATUS;
            AWARD_AMOUNT = EnrollmentDto.AWARD_AMOUNT;
            AWARD_IND = EnrollmentDto.AWARD_IND;
            AWARD_STATUS = EnrollmentDto.AWARD_STATUS;
            AWARD_STATUS_WITH_URL = EnrollmentDto.AWARD_STATUS_WITH_URL;
            AWARD_TYPE = EnrollmentDto.AWARD_TYPE;
            CLASS_COMPLETED_DATE = EnrollmentDto.CLASS_COMPLETED_DATE;
            CUSTOMER_NAME = EnrollmentDto.CUSTOMER_NAME;
            DELETE_IND = EnrollmentDto.DELETE_IND;
            DESCR = EnrollmentDto.DESCR;
            DETAIL_IND = EnrollmentDto.DETAIL_IND;
            EMAIL = EnrollmentDto.EMAIL;
            ENROLLMENT_STATUS_ID = EnrollmentDto.ENROLLMENT_STATUS_ID;
            EVALUATION_IND = EnrollmentDto.EVALUATION_IND;
            FISCAL_YEAR = EnrollmentDto.FISCAL_YEAR;
            IMAGE_URL = EnrollmentDto.IMAGE_URL;
            INSTRUCTOR_IN_CLASS = EnrollmentDto.INSTRUCTOR_IN_CLASS;
            LMS_URL = EnrollmentDto.LMS_URL;
            ORDER_ID = EnrollmentDto.ORDER_ID;
            PAYMENT_NAME = EnrollmentDto.PAYMENT_NAME;
            PRE_EVALUATION_IND = EnrollmentDto.PRE_EVALUATION_IND;
            PRICE = EnrollmentDto.PRICE;
            STATUS = EnrollmentDto.STATUS;
            SUB_TITLE = EnrollmentDto.SUB_TITLE;
            TAX_NUMBER = EnrollmentDto.TAX_NUMBER;
            TRANSACTION_NUMBER = EnrollmentDto.TRANSACTION_NUMBER;
            WAITLIST_IND = EnrollmentDto.WAITLIST_IND;
            ACTIVITY_CODE = EnrollmentDto.ACTIVITY_CODE;


        }




    }
}
