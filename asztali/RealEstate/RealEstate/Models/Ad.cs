using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    internal class Ad
    {

        public int Area { get; set; }
        public Category? Category { get; set; }
        public DateTime CreateAt { get; set; }
        public string? Description { get; set; }
        public int Floors { get; set; }
        public bool FreeOfCharge { get; set; }
        public int Id { get; set; }
        public string? ImgUrl { get; set; }
        public string? LatLong { get; set; }
        public int Rooms { get; set; }
        public Seller? Seller { get; set; }

        public static List<Ad> LoadFromJson(string fileName)
        {
            string json = File.ReadAllText(fileName);

            List<Ad>? ads = JsonConvert.DeserializeObject<List<Ad>>(json);

            return ads ?? new List<Ad>();
        }

    }
}
