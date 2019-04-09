namespace Generics
{
    class MyDerivedGenericClass<T> : MyGenericClass<T>
    {
        public MyDerivedGenericClass(T value) : base(value)
        {

        }

        //Class implementation...
    }
}