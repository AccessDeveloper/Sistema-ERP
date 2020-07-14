using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_funcionario")]
    public partial class TbFuncionario
    {
        public TbFuncionario()
        {
            TbControleDeHorario = new HashSet<TbControleDeHorario>();
            TbEscalaDeTrabalho = new HashSet<TbEscalaDeTrabalho>();
            TbFolhaDePagamento = new HashSet<TbFolhaDePagamento>();
            TbVenda = new HashSet<TbVenda>();
        }

        [Key]
        [Column("id_funcionario")]
        public int IdFuncionario { get; set; }
        [Required]
        [Column("ds_codigo", TypeName = "varchar(10)")]
        public string DsCodigo { get; set; }
        [Required]
        [Column("nm_funcionario", TypeName = "varchar(100)")]
        public string NmFuncionario { get; set; }
        [Required]
        [Column("ds_rg", TypeName = "varchar(20)")]
        public string DsRg { get; set; }
        [Required]
        [Column("ds_cpf", TypeName = "varchar(20)")]
        public string DsCpf { get; set; }
        [Column("dt_nascimento", TypeName = "date")]
        public DateTime DtNascimento { get; set; }
        [Required]
        [Column("tp_sexo", TypeName = "varchar(45)")]
        public string TpSexo { get; set; }
        [Required]
        [Column("ds_endereco", TypeName = "varchar(100)")]
        public string DsEndereco { get; set; }
        [Column("ds_complemento", TypeName = "varchar(25)")]
        public string DsComplemento { get; set; }
        [Required]
        [Column("ds_cep", TypeName = "varchar(8)")]
        public string DsCep { get; set; }
        [Required]
        [Column("ds_email", TypeName = "varchar(30)")]
        public string DsEmail { get; set; }
        [Required]
        [Column("ds_telefone", TypeName = "varchar(20)")]
        public string DsTelefone { get; set; }
        [Required]
        [Column("ds_cargo", TypeName = "varchar(25)")]
        public string DsCargo { get; set; }
        [Column("ds_curriculo", TypeName = "varchar(150)")]
        public string DsCurriculo { get; set; }
        [Column("ds_foto", TypeName = "varchar(150)")]
        public string DsFoto { get; set; }
        [Required]
        [Column("nm_usuario", TypeName = "varchar(50)")]
        public string NmUsuario { get; set; }
        [Required]
        [Column("ds_senha", TypeName = "varchar(15)")]
        public string DsSenha { get; set; }

        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbControleDeHorario> TbControleDeHorario { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbEscalaDeTrabalho> TbEscalaDeTrabalho { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbFolhaDePagamento> TbFolhaDePagamento { get; set; }
        [InverseProperty("IdFuncionarioNavigation")]
        public virtual ICollection<TbVenda> TbVenda { get; set; }
    }
}
