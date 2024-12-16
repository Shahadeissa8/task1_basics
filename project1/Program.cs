Console.WriteLine("These tasks are done by Shahad Eissa");


// 1, C# paramitive type:
// Task 1:
int thisInt = 100;
double thisDouble = 10.0;
string thisString = "this is a string";
bool  thisBool = true;
Console.WriteLine(thisInt);
Console.WriteLine(thisDouble);
Console.WriteLine(thisString);
Console.WriteLine(thisBool);


// Task 2:
double converstion = Convert.ToDouble(thisInt);
Console.WriteLine(converstion);
// although this prints the same value of thisInt but the type of it has changed, meaning it became temporarly a double

//Bonus q
// char is used to declare one character be it a number or a letter

// 2, C# variables:
// Task 1:

string studentName; // amel case
double grade_point_average; // Underscoring / Snake case
string FavoriteSubject; // Pascal case

// Task 2:
double Area;
double Width = 6;
double Lenght = 5;
Area = Width * Lenght;
Console.WriteLine("Area is: " + Area);

//Control flow
Console.WriteLine("enter current hour: ");
int currentHour = Convert.ToInt32 (Console.ReadLine());
if (currentHour >= 11 && currentHour <= 14)
{
    Console.WriteLine("Time for lunch!");
}
