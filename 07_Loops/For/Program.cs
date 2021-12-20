//Anatomy of a for loop
//for (initializer; Condition; iterator)
//{ body }
// for (before the loop; condition to continue loop; after the loop)

//Creating initial target
int number = 100;

//1 
for (int i = 0; i < number; i++)
{
    System.Console.WriteLine(i);
}

//1 for keyword
//2 declaration and initialazation of an iterator variable
//3 boolean expression comparing iterator i to number
//4 Incrementing the iterator after the end of the body
//5 Body of the loop, runs once per iteration after boolean is evaluated as true