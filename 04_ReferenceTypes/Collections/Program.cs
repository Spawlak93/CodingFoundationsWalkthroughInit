//string is technically a collection as it is a collection of characters
//Strings special case as they are immmutable
string stringExample = "Hello World";

//Array
//Unlike in Javascript Arrays in C# are a fixed size and hold a fixed type.
//we declare arrays by stating the type and then using square brackets[]
string[] stringArray = {"Hello", "World", "Why", "who", "What", "Where", stringExample };

//Indexing is still a thing remember the first index is 0
string thirdItem = stringArray[2];

//Interesting thing with reference types such as collections is they dont actually hold their value but rather the address of the value
//Aka if we set them = and then change one booth change

thirdItem = "Toast";
System.Console.WriteLine(thirdItem);
System.Console.WriteLine(stringArray[2]); 

string[] SameArray = stringArray;
SameArray[2] = "Toast";
System.Console.WriteLine(stringArray[2]);
System.Console.WriteLine(SameArray[2]);

//Similarly if we compate two different arrays that have the same values they are seen as different
int[] arrayOne = {1};
int[] arrayTwo = {2};
System.Console.WriteLine(arrayOne == arrayTwo);

//Arrays cannot be added to
//Lists are variable in length
//Lists we will use the most
List<int> listOfNumbers = new List<int>();
listOfNumbers.Add(1);
listOfNumbers.Add(2);
System.Console.WriteLine(listOfNumbers[1]);

//Queue FIFO
Queue<string> queueOfStrings = new Queue<string>();
queueOfStrings.Enqueue("Hello");
queueOfStrings.Enqueue("World");

System.Console.WriteLine(queueOfStrings.Dequeue());
System.Console.WriteLine(queueOfStrings.Dequeue());

//Stack LIFO
Stack<char> charStack = new Stack<char> ();
charStack.Push('a');
charStack.Push('b');
charStack.Push('c');
charStack.Push('d');
System.Console.WriteLine(charStack.Pop());
System.Console.WriteLine(charStack.Peek());
System.Console.WriteLine(charStack.Pop());

//Dictionary (Key Value Pairs) We decide the index
Dictionary<string, string> dictionaryOfThings = new Dictionary<string, string>();
dictionaryOfThings.Add("Cat", "It is like a teddybear mated with a cactus.");
dictionaryOfThings.Add("Espresso", "Has no x in it");

System.Console.WriteLine(dictionaryOfThings["Cat"]);