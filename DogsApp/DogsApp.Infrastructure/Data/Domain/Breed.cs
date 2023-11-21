using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogsApp.Infrastructure.Data.Domain
{
    public class Breed
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        public virtual IEnumerable<Dog> Dogs { get; set; } = null!;
    }
}
