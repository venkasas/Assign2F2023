using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assign2F2023.Models.Entities
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public List<Image> Images { get; set; }

    }
}