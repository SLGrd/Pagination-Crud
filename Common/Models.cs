using System;
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
                [ValidPhoneNumber( ValidChars : "()- 0123456789", ErrorMessage ="Only ()- or numbers are allowed")]
                public string Phone { get; set; }

                [Editable(false)]
                public int RowId { get; set; }
        
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

        public class ValidPhoneNumber : ValidationAttribute
        {
                private readonly string valChars;
                public ValidPhoneNumber( string ValidChars) 
                {
                        this.valChars = ValidChars;
                }

                public override bool IsValid(object value)
                {
                        string w = value.ToString();

                        //      Checks for chars not contained in the permitted chars list
                        for (int i = 0; i < w.Length; i++) 
                                { if (!valChars.Contains(  w[i]  )) { return false; } }            

                        //      No invalid chars have been found
                        return true;
                }
        }
}