using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_escala_de_trabalho")]
    public partial class TbEscalaDeTrabalho
    {
        [Key]
        [Column("id_escala_de_trabalho")]
        public int IdEscalaDeTrabalho { get; set; }
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("bt_domingo")]
        public sbyte BtDomingo { get; set; }
        [Column("bt_segunda")]
        public sbyte BtSegunda { get; set; }
        [Column("bt_terca")]
        public sbyte BtTerca { get; set; }
        [Column("bt_quarta")]
        public sbyte BtQuarta { get; set; }
        [Column("bt_quinta")]
        public sbyte BtQuinta { get; set; }
        [Column("bt_sexta")]
        public sbyte BtSexta { get; set; }
        [Column("bt_sabado")]
        public sbyte BtSabado { get; set; }
        [Column("hr_entrada", TypeName = "time")]
        public TimeSpan HrEntrada { get; set; }
        [Column("hr_saida", TypeName = "time")]
        public TimeSpan HrSaida { get; set; }

        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbEscalaDeTrabalho))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
