// MIS 3013 001
// Feb 05, 2024
// Alexandra Camarena
// 113568154

// if else statement
// if (condition) // ; no ; here
// {
//      // branch 1
//}
// else
//{
//     // branch 2; 
//}// ; not necessary
// This is the next line of if else statement

double grade;

Console.Write("Please input a grade: ");

string gradeStr;
gradeStr=Console.ReadLine();

grade = Convert.ToDouble(gradeStr);

if (grade>=90)
{
    // A
    Console.WriteLine("It is A!");
}
else // else means grade is < 90
{
    // not A
    Console.WriteLine("It is NOT A!");
}