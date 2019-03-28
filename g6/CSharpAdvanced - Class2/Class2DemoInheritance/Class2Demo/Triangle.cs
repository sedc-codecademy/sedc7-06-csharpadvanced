using System;

namespace Class2Demo
{
    /// <summary>
    /// New type of shape called Trangle, we are inheriting the functionalities
    /// provided by the base class Shape
    /// </summary>
    public class Triangle : Shape
    {

        // If method is marked as virtual in the base class, we may forget to ovveride 
        // that method in derived class and that way we will not have an algorithm for
        // drawing a triangle. If we try to draw a triangle nothing will happen.
        // Plus, if we forget to implement the virtual
        // method from the base class. We dont get a compile time error.
        // In this kind of situation when we want the method to be overriden in derived 
        // classes, we must use abstract instead of virtual.


    }
}
