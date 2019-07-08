using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practice.Models
{
    public class Request
    {
        public int MkId
        {
            get;
            set;
        }
        public int ModelId
        {
            get;
            set;
        }
        public int ClientId
        {
            get;
            set;
        }
        public int TotalCost
        {
            get;
            set;
        }
        public string Notes
        {
            get;
            set;
        }
    }
}