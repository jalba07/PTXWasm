namespace ProTraxx.Shared.Dto
{
    public class LMSDto
    {

        public string LMS_URL { get; set; }
        public int MOODLE_COURSE_ID { get; set; }
        public int LMS_INSTANCE_ID { get; set; }
        public int CUSTOMER_ID { get; set; }
        public LMSDto() { }
        public LMSDto(LMSDto LMSDto)
        {
            LMS_URL = LMSDto.LMS_URL;
            MOODLE_COURSE_ID = LMSDto.MOODLE_COURSE_ID;
            LMS_INSTANCE_ID = LMSDto.LMS_INSTANCE_ID;
            CUSTOMER_ID = LMSDto.CUSTOMER_ID;

        }
    }
}
