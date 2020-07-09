using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_venda")]
    public partial class TbVenda
    {
        public TbVenda()
        {
            TbAvaliacao = new HashSet<TbAvaliacao>();
            TbEstoque = new HashSet<TbEstoque>();
            TbProduto = new HashSet<TbProduto>();
        }

        [Key]
        [Column("id_venda")]
        public int IdVenda { get; set; }
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Column("dt_venda", TypeName = "date")]
        public DateTime DtVenda { get; set; }
        [Column("vl_preco_total", TypeName = "decimal(10,2)")]
        public decimal VlPrecoTotal { get; set; }

        [ForeignKey(nameof(IdCliente))]
        [InverseProperty(nameof(TbCliente.TbVenda))]
        public virtual TbCliente IdClienteNavigation { get; set; }
        [ForeignKey(nameof(IdFuncionario))]
        [InverseProperty(nameof(TbFuncionario.TbVenda))]
        public virtual TbFuncionario IdFuncionarioNavigation { get; set; }
        [InverseProperty("IdVendaNavigation")]
        public virtual ICollection<TbAvaliacao> TbAvaliacao { get; set; }
        [InverseProperty("IdVendaNavigation")]
        public virtual ICollection<TbEstoque> TbEstoque { get; set; }
        [InverseProperty("IdVendaNavigation")]
        public virtual ICollection<TbProduto> TbProduto { get; set; }
    }
}
