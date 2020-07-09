using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_controle_de_horario")]
    public partial class TbControleDeHorario
    {
        public TbControleDeHorario()
        {
            TbFolhaDePagamento = new HashSet<TbFolhaDePagamento>();
        }

        [Key]
        [Column("id_controle_de_horario")]
        public int IdControleDeHorario { get; set; }
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("hr_entrada", TypeName = "time")]
        public TimeSpan HrEntrada { get; set; }
        [Column("hr_saida", TypeName = "time")]
        public TimeSpan HrSaida { get; set; }
        [Required]
        [Column("ds_carga_horaria", TypeName = "varchar(8)")]
        public string DsCargaHoraria { get; set; }
        [Column("hr_entrada_almoco", TypeName = "time")]
        public TimeSpan HrEntradaAlmoco { get; set; }
        [Column("hr_saida_almoco", TypeName = "time")]
        public TimeSpan HrSaidaAlmoco { get; set; }
        [Column("dt_atualizacao", TypeName = "date")]
        public DateTime DtAtualizacao { get; set; }

        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbControleDeHorario))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        [InverseProperty("IdControleDeHorarioNavigation")]
        public virtual ICollection<TbFolhaDePagamento> TbFolhaDePagamento { get; set; }
    }
}
