System.Console.WriteLine("Enter a name");
string name = Console.ReadLine();
switch (name)
{
    case "Bob":
        Console.WriteLine("Hey Bob");
        break;
    case "Avocado":
        Console.WriteLine("Did you know you are a berry?");
        break;
    default:
        Console.WriteLine("I dont talk to strangers");
        break;
}

Console.WriteLine("How are you feeling today on a scale of (1-5)?");
string feelingRating = Console.ReadLine();
switch(feelingRating)
{
    case "5":
    System.Console.WriteLine("Awesome");
    break;
    case "4":
    System.Console.WriteLine("Good");
    break;
    case "3":
    case "2":
    //Can combine cases to do the same thing
    System.Console.WriteLine("Meh");
    break;
    case "1":
    System.Console.WriteLine("I hope your day improves");
    break;
    default:
    System.Console.WriteLine("I dont understand");
    break;
}

//Switch Expression
System.Console.WriteLine("Who am I helping today?");
string firstName = Console.ReadLine();
string response = firstName switch
{
    //Lambda or Fat arrow to denote expression
    "Dave" => "I'm sorry Dave I can't do that",
    //Seperated by commas
    //Underscore to denote default
    _ => "I'm happy to help you"
}; //Requires semicolon to complete

System.Console.WriteLine(response);