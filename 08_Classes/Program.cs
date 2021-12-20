//Adding using statement  after 
using Classes;

Donut doug = new Donut("Boston Cream");
// doug.donutType = "Boston Cream";
System.Console.WriteLine(doug.GetDonutType());
doug.SetDonutType("Glazed");
System.Console.WriteLine(doug.GetDonutType());

//Declaring namespace to group things together
namespace Classes
{
    //Declaring class
    class Donut
    {
        //Fields usual private
        //Anatomy of a field
        //accessModifier type name
        private string donutType;

        //Constructor
        //Anatomy of a Constructor
        //access modifier ClassName(paramaterType parameterName)
        //{ Constructor Body * code runs here * }
        public Donut(string type)
        {
            donutType = type;
        }

        //Properties(added after methods)
        //built in get and set methods
        public string Filling { get; set; }
        public decimal Price { get; set; }
        public bool IsSpecial { get; set; }
        public string Topping { get; set; }

        //Anatomy of a method
        //accessModifier returnType MethodName(parameterType parameterName)
        //{ Body of method code runs here }
        //Get Method
        public string GetDonutType()
        {
            return donutType;
        }

        //Set Method
        public void SetDonutType(string type)
        {
            donutType = type;
        }

        //Perhaps make person class
    }
}