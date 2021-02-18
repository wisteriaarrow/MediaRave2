using System;
using System.Collections.Generic;
using System.Text;

namespace Media_Rave.LoginData.Models
{
    public class Token
    {
        public int ID { get; set; 
        public string Access_token { get; set; }
        public string error_descritpion { get; set; }
        public DateTime expire_date { get; set; }

        public Token() { }

    }
    }
}

