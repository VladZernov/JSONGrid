using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JSONGrid.Models
{
    public partial class Product
    {
        public string Id { get; set; }
        public string ImgSrc { get; set; }
        public string Name { get; set; }
        public string FullDescription { get; set; }
        public string Price { get; set; }
    }
}