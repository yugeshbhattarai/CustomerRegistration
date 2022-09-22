using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrowStudioCustomer.Models
{
    public class CustomerDetail
    {

       
            [Key]
            public int CustomerID { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(50)")]
            public string FirstName { get; set; }

            
            [Column(TypeName = "nvarchar(50)")]
            public string MiddleName { get; set; }
        
            [Required]
            [Column(TypeName = "nvarchar(50)")]
            public string LastName { get; set; }

            [Required]
            [Column(TypeName = "nvarchar(10)")]
            public string DateofBirth { get; set; }

            [Required]
            [Column(TypeName = "varchar(100)")]
            public string EmailAddress { get; set; }

            [Required]
            [Column(TypeName = "varchar(100)")]
            public string Address { get; set; }


            [Required]
            [Column(TypeName = "varchar(10)")]
            public string PhoneNumber { get; set; }

    }
}
