namespace CSharpAdvanced_Class1
{
    public class Class1
    {
        public string MyProperty { get; set; } //shortest get and set methods definition
        public string MyProperty2 { get; private set; }
    }

    public class Class2
    {
        private string _myProperty;
        public string MyProperty
        {
            get { return _myProperty; }  //shorter form of the get method
            set { this._myProperty = value; } //shorter  form of the set method
        }
    }

    public class Class3
    {
        public string MyProperty;

        public string GetMyProp()  //this is the get method, in this case it returns string
        {
            return this.MyProperty;
        }
        public void SetMyProp(string value)  //this is the set method, it has void type
        {
            this.MyProperty = value;
        }
    }
}
