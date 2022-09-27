using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazingShop.Server.Migrations
{
    public partial class ProductSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Imagen", "Title", "price" },
                values: new object[] { 1, "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.", "https://grupoleiros.com/image/catalog/leiros/GUBE0556-MLBE0062.png", "Cerveza Heineken", 10m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Imagen", "Title", "price" },
                values: new object[] { 2, "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.", "https://statics.dinoonline.com.ar/imagenes/full_600x600_ma/3100751_f.jpg", "Cerveza Andes", 10m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Imagen", "Title", "price" },
                values: new object[] { 3, "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.", "https://jumboargentina.vtexassets.com/arquivos/ids/588380-800-auto?v=637280467148530000&width=800&height=auto&aspect=true", "Cerveza Stella", 9m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
