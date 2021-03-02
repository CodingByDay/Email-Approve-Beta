using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parser4mails.Assets
{
    public class NameValueObjectList
    //subject = subject, excerpt = excerpt, messageId = messageId, addrfrom2 = addrfrom2, white_email = white_email, white_optin = white_optin, white_optout = white_optout, white_affiliate = white_affiliate, uID = uID, enddate = enddate, white_duration = white_duration 
    {
        public string subject { get; set; }

        public string excerpt { get; set; }

        public string messageId { get; set; }


        public string addrfrom2 { get; set; }


        public string white_email { get; set; }


        public string white_optin { get; set; }


        public string white_optout { get; set; }


        //white_affiliate = white_affiliate, uID = uID, enddate = enddate, white_duration = white_duration 

        public string white_affiliate { get; set; }


        public string uID { get; set; }


        public string enddate { get; set; }



        public string white_duration { get; set; }
    }
}
