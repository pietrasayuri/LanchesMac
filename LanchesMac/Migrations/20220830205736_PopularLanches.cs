﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LanchesMac.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
                "VALUES(1, 'Pão, hambúrger, ovo, presunto, queijo e batata palha', 'Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha',1, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg','https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 'Cheese Salada', 12.50)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
               "VALUES(1, 'Pão, presunto, mussarela e tomate', 'Delicioso pão francês quentinho e mussarela bem servidos com tomate preparado com carinho.',1, 'https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg','https://www.macoratti.net/Imagens/lanches/mistoquente4.jpg', 0, 'Misto Quente', 8.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
               "VALUES(1, 'Pão, hambúrger, presunto,  mussarela e batata palha', 'Pão de hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha',1, 'https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg','https://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg', 0, 'Cheese Burger', 11.00)");
            migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco) " +
               "VALUES(1, 'Pão Integral, queijo branco, peito de peru,cenoura, alface, iogurte', 'Pão Natural com queijo branco, peito de peru e cenoura ralada com alface picado e iogurte natural.',1, 'https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg','https://www.macoratti.net/Imagens/lanches/lanchenatural.jpg', 1, 'Lanche Natural Peito Peru', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches"); 
        }
    }
}