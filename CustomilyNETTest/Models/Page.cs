using CustomilyNETTest.Models.Common;
using System.Collections.Generic;
namespace CustomilyNETTest.Models
{
    public class Page : BaseEntity<int>
    {
        public string Title { get; set; }
        public List<Image> Images { get; set; } 
        public List<Text> Texts { get; set; }
    }
}