using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Evimiz.Models
{
    public class NumberKeyCodeSecond
    {

        public NumberKeyCodeSecond()
        {
            Advertisements = new HashSet<Advertisement>();
        }
        public int Id { get; set; }

        public string Kcode { get; set; }

        public virtual ICollection<Advertisement> Advertisements { get; set; }

    }
}
