using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiAgendamento.Migrations
{
    /// <inheritdoc />
    public partial class FilloutData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO \"Usuarios\" (\"Login\", \"Senha\", \"Tipo\", \"Email\") VALUES ('admin', 'admin', true, 'admin@admin.com')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM usuarios WHERE Login = 'admin'");
        }
    }
}
