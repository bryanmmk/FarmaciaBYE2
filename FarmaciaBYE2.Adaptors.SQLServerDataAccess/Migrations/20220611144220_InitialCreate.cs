using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FarmaciaBYE2.Adaptors.SQLServerDataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_Carrito",
                columns: table => new
                {
                    ID_Carrito = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Carrito", x => x.ID_Carrito);
                });

            migrationBuilder.CreateTable(
                name: "tb_Proveedor",
                columns: table => new
                {
                    ID_Proveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Codigo_Proveedor = table.Column<int>(type: "int", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Proveedor", x => x.ID_Proveedor);
                });

            migrationBuilder.CreateTable(
                name: "tb_Usuario",
                columns: table => new
                {
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Usuario", x => x.ID_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "tb_MedicamentoCarrito",
                columns: table => new
                {
                    ID_Carrito = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicamentoID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_MedicamentoCarrito", x => new { x.ID_Carrito, x.ID_Medicamento });
                    table.ForeignKey(
                        name: "FK_tb_MedicamentoCarrito_tb_Carrito_ID_Medicamento",
                        column: x => x.ID_Medicamento,
                        principalTable: "tb_Carrito",
                        principalColumn: "ID_Carrito",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Medicamentos",
                columns: table => new
                {
                    ID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Medicamentos_C = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Descuento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FarmaciaID_Farmacia = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ID_Pedido = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Medicamentos", x => x.ID_Medicamento);
                });

            migrationBuilder.CreateTable(
                name: "tb_Farmacia",
                columns: table => new
                {
                    ID_Farmacia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad_empleados = table.Column<int>(type: "int", nullable: false),
                    ID_Medicamento_C = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MedicamentosID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Pedido = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Farmacia", x => x.ID_Farmacia);
                    table.ForeignKey(
                        name: "FK_tb_Farmacia_tb_Medicamentos_MedicamentosID_Medicamento",
                        column: x => x.MedicamentosID_Medicamento,
                        principalTable: "tb_Medicamentos",
                        principalColumn: "ID_Medicamento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_FarmaciaProveedor",
                columns: table => new
                {
                    ID_Farmacia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Proveedor = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_FarmaciaProveedor", x => new { x.ID_Proveedor, x.ID_Farmacia });
                    table.ForeignKey(
                        name: "FK_tb_FarmaciaProveedor_tb_Farmacia_ID_Farmacia",
                        column: x => x.ID_Farmacia,
                        principalTable: "tb_Farmacia",
                        principalColumn: "ID_Farmacia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_FarmaciaProveedor_tb_Proveedor_ID_Proveedor",
                        column: x => x.ID_Proveedor,
                        principalTable: "tb_Proveedor",
                        principalColumn: "ID_Proveedor",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_Pedido",
                columns: table => new
                {
                    ID_Pedido = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Farmacia = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ID_Descuento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MedicamentosID_Medicamento = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Pedido", x => x.ID_Pedido);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Farmacia_ID_Pedido",
                        column: x => x.ID_Pedido,
                        principalTable: "tb_Farmacia",
                        principalColumn: "ID_Farmacia",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Medicamentos_MedicamentosID_Medicamento",
                        column: x => x.MedicamentosID_Medicamento,
                        principalTable: "tb_Medicamentos",
                        principalColumn: "ID_Medicamento",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_Pedido_tb_Usuario_UsuarioID_Usuario",
                        column: x => x.UsuarioID_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_Descuentos",
                columns: table => new
                {
                    ID_Descuento = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre_Medicamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Funcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ID_Pedido = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FarmaciaID_Farmacia = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_Descuentos", x => x.ID_Descuento);
                    table.ForeignKey(
                        name: "FK_tb_Descuentos_tb_Farmacia_FarmaciaID_Farmacia",
                        column: x => x.FarmaciaID_Farmacia,
                        principalTable: "tb_Farmacia",
                        principalColumn: "ID_Farmacia",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_Descuentos_tb_Pedido_ID_Descuento",
                        column: x => x.ID_Descuento,
                        principalTable: "tb_Pedido",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_UsuarioPedido",
                columns: table => new
                {
                    ID_Pedido = table.Column<int>(type: "int", nullable: false),
                    ID_Usuario = table.Column<int>(type: "int", nullable: false),
                    ID_UP = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuariosID_Usuario = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PedidosID_Pedido = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_UsuarioPedido", x => new { x.ID_Usuario, x.ID_Pedido });
                    table.ForeignKey(
                        name: "FK_tb_UsuarioPedido_tb_Pedido_PedidosID_Pedido",
                        column: x => x.PedidosID_Pedido,
                        principalTable: "tb_Pedido",
                        principalColumn: "ID_Pedido",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_tb_UsuarioPedido_tb_Usuario_UsuariosID_Usuario",
                        column: x => x.UsuariosID_Usuario,
                        principalTable: "tb_Usuario",
                        principalColumn: "ID_Usuario",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_Descuentos_FarmaciaID_Farmacia",
                table: "tb_Descuentos",
                column: "FarmaciaID_Farmacia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Farmacia_MedicamentosID_Medicamento",
                table: "tb_Farmacia",
                column: "MedicamentosID_Medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_FarmaciaProveedor_ID_Farmacia",
                table: "tb_FarmaciaProveedor",
                column: "ID_Farmacia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_MedicamentoCarrito_ID_Medicamento",
                table: "tb_MedicamentoCarrito",
                column: "ID_Medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_MedicamentoCarrito_MedicamentoID_Medicamento",
                table: "tb_MedicamentoCarrito",
                column: "MedicamentoID_Medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Medicamentos_FarmaciaID_Farmacia",
                table: "tb_Medicamentos",
                column: "FarmaciaID_Farmacia");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Medicamentos_ID_Descuento",
                table: "tb_Medicamentos",
                column: "ID_Descuento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_MedicamentosID_Medicamento",
                table: "tb_Pedido",
                column: "MedicamentosID_Medicamento");

            migrationBuilder.CreateIndex(
                name: "IX_tb_Pedido_UsuarioID_Usuario",
                table: "tb_Pedido",
                column: "UsuarioID_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_tb_UsuarioPedido_PedidosID_Pedido",
                table: "tb_UsuarioPedido",
                column: "PedidosID_Pedido");

            migrationBuilder.CreateIndex(
                name: "IX_tb_UsuarioPedido_UsuariosID_Usuario",
                table: "tb_UsuarioPedido",
                column: "UsuariosID_Usuario");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_MedicamentoCarrito_tb_Medicamentos_MedicamentoID_Medicamento",
                table: "tb_MedicamentoCarrito",
                column: "MedicamentoID_Medicamento",
                principalTable: "tb_Medicamentos",
                principalColumn: "ID_Medicamento",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Medicamentos_tb_Descuentos_ID_Descuento",
                table: "tb_Medicamentos",
                column: "ID_Descuento",
                principalTable: "tb_Descuentos",
                principalColumn: "ID_Descuento",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_Medicamentos_tb_Farmacia_FarmaciaID_Farmacia",
                table: "tb_Medicamentos",
                column: "FarmaciaID_Farmacia",
                principalTable: "tb_Farmacia",
                principalColumn: "ID_Farmacia",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_Descuentos_tb_Farmacia_FarmaciaID_Farmacia",
                table: "tb_Descuentos");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Medicamentos_tb_Farmacia_FarmaciaID_Farmacia",
                table: "tb_Medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Pedido_tb_Farmacia_ID_Pedido",
                table: "tb_Pedido");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_Descuentos_tb_Pedido_ID_Descuento",
                table: "tb_Descuentos");

            migrationBuilder.DropTable(
                name: "tb_FarmaciaProveedor");

            migrationBuilder.DropTable(
                name: "tb_MedicamentoCarrito");

            migrationBuilder.DropTable(
                name: "tb_UsuarioPedido");

            migrationBuilder.DropTable(
                name: "tb_Proveedor");

            migrationBuilder.DropTable(
                name: "tb_Carrito");

            migrationBuilder.DropTable(
                name: "tb_Farmacia");

            migrationBuilder.DropTable(
                name: "tb_Pedido");

            migrationBuilder.DropTable(
                name: "tb_Medicamentos");

            migrationBuilder.DropTable(
                name: "tb_Usuario");

            migrationBuilder.DropTable(
                name: "tb_Descuentos");
        }
    }
}
