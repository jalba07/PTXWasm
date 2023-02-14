namespace ProTraxx.Shared.Dto
{
    public class WebinarDto
    {
        public string API_SECRET { get; set; }
        public string API_KEY { get; set; }

        public int WEBINAR_TYPE_ID { get; set; }
        public WebinarDto() { }

        public WebinarDto(WebinarDto WebinarDto)
        {
            API_SECRET = WebinarDto.API_SECRET;
            API_KEY = WebinarDto.API_KEY;
            WEBINAR_TYPE_ID = WebinarDto.WEBINAR_TYPE_ID;

        }

    }
}
