using System.ComponentModel.DataAnnotations;

namespace Common.Models
{
    public class AmigoModel
    {
        [Required]
        [MinLength(4, ErrorMessage = "Nome must have at least 4 chars")]
        [MaxLength(40, ErrorMessage = "Nome must have max 40 chars")]
        public string Nome { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Address must have at least 4 chars")]
        [MaxLength(40, ErrorMessage = "Address must have max 40 chars")]
        public string Address { get; set; }

        [Required]
        [MaxLength(40, ErrorMessage = "Email must have max 40 chars")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Phone have at least 4 chars")]
        [MaxLength(24, ErrorMessage = "Phone must have max 24 chars")]
        public string Phone { get; set; }

        [Editable(false)]
        public int RowId { get; set; }
        public string GetEnumName { get; internal set; }

        public AmigoModel()
        {
            Nome = "";
            Address = "";
            Email = "";
            Phone = "";
            RowId = 0;
        }
        public AmigoModel(string nome, string address, string email, string phone, int rowId)
        {
            Nome = nome;
            Address = address;
            Email = email;
            Phone = phone;
            RowId = rowId;
        }
    }
}