using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced_Class4.Interfaces
{
    public interface IPrice
    {
        double Price { get; }

        double GetTotalPrice();
    }
}
