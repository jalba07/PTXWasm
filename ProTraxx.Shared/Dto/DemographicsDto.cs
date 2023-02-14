namespace ProTraxx.Shared.Dto
{
    public class DemographicsDto
    {
        public int COUNTRY_ID { get; set; }

        public string COUNTRY_NAME { get; set; }

        public int STATE_ID { get; set; }

        public string STATE_NAME { get; set; }

        public int TITLE_ID { get; set; }

        public string TITLE_NAME { get; set; }
        public int DISTRICT_LOCATION_ID { get; set; }

        public string DISTRICT_LOCATION_NAME { get; set; }
        public string TOWN { get; set; }
        public string NAME { get; set; }

        public int GRADE_ID { get; set; }

        public string GRADE_NAME { get; set; }

        public DemographicsDto()
        {
        }

        public DemographicsDto(DemographicsDto DemographicsDto)
        {
            COUNTRY_ID = DemographicsDto.COUNTRY_ID;
            COUNTRY_NAME = DemographicsDto.COUNTRY_NAME;
            STATE_ID = DemographicsDto.STATE_ID;
            STATE_NAME = DemographicsDto.STATE_NAME;
            TITLE_ID = DemographicsDto.TITLE_ID;
            TITLE_NAME = DemographicsDto.TITLE_NAME;
            DISTRICT_LOCATION_NAME = DemographicsDto.DISTRICT_LOCATION_NAME;
            DISTRICT_LOCATION_ID = DemographicsDto.DISTRICT_LOCATION_ID;
            TOWN = DemographicsDto.TOWN;
            NAME = DemographicsDto.NAME;
            GRADE_ID = DemographicsDto.GRADE_ID;
            GRADE_NAME = DemographicsDto.GRADE_NAME;


        }
    }
}
