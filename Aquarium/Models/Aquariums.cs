using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Models
{
    class Aquariums
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }

        public virtual ICollection<MarineLife> MarineLife { get; set; } = new HashSet<MarineLife>();
    }
}
