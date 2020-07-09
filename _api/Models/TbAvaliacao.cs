using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_avaliacao")]
    public partial class TbAvaliacao
    {
        [Key]
        [Column("id_avaliacao")]
        public int IdAvaliacao { get; set; }
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("vl_produto", TypeName = "decimal(2,2)")]
        public decimal VlProduto { get; set; }
        [Column("vl_funcionario", TypeName = "decimal(2,2)")]
        public decimal VlFuncionario { get; set; }
        [Column("vl_estabelecimento", TypeName = "decimal(2,2)")]
        public decimal VlEstabelecimento { get; set; }
        [Column("ds_avaliacao", TypeName = "varchar(150)")]
        public string DsAvaliacao { get; set; }

        [ForeignKey(nameof(IdVenda))]
        [InverseProperty(nameof(TbVenda.TbAvaliacao))]
        public virtual TbVenda IdVendaNavigation { get; set; }
    }
}
