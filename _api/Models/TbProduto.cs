using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_produto")]
    public partial class TbProduto
    {
        public TbProduto()
        {
            TbEstoque = new HashSet<TbEstoque>();
        }

        [Key]
        [Column("id_produto")]
        public int IdProduto { get; set; }
        [Column("id_fornecedor")]
        public int IdFornecedor { get; set; }
        [Column("id_venda")]
        public int? IdVenda { get; set; }
        [Required]
        [Column("nm_produto", TypeName = "varchar(100)")]
        public string NmProduto { get; set; }
        [Required]
        [Column("tp_produto", TypeName = "varchar(80)")]
        public string TpProduto { get; set; }
        [Required]
        [Column("ds_produto", TypeName = "varchar(150)")]
        public string DsProduto { get; set; }
        [Column("vl_compra", TypeName = "decimal(10,2)")]
        public decimal VlCompra { get; set; }
        [Column("vl_venda", TypeName = "decimal(10,2)")]
        public decimal? VlVenda { get; set; }
        [Column("ds_foto", TypeName = "varchar(150)")]
        public string DsFoto { get; set; }
        [Column("dt_fabricacao", TypeName = "date")]
        public DateTime DtFabricacao { get; set; }
        [Column("dt_validade", TypeName = "date")]
        public DateTime? DtValidade { get; set; }
        [Required]
        [Column("ds_nota_fiscal", TypeName = "varchar(150)")]
        public string DsNotaFiscal { get; set; }
        [Column("dt_compra", TypeName = "datetime")]
        public DateTime DtCompra { get; set; }
        [Column("bt_ativo")]
        public sbyte BtAtivo { get; set; }
        [Column("bt_circulante")]
        public sbyte BtCirculante { get; set; }

        [ForeignKey(nameof(IdFornecedor))]
        [InverseProperty(nameof(TbFornecedor.TbProduto))]
        public virtual TbFornecedor IdFornecedorNavigation { get; set; }
        [ForeignKey(nameof(IdVenda))]
        [InverseProperty(nameof(TbVenda.TbProduto))]
        public virtual TbVenda IdVendaNavigation { get; set; }
        [InverseProperty("IdProdutoNavigation")]
        public virtual ICollection<TbEstoque> TbEstoque { get; set; }
    }
}
