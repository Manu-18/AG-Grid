using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AG_Grid.Models
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        [Column("FName", TypeName = "varchar(100)")]
        public string? FirstName { get; set; }
        [Column("LName", TypeName = "varchar(100)")]
        public string? LastName { get; set;}
        public int Contact { get; set; }
        [Column("colony", TypeName = "varchar(100)")]
        public string? Colony { get; set; }
        [Column("city", TypeName = "varchar(100)")]
        public string? City { get; set; }
        [Column("country", TypeName = "varchar(100)")]
        public string?  Country { get; set; }

    }
}
