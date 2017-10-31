using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinkWorld.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace DrinkWorld.Data
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context =
                applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Drinks.Any())
            {
                context.AddRange
                (
                   new Drink
                   {
                       Name = "Beer",
                       Price = 7.95M,
                       ShortDescription = "The most widely consumed alcohol",
                       LongDescription = "Beer is the oldest[1][2][3] and most widely consumed[4] alcoholic drink in the world," +
                                  " and the third most popular drink overall after water and tea.[5] Beer is brewed from cereal grains — most commonly from malted barley, though wheat, maize (corn), and rice are also used. During the brewing process, fermentation of the starch sugars in the wort produces ethanol and carbonation in the resulting beer.[6] Most modern beer is brewed with hops, which add bitterness and other flavours and act as a natural preservative and stabilizing agent. Other flavouring agents such as gruit, herbs, or fruits may be included or used instead of hops. In commercial brewing, the natural carbonation effect is often removed " +
                                  "during processing and replaced with forced carbonation",
                       Category = Categories["Alcoholic"],
                       ImageUrl = "https://www.desktopbackground.org/download/1280x720/2010/05/07/13745_boy-drinking-beer-wallpapers-picture-gallery_2560x1600_h.jpg",
                       InStock = true,
                       IsPrefferedDrink = true,
                       ImageThumbnailUrl = "http://wallpaper.pickywallpapers.com/ipad/preview/beer-with-a-barrel.jpg"
                   }, new Drink
                   {
                       Name = "Cola",
                       Price = 1.95M,
                       ShortDescription = "Cola is a sweetened, carbonated soft drink",
                       LongDescription = "Cola is a sweetened, carbonated soft drink, made from ingredients that contain caffeine from the kola nut and non-cocaine derivatives from coca leaves, flavored with vanilla and other ingredients. Most colas now use other flavoring (and caffeinating) ingredients with a similar taste. Colas became popular worldwide after pharmacist John Pemberton invented Coca-Cola in 1886.[1] His non-alcoholic recipe was inspired by the coca wine of pharmacist Angelo Mariani, created in 1863",
                       Category = Categories["Alcoholic"],
                       ImageUrl = "http://gwyl.io/wp-content/uploads/2016/08/Coca-Cola-Premium-Double-Insulated-Tumbler-f.jpg",
                       InStock = true,
                       IsPrefferedDrink = false,
                       ImageThumbnailUrl = "https://i.pinimg.com/736x/e3/d2/d6/e3d2d6972a4d8c053867067dec88f09c--my-addiction-diet-coke.jpg"
                   }, new Drink
                   {
                       Name = "Champagne",
                       Price = 55.75M,
                       ShortDescription = "Champagne is a type of sparkling wine and type of an alcoholic drink",
                       LongDescription = "Champagne (French: [ʃɑ̃.paɲ]) is a type of sparkling wine and type of an alcoholic drink produced from grapes grown in the Champagne region of France following rules that demand, among other things, secondary fermentation of the wine in the bottle to create carbonation, specific vineyard practices, sourcing of grapes exclusively from specific parcels in the Champagne appellation and specific pressing regimes unique to the region.[1] Some use the term Champagne as a generic term for sparkling wine,[2][3] but in many countries, it is illegal to label any product Champagne unless it both comes from the Champagne region and is produced under the rules of the appellation.[4]",
                       Category = Categories["Alcoholic"],
                       ImageUrl = "http://i.vimeocdn.com/video/543426009_1280x720.jpg",
                       InStock = true,
                       IsPrefferedDrink = false,
                       ImageThumbnailUrl = "https://www.favorsandflowers.com/images/D/Champagne-Glass-Etched-Bride-and-Groom-8-inches-D.jpg"
                   }, new Drink
                   {
                       Name = "Juice",
                       Price = 1.8M,
                       ShortDescription = "Naturally contained in fruit or vegetable tissue.",
                       LongDescription = "Juice is a beverage made from the extraction or pressing out of the natural liquid contained in fruit and vegetables. It can also refer to liquids that are flavored with these or other biological food sources such as meat and seafood (e.g., clam juice). Juice is commonly consumed as a beverage or used as an ingredient or flavoring in foods or other beverages, such as smoothies. Juice emerged as a popular beverage choice after the development of pasteurization methods allowed for its preservation without using fermentation (the approach used with wine production).[1] The Food and Agriculture Organization of the United Nations (FAO) estimated the total world production of citrus fruit juices to be 12,840,318 tonnes in 2012.[2] The largest fruit juice consumers are New Zealand (nearly a cup, or 8 ounces, each day) and Colombia (more than three quarters of a cup each day). Fruit juice consumption on average increased with country income level.[3] To the American food industry, fruit juice is more profitable than only fruit.[4]",
                       Category = Categories["Non-alcoholic"],
                       ImageUrl = "https://i.ytimg.com/vi/6IItTVwk2Es/maxresdefault.jpg",
                       InStock = true,
                       IsPrefferedDrink = true,
                       ImageThumbnailUrl = "http://www.africaprocessing.com/wp-content/uploads/2016/01/fresh-juice-manufacturing-1.jpg"
                   },
                    new Drink
                    {
                        Name = "Margarita",
                        Price = 17.95M,
                        ShortDescription = "A cocktail with sec, tequila and lime",
                        Category = Categories["Alcoholic"],
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        ImageUrl = "http://s2.dmcdn.net/Bl3fa/1280x720-YGB.jpg",
                        InStock = true,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "https://cdn.liquor.com/wp-content/uploads/2014/05/recipe-garden-margarita.jpg"
                    },
                    new Drink
                    {
                        Name = "Whiskey with Ice",
                        Price = 15.95M,
                        ShortDescription = "The best way to taste whiskey",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "http://s1.1zoom.me/b3855/313/Whisky_Closeup_Highball_glass_Ice_530040_1280x720.jpg",
                        InStock = false,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "https://cdn-0.motorsportnetwork.com/modernlook/products/0/0/9000/9100/9118/s1/spherical_ice_ball_maker_personalized_set_38734.jpg"
                    },
                    
                    new Drink
                    {
                        Name = "Long Island Iced Tea",
                        Price = 15.95M,
                        ShortDescription = "Aa mixed drink made with tequila.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/RzrY33Hf6tE/maxresdefault.jpg",
                        InStock = false,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "http://alcovegas.com.ua/uploads/2173/item/zoom/i215435-samye-populyarnye-koktejli-1.jpg"
                    },
                    new Drink
                    {
                        Name = "Vodka",
                        Price = 15.95M,
                        ShortDescription = "A distilled beverage with water and ethanol.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.kinja-img.com/gawker-media/image/upload/t_original/c65juoevywfkqxfokgmp.jpg",
                        InStock = false,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "https://www.noblelife.club/MK/wp-content/uploads/2016/05/07_l_1-500x500.jpg"
                    },
                    new Drink
                    {
                        Name = "Gin and tonic",
                        Price = 15.95M,
                        ShortDescription = "Made with gin and tonic water poured over ice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/adzcd_zKwvo/maxresdefault.jpg",
                        InStock = false,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "http://cdn1.bigcommerce.com/server4500/0544a/products/964/images/2113/gin_tonic__20029.1467228950.500.750.jpg?c=2"
                    },
                    new Drink
                    {
                        Name = "Cosmopolitan",
                        Price = 15.95M,
                        ShortDescription = "Made with vodka, triple sec, cranberry juice.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/aeKSNbniAYg/maxresdefault.jpg",
                        InStock = false,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "https://cdn.liquor.com/wp-content/uploads/2011/11/dubonnet-cosmopolitain2.jpg"
                    },
                    new Drink
                    {
                        Name = "Tea ",
                        Price = 12.95M,
                        ShortDescription = "Made by leaves of the tea plant in hot water.",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/DQac5-GBBfw/maxresdefault.jpg",
                        InStock = true,
                        IsPrefferedDrink = true,
                        ImageThumbnailUrl = "http://www.balikopiluwak.net/wp-content/uploads/2013/06/Lemon-tea-with-cinamon-and-.jpg"
                    },
                    new Drink
                    {
                        Name = "Water ",
                        Price = 12.95M,
                        ShortDescription = " It makes up more than half of your body weight ",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://albertonrecord.co.za/wp-content/uploads/sites/35/2017/03/glass-of-water.jpg",
                        InStock = true,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "https://i.pinimg.com/736x/17/23/4e/17234eaafe63f940b28c51a3e4c0f645--healthy-eating-habits-keeping-healthy.jpg"
                    },
                    new Drink
                    {
                        Name = "Coffee ",
                        Price = 12.95M,
                        ShortDescription = " A beverage prepared from coffee beans",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://wallpaperscraft.com/image/table_grains_saucer_cup_coffee_drink_smoke_cinnamon_85000_1280x720.jpg",
                        InStock = true,
                        IsPrefferedDrink = true,
                        ImageThumbnailUrl = "http://sacredgroundsorganic.com/wp-content/uploads/2016/10/Sacred-Grounds-Single-Origin-capp.jpg"
                    },
                    new Drink
                    {
                        Name = "Kvass",
                        Price = 12.95M,
                        ShortDescription = "A very refreshing Russian beverage",
                        LongDescription = "Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC, making it over 2000 years old. Richard McClintock, a Latin professor at Hampden-Sydney College in Virginia, looked up one of the more obscure Latin words, consectetur, from a Lorem Ipsum passage, and going through the cites of the word in classical literature, discovered the undoubtable source. Lorem Ipsum comes from sections 1.10.32 and 1.10.33 of de Finibus Bonorum et Malorum (The Extremes of Good and Evil) by Cicero, written in 45 BC. This book is a treatise on the theory of ethics, very popular during the Renaissance. The first line of Lorem Ipsum, comes from a line in section 1.10.32. The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested. Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.",
                        Category = Categories["Non-alcoholic"],
                        ImageUrl = "https://i.ytimg.com/vi/X4YwsYP_J6I/maxresdefault.jpg",
                        InStock = true,
                        IsPrefferedDrink = false,
                        ImageThumbnailUrl = "http://podvor.com/upload/iblock/de8/kvas-na-sayt.jpg"
                    }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Alcoholic", Description="All alcoholic drinks" },
                        new Category { CategoryName = "Non-alcoholic", Description="All non-alcoholic drinks" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
