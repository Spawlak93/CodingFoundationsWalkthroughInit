string instructorName = "Simon";
string[] instructors = new string[]{ "Josh", "Amanda" , "Adam", instructorName };
System.Console.WriteLine(instructors);

//Anatomy of a foreach
//Foreach(type name in collection)
//{body}

foreach(string instructor in instructors)
{
    System.Console.WriteLine(instructor);
}

