﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LojaVirtual.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                                  "VALUES('Normal', 'Lanche feito com ingredientes normais')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descricao) " +
                                  "VALUES('Naturais', 'Lanche feito com ingredientes integrais e naturais')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
