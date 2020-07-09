using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _api.Models
{
    [Table("tb_valor_receber")]
    public partial class TbValorReceber
    {
        public TbValorReceber()
        {
            TbBalancoPatrimonial = new HashSet<TbBalancoPatrimonial>();
        }

        [Key]
        [Column("id_valor_receber")]
        public int IdValorReceber { get; set; }
        [Column("nm_pagador", TypeName = "decimal(10,2)")]
        public decimal NmPagador { get; set; }
        [Column("dt_pagamento", TypeName = "date")]
        public DateTime DtPagamento { get; set; }
        [Column("vl_receber", TypeName = "decimal(10,2)")]
        public decimal VlReceber { get; set; }
        [Column("ds_motivo", TypeName = "varchar(120)")]
        public string DsMotivo { get; set; }
        [Column("vl_juros_atraso")]
        public int VlJurosAtraso { get; set; }

        [InverseProperty("IdValorReceberNavigation")]
        public virtual ICollection<TbBalancoPatrimonial> TbBalancoPatrimonial { get; set; }
    }
}
