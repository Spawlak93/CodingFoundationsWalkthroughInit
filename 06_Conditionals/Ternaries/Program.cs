//Anatomy of a Ternary
//Boolean ? what to return if true : what to return if false;

Console.Write("Enter your age: ");
string response = Console.ReadLine();
//Utilizing a method built into the int struct to convert a string to an int
int age = int.Parse(response);

string output = age >= 100 ? "Wow you are old" : "What are you talking about you arent that old";
System.Console.WriteLine(output);