
namespace BlazingShop.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)   
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       Title = "Cerveza Heineken",
                       Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                       Imagen = "https://grupoleiros.com/image/catalog/leiros/GUBE0556-MLBE0062.png",
                       price = 10,

                   },
                    new Product
                    {
                        Id = 2,
                        Title = "Cerveza Andes",
                        Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                        Imagen = "https://statics.dinoonline.com.ar/imagenes/full_600x600_ma/3100751_f.jpg",
                        price = 10,
                    },
                    new Product
                    {
                        Id = 3,
                        Title = "Cerveza Stella",
                        Description = "La cerveza ​ es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada germinados u otros cereales cuyo almidón se fermenta en agua con levadura y se aromatiza a menudo con lúpulo, entre otras plantas.",
                        Imagen = "https://jumboargentina.vtexassets.com/arquivos/ids/588380-800-auto?v=637280467148530000&width=800&height=auto&aspect=true",
                        price = 9,
                    }

                );
        }
        public DbSet<Product> Products { get; set; }    
    }
}
