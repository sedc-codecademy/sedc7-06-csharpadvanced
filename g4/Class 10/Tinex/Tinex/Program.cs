using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tinex
{
    class Program
    {
        static void Main(string[] args)
        {
            Market superMarket = new Market()
            {
                Name = "SuperMart",
                CurrentPromotion = ProductType.Food
            };
            User bob = new User()
            {
                Name = "Bob Bobsky",
                Age = 21,
                FavoriteType = ProductType.Food
            };
            User jill = new User()
            {
                Name = "Jill Wayne",
                Age = 28,
                FavoriteType = ProductType.Cosmetics
            };
            User greg = new User()
            {
                Name = "Greg Gregsky",
                Age = 48,
                FavoriteType = ProductType.Electronics
            };
            superMarket.SubscribeForPromotions(bob.ReadPromotion, "bob@gmail.com");
            superMarket.SubscribeForPromotions(jill.ReadPromotion, "jill@gmail.com");
            superMarket.SubscribeForPromotions(greg.ReadPromotion, "greg@gmail.com");

            Console.WriteLine("Sending promotion for food");
            superMarket.SendPromotions();
            superMarket.CurrentPromotion = ProductType.Cosmetics;
            superMarket.UnsubscribeForPromotions(greg.ReadPromotion, "Dosadni ste");

            superMarket.SendPromotions();
            superMarket.UnsubscribeForPromotions(bob.ReadPromotion, "Dosta je bio");

            Console.WriteLine("ZALBI I POPLAKI");
            foreach (string zalba in superMarket.ZalbiIPoplaki)
            {
                Console.WriteLine(zalba);
            }

            Console.ReadLine();
        }
    }
}
