bool isRaining = true;
bool isGoingOutside = false;

//anatomy of an if
//if(boolean)
//{
    //Code to run if true
//}
if(isRaining)
{
    System.Console.WriteLine("It is raining out");
}

//Combine conditionals
if(isRaining && isGoingOutside)
{
    System.Console.WriteLine("I need to bring my umbrella");
}

if(!isRaining || !isGoingOutside)
{
    System.Console.WriteLine("I dont need to bring an umbrella");
}

if(isRaining ^ isGoingOutside)
{
    System.Console.WriteLine("I dont need an umbrella becaus eif it is raining I wont go outside");
}

if(isRaining)
{
    System.Console.WriteLine("I won't cut the grass");
}
else 
{
    System.Console.WriteLine("I can cut the grass");
}
