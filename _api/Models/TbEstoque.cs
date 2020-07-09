using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_estoque")]
    public partial class TbEstoque
    {
        public TbEstoque()
        {
            TbBalancoPatrimonial = new HashSet<TbBalancoPatrimonial>();
        }

        [Key]
        [Column("id_estoque")]
        public int IdEstoque { get; set; }
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("qtd_produto")]
        public int QtdProduto { get; set; }
        [Column("dt_atualizacao", TypeName = "datetime")]
        public DateTime DtAtualizacao { get; set; }

        [ForeignKey(nameof(IdProduto))]
        [InverseProperty(nameof(TbProduto.TbEstoque))]
        public virtual TbProduto IdProdutoNavigation { get; set; }
        [ForeignKey(nameof(IdVenda))]
        [InverseProperty(nameof(TbVenda.TbEstoque))]
        public virtual TbVenda IdVendaNavigation { get; set; }
        [InverseProperty("IdEstoqueNavigation")]
        public virtual ICollection<TbBalancoPatrimonial> TbBalancoPatrimonial { get; set; }
    }
}
