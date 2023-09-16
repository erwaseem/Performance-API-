using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Model
{
    public class RegistrationDTO
    {
        public int APPLICATION_ID { get; set; }
        public string? FIRST_NAME { get; set; }
        public string? MIDDLE_NAME { get; set; }
        public string? LAST_NAM { get; set; }
        public string? E_MAIL_ID { get; set; }
        public string? PHONE_NO { get; set; }
        public DateTime? INSERT_DATE { get; set; }
        public string? USER_STATUS { get; set; }
        public string? PHONE_EXT { get; set; }
        public string? COMP_NAME { get; set; }
    }
}
