﻿// <auto-generated />
using System;
using Commerce.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Commerce.Migrations
{
    [DbContext(typeof(CommerceContext))]
    partial class CommerceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Commerce.Data.Entities.Categoria", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Categorias", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(11)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<long>("Numero")
                        .HasColumnType("bigint");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Enderecos", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Entrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("PrazoDias")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorFrete")
                        .HasColumnType("DECIMAL(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.HasIndex("PedidoId")
                        .IsUnique();

                    b.ToTable("Entregas", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Marca", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Marcas", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Pedido", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataPedido")
                        .HasColumnType("DateTime");

                    b.Property<int>("ModoPagamento")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("DECIMAL(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.PedidoProduto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("PedidoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ProdutoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("PedidosProdutos", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Avaliacao")
                        .HasColumnType("int");

                    b.Property<Guid?>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid?>("MarcaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("DECIMAL(11,2)");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.HasIndex("MarcaId");

                    b.ToTable("Produtos", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(14)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("varchar(9)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Cpf")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("Rg")
                        .IsUnique();

                    b.ToTable("Usuarios", (string)null);
                });

            modelBuilder.Entity("Commerce.Data.Entities.Endereco", b =>
                {
                    b.HasOne("Commerce.Data.Entities.Usuario", "Usuario")
                        .WithOne("Endereco")
                        .HasForeignKey("Commerce.Data.Entities.Endereco", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Entrega", b =>
                {
                    b.HasOne("Commerce.Data.Entities.Endereco", "Endereco")
                        .WithMany("Entregas")
                        .HasForeignKey("EnderecoId");

                    b.HasOne("Commerce.Data.Entities.Pedido", "Pedido")
                        .WithOne("Entrega")
                        .HasForeignKey("Commerce.Data.Entities.Entrega", "PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Pedido", b =>
                {
                    b.HasOne("Commerce.Data.Entities.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Commerce.Data.Entities.PedidoProduto", b =>
                {
                    b.HasOne("Commerce.Data.Entities.Pedido", "Pedido")
                        .WithMany("PedidosItens")
                        .HasForeignKey("PedidoId");

                    b.HasOne("Commerce.Data.Entities.Produto", "Produto")
                        .WithMany("PedidosItens")
                        .HasForeignKey("ProdutoId");

                    b.Navigation("Pedido");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Produto", b =>
                {
                    b.HasOne("Commerce.Data.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId");

                    b.HasOne("Commerce.Data.Entities.Marca", "Marca")
                        .WithMany("Produtos")
                        .HasForeignKey("MarcaId");

                    b.Navigation("Categoria");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Endereco", b =>
                {
                    b.Navigation("Entregas");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Marca", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Pedido", b =>
                {
                    b.Navigation("Entrega");

                    b.Navigation("PedidosItens");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Produto", b =>
                {
                    b.Navigation("PedidosItens");
                });

            modelBuilder.Entity("Commerce.Data.Entities.Usuario", b =>
                {
                    b.Navigation("Endereco");

                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
