using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtUser.Core.Entities
{
    public class Appellation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Personal>? Personal { get; set; }
    }
}
