using Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Todo : BaseEntity
    {
        public string Content { get; set; }

        public User User { get; set; }

    }
}
