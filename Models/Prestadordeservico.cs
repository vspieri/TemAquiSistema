using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tem_Aqui.Models
{
    [Table("Prestador")]
    public class Prestadordeservico
    {
        [Column("IdPrestador")]
        [Display(Name = "Código de Produto")]
        public int Id { get; set; }

        [Column("NomePrestador")]
        [Display(Name = "Código do Nome Prestador")]
        public string NomePrestador { get; set; } = string.Empty;


        [Column("TipoServico")]
        [Display(Name = "Código Tipo de Serviço")]
        public string TipoServico { get; set; } = string.Empty;

        [Column("Descricao")]
        [Display(Name = "Código da Descrição")]
        public string Descricao { get; set; } = string.Empty;

        [Column("Endereco")]
        [Display(Name = "Código do Endereço")]
        public string Endereco { get; set; } = string.Empty;

        [Column("Numero")]
        [Display(Name = "Código do Numero")]
        public int Numero { get; set; }

        [Column("Email")]
        [Display(Name = "Código do Email")]
        public string Email { get; set; } = string.Empty;
    }
}
