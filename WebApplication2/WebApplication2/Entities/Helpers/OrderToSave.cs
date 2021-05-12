using System.Collections.Generic;

namespace WebApplication2.Entities.Helpers
{
    public class OrderToSave
    {
        public string name { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip5 { get; set; }
        public string zip4 { get; set; }
        public string cardname { get; set; }
        public string cardnumber { get; set; }
        public List<CartToSave> detail { get; set; }
    }
}