namespace Generics
{
    /// <summary>
    /// When we define a generic class, we can apply restrictions to the kinds of types
    /// that client code can use. If client code tries to instantiate your class by using
    /// a type that is not allowed by a contraint, the result will be a compile time eror.
    /// These restrictions are called contraints. Honestly, its to early for you and we don't want
    /// to bother you with those contraints , its an early stage for that. Just you need to know there are 
    /// contraints in generics so the code below with 'where T: class' means the type argument
    /// must be a reference type. For you information, reference type are : class, interface,delegate..
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyAnotherGenericClass<T> where T : class
    {
        // Class implementation... 
    }
}