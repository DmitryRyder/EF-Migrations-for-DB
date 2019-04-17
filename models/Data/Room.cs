using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace models.Data
{
    public class Room : BaseModel
    {
        public int Number { get; set; }
        public double Area { get; set; }
        public int Floor { get; set; }
        [ForeignKey("Type_of_roomId")]
        public Type_of_room TypeOfRoom { get; set; }
        [ForeignKey("BuildingId")]
        public Building Building { get; set; }
        public List<Room_rental> Room_rentals { get; set; }

        public Room()
        {
            Room_rentals = new List<Room_rental>();
        }
    }
}
