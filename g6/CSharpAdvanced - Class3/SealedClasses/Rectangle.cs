using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    /// <summary>
    /// Rectangle class that inherits from Shape. Any derived class can also
    /// be marked with 'sealed'keyword, you can notice below that I have marked
    /// Rectangle as a sealed class. That means if we try to create another class
    /// that inherits from Rectangle we will get a compile time error. For excercise
    /// create a new class and try to inherit from Recntagle.
    /// You may ask yourself: But why do we need sealed or why would I mark a class as sealed? 
    /// In documetation you can find that Microsoft is saying because of some run-time 
    /// optimizations selaed classes are sligthly faster.This is probably true but 
    /// in a very large and robust applications.
    /// 
    /// </summary>

    public sealed class Rectangle : Shape
    {
        /// <summary>
        ///  We can also mark methods with sealed keyword and it can only be applied 
        ///  to the methods that are overriding a virtual method from the base class.
        ///  So if we are not overriding a method that is defined as virtual in the base 
        ///  class there is no need to apply sealed.
        ///  When we mark a method with a sealed class, that method cannot be customized further..
        /// </summary>
        public sealed override void Draw()
        {
            Console.WriteLine("Draw a rectrangle.");
        }
    }
}
