using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parser4mails.Assets
{
    public class NameValueObjectList
    {
        //Window mailwindow = new mailwindow(subject, excerpt, messageId, addrfrom2, white_email, white_optin, white_optout, white_affiliate, uID, enddate, white_duration);

        //white_email = emailclass2.Hits.HitsHits[0].Source.Email;
        //white_optin = emailclass2.Hits.HitsHits[0].Source?.Optin;
        //white_optout = emailclass2.Hits.HitsHits[0].Source?.Optout;
        //white_affiliate = emailclass2.Hits.HitsHits[0].Source?.Affiliatelink;
        //white_duration = emailclass2.Hits.HitsHits[0].Source?.Duration;


        public string subject { get; set; }
        public string excerpt { get; set; }
        public string messageId { get; set; }
        public string addrfrom2 { get; set; }
        public string white_email { get; set; }
        public string white_optin { get; set; }
        public string white_optout { get; set; }
        public string white_affiliate { get; set; }
        public string uID { get; set; }
        public string enddate { get; set; }
        public string white_duration { get; set; }


    }
}
