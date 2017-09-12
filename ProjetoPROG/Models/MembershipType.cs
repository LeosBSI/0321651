using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoPROG.Models
{
    public class MembershipType
    {
        public short SignUpFee { get; set; }

        public byte DurationlnMonths { get; set; }

        public byte DiscountRate { get; set; }

        public byte Id { get; set; }
    }
}