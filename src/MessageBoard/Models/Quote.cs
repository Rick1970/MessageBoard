using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MessageBoard.Models
{
    public class Quote
    {
        public int QuoteId { get; set;}

        public string Title {get; set;}

        public string Author {get; set;}

        public string Url { get; set;}

        public string Media {get; set;}

        public string Cat {get; set;}
    }

}
