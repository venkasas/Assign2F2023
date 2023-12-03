using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign2F2023.Models.Entities
{
    public class User
    {
         public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public List<Image> Images { get; set; }
  
        
    }
}