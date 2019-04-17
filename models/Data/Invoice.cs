using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Data
{
    public class Invoice 
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public int Number { get; set; }
        public DateTime DateOfCreate { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool StatusOfPayment { get; set; }
        [ForeignKey("Room_RentalId ")]
        public Room_rental Room_Rental{ get; set; }
    }
}
