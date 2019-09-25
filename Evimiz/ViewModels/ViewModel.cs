using Evimiz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.ViewModels
{
    public class ViewModel
    {
        public IEnumerable<Advertisement> Advertisements { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<Home> Homes { get; set; }
        public IEnumerable<Image> Images { get; set; }
        public IEnumerable<Metro> Metros { get; set; }
        public IEnumerable<NewPlace> NewPlaceS { get; set; }
        public IEnumerable<News> Newss { get; set; }
        public IEnumerable<NumberKeyCode> NumberKeyCodes { get; set; }
        public IEnumerable<NumberKeyCodeSecond> NumberKeyCodeSeconds { get; set; }
        public IEnumerable<Office> OfficeS { get; set; }
        public IEnumerable<OldPlace> OldPlaceS { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<PropertyCategory> PropertyCategorys { get; set; }
        public IEnumerable<PropertyDocument> PropertyDocuments { get; set; }
        public IEnumerable<PropertyRepair> PropertyRepairs { get; set; }
        public IEnumerable<PropertyObject> PropertyObject { get; set; }
        public IEnumerable<Region> Regions { get; set; }
        public IEnumerable<Rent> Rents { get; set; }
        public IEnumerable<Village> Villages { get; set; }
        public IEnumerable<House> Houses { get; set; }
        public IEnumerable<Villa> VillaS { get; set; }
        public IEnumerable<YardHouse> YardHouseS { get; set; }
        public IEnumerable<İstifadəçi> Users { get; set; }
    }
}
