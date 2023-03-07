int CountChar(string word)
{
    return word.Length;
}
Console.WriteLine(CountChar("aeiou"));

string ConvertUp( string word) // what is the return type? what do you want to call the method? what is the input type? what shall you call the input parameter?
{
    return word.ToUpper(); // what do you want it to do?
}
Console.WriteLine(ConvertUp("aeiou"));

int FindCharPos(string word, char c)
{
    return word.IndexOf(c); //IndexOf is available as a built-in method for strings
}
Console.WriteLine(FindCharPos("aeiou",'a'));

string GetFirstChar(string word) // how many parameters do we need to define? What are their types?
{
    return word.Substring(0, 2);// substrings take part of a string.  you can state the starting position of the string and how many characters you want to take.  the second parameter is the length.substring method in string class takes the string from position 0 and the number of characters we want to get is 1.
}
Console.WriteLine(GetFirstChar("aeiou"));


//create a method to get the last character in a string and call the method.

string GetLastChar (string word)
{
    return word.Substring(word.Length - 1, 1);
}
Console.WriteLine(GetLastChar("aeiou"));

void NoCommaDisplay (string word)
{
    string[] arr = word.Split(',');
    foreach (string item in arr)
    {
        Console.WriteLine(item);
    }
}
NoCommaDisplay("A,Bobb, C");

//methods are handy if you want to reuse code without re-typing

//generate a random uppercase character

char GenerateUCaseChar() // return type is a char, but we don't have a built in method in C# to generate a random character so we use ascii
{
    //A-Z:65-90
    Random r = new Random();
    int rndNum = r.Next(65, 91);
    char rndUChar = (char)rndNum; //this is casting
    return rndUChar;
}

string GenerateUCaseStr( int len) // this determines how many characters we want in this string so you can change the length any time
{
    string myRndStr = " ";// starts with an empty string
    for (int i = 0; i<len; i++)
    {
        myRndStr += GenerateUCaseChar(); // get one random char and add it to the string called myRndStr. += concatenates because one of the values is a string/char
    }
    return myRndStr;
}

Console.WriteLine(GenerateUCaseStr(5));
Console.WriteLine(GenerateUCaseChar());

//check out StringBuilder Class for mutable strings 
// strings are immutable so the computer creates new memory for each new valueassigned to the string and ti'll become an expensive operation.
// C# uses .Net which has a garbage collector so you dont have to worry about memory, unlike C where you need to write code to free up memory


//generate a random lowercase character (97-122)
char GenLowerChar()
{
    Random GenLow = new Random();
    int ranLowInt = GenLow.Next(97, 123);
    char rndLChar = (char)ranLowInt;
    return rndLChar;
}

//generate a string that contains multiple random lowercase characters
string GenerateLCaseStr (int len=5)//setting the default length to 5
{
    string myRndStr = "";
    for (int i = 0; i<len; i++)
    {
        myRndStr += GenLowerChar();

    }
    return myRndStr;
}
Console.WriteLine(GenerateLCaseStr(10)); // uses 10 as lenght instead of the default 5

//generate a random vowel character
char GenerateVowel()
{
    string vowels = "aeiou";
    Random r = new Random();
    int rndIndex = r.Next(0,5);// 0-4 //create a random number that specifies the index of the string
    return vowels[rndIndex];
}

Console.WriteLine(GenerateVowel()+GenLowerChar()+GenerateUCaseChar()); // each charcter is gonna be converted to ascii number and this adds the ascii numbers together. so you need to cast each input into charactor or you can add string separator
Console.WriteLine(""+ GenerateVowel() + GenLowerChar() + GenerateUCaseChar()); //adding string in front then gets this to concatenate string with everything else as a string

//int+int = int --> addition
// string + string = string --> concatenation
// int+ string = string -> concatenation
// char + string = string -> conctenation, anythignwith string becomes a string
//char + char = int --> TRICKY ADDITION! It'll add the ascii values of the char