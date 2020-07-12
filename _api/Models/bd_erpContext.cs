using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace _api.Models
{
    public partial class bd_erpContext : DbContext
    {
        public bd_erpContext()
        {
        }

        public bd_erpContext(DbContextOptions<bd_erpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbAvaliacao> TbAvaliacao { get; set; }
        public virtual DbSet<TbBalancoPatrimonial> TbBalancoPatrimonial { get; set; }
        public virtual DbSet<TbCliente> TbCliente { get; set; }
        public virtual DbSet<TbControleDeHorario> TbControleDeHorario { get; set; }
        public virtual DbSet<TbEscalaDeTrabalho> TbEscalaDeTrabalho { get; set; }
        public virtual DbSet<TbEstoque> TbEstoque { get; set; }
        public virtual DbSet<TbFolhaDePagamento> TbFolhaDePagamento { get; set; }
        public virtual DbSet<TbFornecedor> TbFornecedor { get; set; }
        public virtual DbSet<TbFuncionario> TbFuncionario { get; set; }
        public virtual DbSet<TbProduto> TbProduto { get; set; }
        public virtual DbSet<TbValorReceber> TbValorReceber { get; set; }
        public virtual DbSet<TbVenda> TbVenda { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;user id=root;password=45923617xx;database=bd_erp", x => x.ServerVersion("8.0.20-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbAvaliacao>(entity =>
            {
                entity.HasKey(e => e.IdAvaliacao)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdVenda)
                    .HasName("id_venda");

                entity.Property(e => e.DsAvaliacao)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdVendaNavigation)
                    .WithMany(p => p.TbAvaliacao)
                    .HasForeignKey(d => d.IdVenda)
                    .HasConstraintName("tb_avaliacao_ibfk_1");
            });

            modelBuilder.Entity<TbBalancoPatrimonial>(entity =>
            {
                entity.HasKey(e => e.IdBalancoPatrimonial)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdEstoque)
                    .HasName("id_estoque");

                entity.HasIndex(e => e.IdValorReceber)
                    .HasName("id_valor_receber");

                entity.HasOne(d => d.IdEstoqueNavigation)
                    .WithMany(p => p.TbBalancoPatrimonial)
                    .HasForeignKey(d => d.IdEstoque)
                    .HasConstraintName("tb_balanco_patrimonial_ibfk_1");

                entity.HasOne(d => d.IdValorReceberNavigation)
                    .WithMany(p => p.TbBalancoPatrimonial)
                    .HasForeignKey(d => d.IdValorReceber)
                    .HasConstraintName("tb_balanco_patrimonial_ibfk_2");
            });

            modelBuilder.Entity<TbCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsComplemento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsTel)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmNome)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbControleDeHorario>(entity =>
            {
                entity.HasKey(e => e.IdControleDeHorario)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.Property(e => e.DsCargaHoraria)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbControleDeHorario)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("tb_controle_de_horario_ibfk_1");
            });

            modelBuilder.Entity<TbEscalaDeTrabalho>(entity =>
            {
                entity.HasKey(e => e.IdEscalaDeTrabalho)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbEscalaDeTrabalho)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("tb_escala_de_trabalho_ibfk_1");
            });

            modelBuilder.Entity<TbEstoque>(entity =>
            {
                entity.HasKey(e => e.IdEstoque)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdProduto)
                    .HasName("id_produto");

                entity.HasIndex(e => e.IdVenda)
                    .HasName("id_venda");

                entity.HasOne(d => d.IdProdutoNavigation)
                    .WithMany(p => p.TbEstoque)
                    .HasForeignKey(d => d.IdProduto)
                    .HasConstraintName("tb_estoque_ibfk_2");

                entity.HasOne(d => d.IdVendaNavigation)
                    .WithMany(p => p.TbEstoque)
                    .HasForeignKey(d => d.IdVenda)
                    .HasConstraintName("tb_estoque_ibfk_1");
            });

            modelBuilder.Entity<TbFolhaDePagamento>(entity =>
            {
                entity.HasKey(e => e.IdFolhaDePagamento)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdControleDeHorario)
                    .HasName("id_controle_de_horario");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.HasOne(d => d.IdControleDeHorarioNavigation)
                    .WithMany(p => p.TbFolhaDePagamento)
                    .HasForeignKey(d => d.IdControleDeHorario)
                    .HasConstraintName("tb_folha_de_pagamento_ibfk_2");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbFolhaDePagamento)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("tb_folha_de_pagamento_ibfk_1");
            });

            modelBuilder.Entity<TbFornecedor>(entity =>
            {
                entity.HasKey(e => e.IdFornecedor)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCnpj)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsComplemento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmEmpresa)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbFuncionario>(entity =>
            {
                entity.HasKey(e => e.IdFuncionario)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsCargo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCep)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsComplemento)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsCpf)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEmail)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsEndereco)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsRg)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsSenha)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsTelefone)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmFuncionario)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmUsuario)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbProduto>(entity =>
            {
                entity.HasKey(e => e.IdProduto)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdFornecedor)
                    .HasName("id_fornecedor");

                entity.HasIndex(e => e.IdVenda)
                    .HasName("id_venda");

                entity.Property(e => e.DsFoto)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsNotaFiscal)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.DsProduto)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.NmProduto)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.TpProduto)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.IdFornecedorNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdFornecedor)
                    .HasConstraintName("tb_produto_ibfk_1");

                entity.HasOne(d => d.IdVendaNavigation)
                    .WithMany(p => p.TbProduto)
                    .HasForeignKey(d => d.IdVenda)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("tb_produto_ibfk_2");
            });

            modelBuilder.Entity<TbValorReceber>(entity =>
            {
                entity.HasKey(e => e.IdValorReceber)
                    .HasName("PRIMARY");

                entity.Property(e => e.DsMotivo)
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<TbVenda>(entity =>
            {
                entity.HasKey(e => e.IdVenda)
                    .HasName("PRIMARY");

                entity.HasIndex(e => e.IdCliente)
                    .HasName("id_cliente");

                entity.HasIndex(e => e.IdFuncionario)
                    .HasName("id_funcionario");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TbVenda)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("tb_venda_ibfk_1");

                entity.HasOne(d => d.IdFuncionarioNavigation)
                    .WithMany(p => p.TbVenda)
                    .HasForeignKey(d => d.IdFuncionario)
                    .HasConstraintName("tb_venda_ibfk_2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
