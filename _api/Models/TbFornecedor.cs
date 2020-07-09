using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_fornecedor")]
    public partial class TbFornecedor
    {
        public TbFornecedor()
        {
            TbProduto = new HashSet<TbProduto>();
        }

        [Key]
        [Column("id_fornecedor")]
        public int IdFornecedor { get; set; }
        [Required]
        [Column("nm_empresa", TypeName = "varchar(50)")]
        public string NmEmpresa { get; set; }
        [Required]
        [Column("ds_cnpj", TypeName = "varchar(12)")]
        public string DsCnpj { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(30)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_cep", TypeName = "varchar(8)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(30)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(20)")]
        public string DsTelefone { get; set; }
        [Column("ds_complemento", TypeName = "varchar(45)")]
        public string DsComplemento { get; set; }

        [InverseProperty("IdFornecedorNavigation")]
        public virtual ICollection<TbProduto> TbProduto { get; set; }
    }
}
