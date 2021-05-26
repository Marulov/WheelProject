using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Wheel:IEntity
    {
        public int Id { get; set; }
        public int GiftId { get; set; }
        public int CodeId { get; set; }
        public DateTime Date { get; set; }

    }
}
