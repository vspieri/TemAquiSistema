using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Tem_Aqui.Models
{
    public class TabelClientes
    {
        [Column("ClienteId")]
        [Display(Name = "Código do Cliente")]

        public int Id { get; set; }

        [Column("ClienteNome")]
        [Display(Name = "Nome do Cliente")]

        public string ClienteNome { get; set; } = string.Empty;

        [Column("EndereçoId")]
        [Display(Name = "Endereço do Cliente")]

        public string EndereçoId { get; set; } = string.Empty;

        [Column("EmailId")]
        [Display(Name = "Email do Cliente")]

        public string EmailId { get; set; } = string.Empty;

        [Column("NumeroId")]
        [Display(Name = "Numero do Usuário")]

        public string NumeroId { get; set; } = string.Empty;
    }
}