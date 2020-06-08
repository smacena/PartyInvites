using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PartyInvites
{
    public class GuestResponse
    {
        //prop
        //propfull
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool? WillAttend { get; set; }


    }
}