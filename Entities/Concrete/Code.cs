using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Code:IEntity
    {
        public int Id { get; set; }
        public int GiftId { get; set; }
        public int UserId { get; set; }
        public string CodeName { get; set; }
        public bool Status { get; set; }

    }
}
