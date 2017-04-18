using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium.Models
{
    class MarineLife
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime DateAddedToTank
        {
            get
            {
                return this.dateAddedToTank.HasValue
                    ? this.dateAddedToTank.Value
                    : DateTime.Now;
            }
            set { this.dateAddedToTank = value; } }
        private DateTime? dateAddedToTank = null;
        public bool IsInQuarenteen { get; set; }

        public virtual ICollection<Aquariums> Aquariums { get; set; } = new HashSet<Aquariums>();
        public virtual ICollection<Oceans> Oceans { get; set; } = new HashSet<Oceans>();
    }
}
