using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_cliente")]
    public partial class TbCliente
    {
        public TbCliente()
        {
            TbVenda = new HashSet<TbVenda>();
        }

        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Required]
        [Column("nm_nome", TypeName = "varchar(100)")]
        public string NmNome { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(20)")]
        public string DsCpf { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Required]
        [Column("ds_cep", TypeName = "varchar(12)")]
        public string DsCep { get; set; }
        [Column("ds_complemento", TypeName = "varchar(20)")]
        public string DsComplemento { get; set; }
        [Column("ds_email", TypeName = "varchar(100)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_tel", TypeName = "varchar(30)")]
        public string DsTel { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<TbVenda> TbVenda { get; set; }
    }
}
