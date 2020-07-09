using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_folha_de_pagamento")]
    public partial class TbFolhaDePagamento
    {
        [Key]
        [Column("id_folha_de_pagamento")]
        public int IdFolhaDePagamento { get; set; }
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("id_controle_de_horario")]
        public int IdControleDeHorario { get; set; }
        [Column("dt_pagamento", TypeName = "datetime")]
        public DateTime DtPagamento { get; set; }
        [Column("vl_descontos", TypeName = "decimal(10,2)")]
        public decimal VlDescontos { get; set; }
        [Column("vl_salario_bruto", TypeName = "decimal(10,2)")]
        public decimal VlSalarioBruto { get; set; }

        [ForeignKey(nameof(IdControleDeHorario))]
        [InverseProperty(nameof(TbControleDeHorario.TbFolhaDePagamento))]
        public virtual TbControleDeHorario IdControleDeHorarioNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbFolhaDePagamento))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
    }
}
