using System.ComponentModel.DataAnnotations;

namespace StudentDb.Models
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        [Length(0, 4)]
        public int DoorNo { get; set; }
        [StringLength(30)]
        public string Street { get; set; }
        [StringLength(30)]
        public string City { get; set; }
        [StringLength(30)]
        public string State { get; set; }
        [Length(0, 7)]
        public int Pin { get; set; }
    }
}
