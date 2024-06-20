using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tem_Aqui.Models
{
    [Table("Cadastro")]
    public class Cadastro
    {
        [Column("CadastroId")]
        [Display(Name = "Código do Cadastro")]

        public int Id { get; set; }

        [Column("CadastroNome")]
        [Display(Name = "Nome da Afilial")]

        public string CadastroNome { get; set; } = string.Empty;

        [Column("Cnpj")]
        [Display(Name = "Cnpj da Afilial")]

        public string Cnpj { get; set; } = string.Empty;

        [Column("Telefone")]
        [Display(Name = "Telefone da Afilial")]

        public int Telefone { get; set; }

        [Column("Localidade")]
        [Display(Name = "Localidade da Afilial")]

        public string Localidade { get; set; } = string.Empty;

        [Column("Descrição")]
        [Display(Name = "Descrição da Afilial")]

        public string Descrição { get; set; } = string.Empty;

        [Column("Foto")]
        [Display(Name = "Foto da Afilial")]

        public string Foto { get; set; } = string.Empty;
    }
}
