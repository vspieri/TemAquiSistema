using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Tem_Aqui.Models;

namespace TemAqui.Models
{
    [Table("SerPres")]
    public class SerPres
    {
        [Column("SerPresId")]
        [Display(Name = "Codigo do SerPres ")]

        public int Id { get; set; }


        [ForeignKey("IdPrestdor")]
        public int PrestadordeservicoId { get; set; }

        public Prestadordeservico? Prestadordeservico { get; set; }

        [Column("DataEHr")]
        [Display(Name = "Data e Hora do Serviço")]

        public DateTime DataEHR { get; set; }


        [Column("Preço")]
        [Display(Name = "Preço do Serviço")]

        public string Preco { get; set; } = string.Empty;
    }
}