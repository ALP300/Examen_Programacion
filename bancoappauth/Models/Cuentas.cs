
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bancoappauth.Models// Assuming this is your namespace
{
    [Table("t_cuentaBancaria")] // Set the table name in the database
    public class Cuentas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumeroC { get; set; } // Primary key, auto-generated

        [Required]
        [StringLength(100)] // Limit name length
        public string? NombreT { get; set; }

        [Required]
        [StringLength(50)] // Limit type length
        public string? TipoC { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")] // Specify decimal type with precision
        public decimal Saldo { get; set; }

        [Required]
        [EmailAddress] // Validate email format
        public string? Correo { get; set; }

        [Required]
        [MinLength(8)] // Minimum password length
        public string? Contraseña { get; set; } // Store the hashed password
    }
}