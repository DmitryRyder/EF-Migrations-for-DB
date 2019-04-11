﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace models.Data
{
    public class Building : BaseModel
    {
        public string Name { get; set; }
        public string Post { get; set; }
        public int Number_of_floors { get; set; }

        public IList<Room> rooms { get; set; }
        public Building()
        {
            rooms = new List<Room>();
        }
    }
}
