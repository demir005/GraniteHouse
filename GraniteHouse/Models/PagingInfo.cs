using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraniteHouse.Models
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }

        public int ItemPerPage { get; set; }

        public int CurrentPage { get; set; }

        public int totalPage => (int)Math.Ceiling((decimal)TotalItems / ItemPerPage);

        //This will be used to build URL
        public string urlParam { get; set; }
    }
}
