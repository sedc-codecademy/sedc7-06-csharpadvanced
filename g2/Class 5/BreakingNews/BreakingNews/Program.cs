using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingNews
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Mediums
            Medium cnn = new Medium();
            Medium a1 = new Medium();
            #endregion

            #region Followers
            Follower john = new Follower("John");
            Follower zvonko = new Follower("Zvonko");
            Follower zivko = new Follower("Zivko");
            #endregion

            #region Subscriptions
            john.Subscribe(cnn);
            john.Subscribe(a1);

            zvonko.Subscribe(a1);

            zivko.Subscribe(cnn);
            #endregion

            #region SendingNews
            cnn.SendBreakingNews("Man died eating", "lorem ipsum...", DateTime.Now);
            a1.SendBreakingNews("Cat bitten by a spider, looks like a ballon", "lorem ipsum...", DateTime.Now);
            #endregion

            Console.ReadLine();
        }
    }
}
