using System;

namespace Generics
{
    /// <summary>
    /// We have two form of generic in C#: generic types (classes, interfaces,delegates) and generic methods.
    /// As you already know, in some places when we would expect a normal type, like in the class below,
    /// you will see a type parameter instead. That type parameter is a placeholder for a real type and as you
    /// have noticed, it appears in angle brackets <T>. Consumer of this class will specify what is T.
    /// Angle brackets<> are the first association that you are playing with generics. Remember that you
    /// are not limitted by using just T letter. Some developers prefer to use U or V instead of T.
    /// You can also place some word there instead of just one letter. It is recommended to
    /// use T because it is the first letter from word TYPE.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class MyGenericClass<T>
    {
        private T _genericMemberVariable;

        public T GenericProperty { get; set; }

        public MyGenericClass(T value)
        {
            _genericMemberVariable = value;
        }

        /// <summary>
        /// Generic method that has a T as a return type and accepts 
        /// a parameter of type T. Do we know what is T? Not yet. The
        /// consumer of this method will have to specify what is T.Can be some
        /// class for example Person, that way this method will accept a parameter
        /// of type Person and return the same. Can be string, int ...
        /// </summary>
       
        public T GenericMethod(T genericParameter)
        {
            Console.WriteLine($"Generic Method - Parameter type: {typeof(T).ToString()}, value: {genericParameter}");
            Console.WriteLine($"Generic Method - Return type: {typeof(T).ToString()}, value: {_genericMemberVariable}");

            return _genericMemberVariable;
        }
    }
}