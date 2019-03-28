using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Interfaces
{
    /// <summary>
    /// All interfaces start with the letter 'I'. Whenever you see a tyype that starts with 'I' 
    /// it represents an interface. It's a convention. Unlike classes,interfaces do not have implementation,
    /// you see here we have a method Run(),that is simply a declaration.It doesn't have a body. Interface members
    /// also do not have access modifiers. Access modifier is on interface level(public).
    /// You may wonder, WHY need of an interface ? 
    /// To build a loosley-coupled applications. Thats an application whos components are not tightely related to each other, which
    /// means making a change in one of the classes is easier and has a minimum or 0 impact on other classes.
    /// 
    /// </summary>
    public interface IRun
    {
        void Run();
    }
}
