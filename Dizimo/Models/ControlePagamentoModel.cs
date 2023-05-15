using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace Dizimo.Models
{
    public class ControlePagamentoModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int DizimistaId { get; set;}
        [Required]
        public int ComunidadeId { get; set;}

        [Required]
        public int UsuarioID { get; set;}

        [Required]
        //[DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime MesAno { get; set;}

        [DisplayName("Janeiro")]
        [DefaultValue(false)]
        public bool Janeiro { get; set; }

        [DisplayName("Fevereiro")]
        [DefaultValue(false)]
        public bool Fevereiro { get; set; }

        [DisplayName("Março")]
        [DefaultValue(false)]
        public bool Marco { get; set; }

        [DisplayName("Abril")]
        [DefaultValue(false)]
        public bool Abril { get; set; }

        [DisplayName("Maio")]
        [DefaultValue(false)]
        public bool Maio { get; set; }

        [DisplayName("Junho")]
        [DefaultValue(false)]
        public bool Junho { get; set; }

        [DisplayName("Julho")]
        [DefaultValue(false)]
        public bool Julho { get; set; }

        [DisplayName("Agosto")]
        [DefaultValue(false)]
        public bool Agosto { get; set; }

        [DisplayName("Setembro")]
        [DefaultValue(false)]
        public bool Setembro { get; set; }

        [DisplayName("Outubro")]
        [DefaultValue(false)]
        public bool Outubro { get; set; }

        [DisplayName("Novembro")]
        [DefaultValue(false)]
        public bool Novembro { get; set; }

        [DisplayName("Dezembro")]
        [DefaultValue(false)]
        public bool Dezembro { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Atualizacao { get; set; }


        public ComunidadeModel comunidadecp { get; set; }
        public DizimistaModel dizimistacp { get; set; }

        public List<ComunidadeModel> ListaPagamentoComunidades { get; set; }
        public List<DizimistaModel> ListaDizimistaComunidades { get; set; }



    }
}
