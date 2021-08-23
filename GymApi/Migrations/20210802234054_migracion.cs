using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GymApi.Migrations
{
    public partial class migracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mensajes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Mensaje = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fecha = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mensajes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rutinas",
                columns: table => new
                {
                    IdRutina = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreRutina = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rutinas", x => x.IdRutina);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FotosRutinas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Foto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RutinaIdRutina = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FotosRutinas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FotosRutinas_Rutinas_RutinaIdRutina",
                        column: x => x.RutinaIdRutina,
                        principalTable: "Rutinas",
                        principalColumn: "IdRutina",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MensajesUsuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdMensaje = table.Column<int>(type: "int", nullable: false),
                    UsuarioId = table.Column<int>(type: "int", nullable: true),
                    MensajeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MensajesUsuarios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MensajesUsuarios_Mensajes_MensajeId",
                        column: x => x.MensajeId,
                        principalTable: "Mensajes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MensajesUsuarios_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRol = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    usuariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRol);
                    table.ForeignKey(
                        name: "FK_Roles_Usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RutinasUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    IdRutina = table.Column<int>(type: "int", nullable: false),
                    Agregado = table.Column<bool>(type: "bit", nullable: false),
                    RutinaIdRutina = table.Column<int>(type: "int", nullable: true),
                    UsuarioId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutinasUsuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RutinasUsuario_Rutinas_RutinaIdRutina",
                        column: x => x.RutinaIdRutina,
                        principalTable: "Rutinas",
                        principalColumn: "IdRutina",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RutinasUsuario_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RutinasUsuarios",
                columns: table => new
                {
                    RutinasIdRutina = table.Column<int>(type: "int", nullable: false),
                    UsuariosId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutinasUsuarios", x => new { x.RutinasIdRutina, x.UsuariosId });
                    table.ForeignKey(
                        name: "FK_RutinasUsuarios_Rutinas_RutinasIdRutina",
                        column: x => x.RutinasIdRutina,
                        principalTable: "Rutinas",
                        principalColumn: "IdRutina",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RutinasUsuarios_Usuarios_UsuariosId",
                        column: x => x.UsuariosId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FotosRutinas_RutinaIdRutina",
                table: "FotosRutinas",
                column: "RutinaIdRutina");

            migrationBuilder.CreateIndex(
                name: "IX_MensajesUsuarios_MensajeId",
                table: "MensajesUsuarios",
                column: "MensajeId");

            migrationBuilder.CreateIndex(
                name: "IX_MensajesUsuarios_UsuarioId",
                table: "MensajesUsuarios",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_usuariosId",
                table: "Roles",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_RutinasUsuario_RutinaIdRutina",
                table: "RutinasUsuario",
                column: "RutinaIdRutina");

            migrationBuilder.CreateIndex(
                name: "IX_RutinasUsuario_UsuarioId",
                table: "RutinasUsuario",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_RutinasUsuarios_UsuariosId",
                table: "RutinasUsuarios",
                column: "UsuariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FotosRutinas");

            migrationBuilder.DropTable(
                name: "MensajesUsuarios");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "RutinasUsuario");

            migrationBuilder.DropTable(
                name: "RutinasUsuarios");

            migrationBuilder.DropTable(
                name: "Mensajes");

            migrationBuilder.DropTable(
                name: "Rutinas");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
