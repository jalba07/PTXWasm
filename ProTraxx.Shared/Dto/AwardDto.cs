using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTraxx.Shared.Dto
{
    public class AwardDto
    {
        public int AWARD_TYPE_ID { get; set; }
        public string AWARD_TYPE { get; set; }
        public string AWARD_TYPE_GROUP { get; set; }
        public int ACTIVITY_GROUP_TOPIC_ID { get; set; }
        public int GROUP_SORT { get; set; }
        public bool ACTIVE_IND { get; set; }
        public bool ASSIGNED_IND  { get; set; }
        public decimal CONVERSION_RATE { get; set; }
        public decimal AWARD_AMOUNT { get; set; }
        


    }
}
