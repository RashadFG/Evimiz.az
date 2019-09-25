using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class Home
    {
        public int Id { get; set; }

        public int? NewPlaceId { get; set; }
        public virtual NewPlace NewPlace { get; set; }

        public int? OldPlaceId { get; set; }
        public virtual OldPlace OldPlace { get; set; }

        public int? HouseId { get; set; }
        public virtual House House { get; set; }

        public int? VillaId { get; set; }
        public virtual Villa Villa { get; set; }

        public int? YardHouseId { get; set; }
        public virtual YardHouse YardHouse { get; set; }

        public int? OfficeId { get; set; }
        public virtual Office Office { get; set; }

        public int? PropertyObjectId { get; set; }
        public virtual PropertyObject PropertyObject { get; set; }
    }
}
