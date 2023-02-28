﻿using System;

namespace OnlineShop.DAL.Core
{
    public abstract class BaseEntity
    {
        public BaseEntity() 
        {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }

        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set;}
        public int? ModifyUser { get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
