using System;
using System.Collections.Generic;
using System.Linq;
using DrinkWorld.Data.Interfaces;
using DrinkWorld.Data.Models;

namespace DrinkWorld.Data.mocks
{
    public class MockDrinkRepository :  IDrinkRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();
        public IEnumerable<Drink> Drinks => new List<Drink>
        {
            new Drink
            {
                Name = "Beer",
                Price = 7.95M,
                ShortDescription = "The most widely consumed alcohol",
                LongDescription = "Beer is the oldest[1][2][3] and most widely consumed[4] alcoholic drink in the world," +
                                  " and the third most popular drink overall after water and tea.[5] Beer is brewed from cereal grains — most commonly from malted barley, though wheat, maize (corn), and rice are also used. During the brewing process, fermentation of the starch sugars in the wort produces ethanol and carbonation in the resulting beer.[6] Most modern beer is brewed with hops, which add bitterness and other flavours and act as a natural preservative and stabilizing agent. Other flavouring agents such as gruit, herbs, or fruits may be included or used instead of hops. In commercial brewing, the natural carbonation effect is often removed " +
                                  "during processing and replaced with forced carbonation",
                Category = _categoryRepository.Categories.First(),
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
                Category = _categoryRepository.Categories.Last(),
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
                Category = _categoryRepository.Categories.First(),
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
                Category = _categoryRepository.Categories.Last(),
                ImageUrl = "https://i.ytimg.com/vi/6IItTVwk2Es/maxresdefault.jpg",
                InStock = true,
                IsPrefferedDrink = false,
                ImageThumbnailUrl = "http://www.africaprocessing.com/wp-content/uploads/2016/01/fresh-juice-manufacturing-1.jpg"
            },

        };

        public IEnumerable<Drink> PrefferedDrinks { get; }
        public Drink GetDrinkById(int drinkId)
        {
            throw new NotImplementedException();
        }

    }
}
