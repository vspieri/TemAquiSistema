using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tem_Aqui.Models
{
    [Table("Login")]
    public class Login
    {
            [Column("LoginId")]
            [Display(Name = "Código do Login")]

            public int Id { get; set; }

            [Column("LoginNome")]
            [Display(Name = "Nome do Cliente")]

            public string LoginNome { get; set; } = string.Empty;

        [Column("LoginSenha")]
        [Display(Name = "Senha do Cliente")]

        public string LoginSenha { get; set; } = string.Empty;


    }
}
