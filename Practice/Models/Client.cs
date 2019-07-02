using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Client
    {
        public int ClientID
        {
            get;
            set;
        }
        public string ClientFIO
        {
            get;
            set;
        }
        public int ClientMobile
        {
            get;
            set;
        }
        public string ClientCountry
        {
            get;
            set;
        }
        public string ClientCity
        {
            get;
            set;
        }
        public string ClientAdress
        {
            get;
            set;
        }
    }
}