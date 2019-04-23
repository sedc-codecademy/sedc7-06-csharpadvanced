using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tinex
{
    public class Market
    {
        public delegate void PromotionSender(ProductType product);
        public delegate void InformationSender(string info);
        private event PromotionSender Promotions;
        private event InformationSender Information;
        public string Name { get; set; }
        public ProductType CurrentPromotion { get;set; }
        public List<string> ZalbiIPoplaki { get; set; }
        public List<string> Emails { get; set; }
        public Market()
        {
            ZalbiIPoplaki = new List<string>();
            Emails = new List<string>();
        }
        public void SendPromotions()
        {
            Console.WriteLine("...Sending");
            Thread.Sleep(2000);
            Send();
        }
        private void Send()
        {
            Promotions(CurrentPromotion);
        }
        public void SubscribeForPromotions(PromotionSender subscriber, string email)
        {
            Promotions += subscriber;
            Emails.Add(email);
        }
        public void SubscribeForInformation(InformationSender subscriber, string email)
        {
            Information += subscriber;
            Emails.Add(email);
        }
        
        public void UnsubscribeForPromotions(PromotionSender unsubscriber, string reason)
        {
            Promotions -= unsubscriber;
            ZalbiIPoplaki.Add(reason);
        }
    }
}
