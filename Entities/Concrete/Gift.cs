using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Gift:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Rate { get; set; }
        public bool Status { get; set; }
    }
}
