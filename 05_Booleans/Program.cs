//We have seen booleans before and have worked with them quite a bit so they should be familiar
//booleans use the true/false keywords
//Lets explore some boolean logic
bool isCool = true;
isCool = false;

//Boolean Operators

//Not (!)
bool isTrue = !false;
bool isFalse = !true;

//AND Operator (&/&&)
//Mention single & but also mention why && is best practice
bool AndTrue = true && true;
bool AndFalse = true && false;

//Or Operator (||)
//Once again can mention single but not necisary
bool OrTrue = true || false;
bool OrFalse = false || false;

//Exclusive Operator (^)
bool XORTrue = true ^ false;
bool XORfalse = true ^ true;
//Think of those lightswitches that have to face different directions for power to flow

//can write out to console if desired.

//Comparison Operators
//Equal
//Remember single = is used for assignment
bool equal = 3 == 5;
bool notequal = 5 != 22;

bool greaterThan = 5 > 3;
bool greaterOrEqual = 5 >= 5;

bool lessThan = 22 < 1900;
bool lessOrEqual = 1 <= 1;

