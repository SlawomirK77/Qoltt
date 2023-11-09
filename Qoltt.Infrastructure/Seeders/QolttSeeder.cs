using qoltt.Domain.Entities;
using qoltt.Infrastructure.Persistence;

namespace qoltt.Infrastructure.Seeders
{
    public class QolttSeeder
    {
        private readonly QolttDbContext _dbContext;

        public QolttSeeder(QolttDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Products.Any())
                {
                    var product = new Product()
                    {
                        Name = "Ałun",
                        Description = "Ałun w sztyfcie, bezzapachowy, bezbarwny, ogólnie średni",
                        Category = Category.Beauty,
                        Price = 11.99M,
                        Links = new List<ItemUri>
                        {
                            new ItemUri
                            {
                                Uri = new Uri("https://kosmetykinaturalne.com.pl/alun-naturalny-dezodorant-w-sztyfcie-115g.html"),
                            },
                            new ItemUri
                            {
                                Uri = new Uri("https://www.rossmann.pl/Produkt/Produkty-specjalistyczne/Arganove-dezodorant-w-sztyfcie-alun-bezzapachowy-55-g,323222,8647"),
                            },
                        },

                    };
                    _dbContext.Products.Add(product);
                    await _dbContext.SaveChangesAsync();
                }

                if (!_dbContext.Tips.Any())
                {
                    var tip = new Tip()
                    {
                        Name = "Herbata",
                        Description = "Herbata z miodem, imbirem i pomarańczą",
                        Category = Category.Beauty,
                        Links = new List<ItemUri>
                        {
                            new ItemUri
                            {
                                Uri = new Uri("https://miodowewzgorze.pl/blog/herbata-z-miodem/"),
                            },
                            new ItemUri
                            {
                                Uri = new Uri("https://www.coffeedesk.pl/blog/herbata-z-imbirem-i-innymi-dodatkami-kilka-prostych-przepisow/"),
                            },
                        },

                    };
                    _dbContext.Tips.Add(tip);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
