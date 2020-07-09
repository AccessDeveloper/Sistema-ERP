using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_balanco_patrimonial")]
    public partial class TbBalancoPatrimonial
    {
        [Key]
        [Column("id_balanco_patrimonial")]
        public int IdBalancoPatrimonial { get; set; }
        [Column("id_estoque")]
        public int IdEstoque { get; set; }
        [Column("id_valor_receber")]
        public int IdValorReceber { get; set; }
        [Column("nr_ano")]
        public int NrAno { get; set; }

        [ForeignKey(nameof(IdEstoque))]
        [InverseProperty(nameof(TbEstoque.TbBalancoPatrimonial))]
        public virtual TbEstoque IdEstoqueNavigation { get; set; }
        [ForeignKey(nameof(IdValorReceber))]
        [InverseProperty(nameof(TbValorReceber.TbBalancoPatrimonial))]
        public virtual TbValorReceber IdValorReceberNavigation { get; set; }
    }
}
