using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookApp.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public virtual Car Car { get; set; }
        public int FeatureId { get; set; }
        public virtual Feature Feature { get; set; }
        public bool Available { get; set; }
    }
}
