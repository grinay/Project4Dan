using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project4Dan.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TextPhraseToDisplay { get; set; }
        public string DataToDisplayInPieChartOrGraph { get; set; }
    }
}