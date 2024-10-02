#region Finding out whether the sum of the digits of a given 3-digit number is even or odd.

//int threeDigitNumber = 233;

//int hundreds = threeDigitNumber / 100;
//int tens = (threeDigitNumber / 10) % 10;
//int ones = threeDigitNumber % 10;

//int sumOfDigits = hundreds + tens + ones;

//if (sumOfDigits % 2 == 0)
//{
//    Console.WriteLine("The sum of the given number's digits is even.");
//} else
//{
//    Console.WriteLine("The sum of the given number's digits is not even.");
//}

#endregion

#region Finding the arithmetic mean of the digits of a given 4-digit number.

//int fourDigitNumber = 2354;

//int thousands = fourDigitNumber / 1000;
//int hundreds = (fourDigitNumber / 100) % 10;
//int tens = (fourDigitNumber / 10) % 10;
//int ones = fourDigitNumber % 10;

//double arithmeticMean = (thousands + hundreds + tens + ones) / 4.0;

//Console.WriteLine($"The arithmetic mean of {fourDigitNumber}'s digits is {arithmeticMean}.");

#endregion

#region "Determining whether the sum of the digits of a given 3-digit number is divisible by 3 and 5."

//int threeDigitNumber = 754;

//int hundreds = threeDigitNumber / 100;
//int tens = (threeDigitNumber / 10) % 10;
//int ones = threeDigitNumber % 10;

//int sumOfDigits = hundreds + tens + ones;

//if (sumOfDigits % 3 == 0 && sumOfDigits % 5 == 0)
//{
//    Console.WriteLine("The sum of the digits of a given 3-digit number is divisible by 3 and 5.");
//} else
//{
//    Console.WriteLine("It is not divisible");
//}

#endregion

#region "Determining the semester result based on the given student's score. (e.g., 90 => B, 50 => F (Fail))"

//double gpa = 11.31;

//switch (gpa)
//{
//    case >= 91 and <= 100:
//        Console.WriteLine("A");
//        break;
//    case >= 81 and <= 90:
//        Console.WriteLine("B");
//        break;
//    case >= 71 and <= 80:
//        Console.WriteLine("C");
//        break;
//    case >= 61 and <= 70:
//        Console.WriteLine("D");
//        break;
//    case >= 51 and <= 60:
//        Console.WriteLine("E");
//        break;
//    default:
//        Console.WriteLine("Fail");
//        break;
//}

#endregion

#region "Checking two given numbers. If both numbers are even, find their sum; if at least one is odd, find their difference."

//int number1 = 234;
//int number2 = 342;

//if (number1 % 2 == 1 && number2 % 2 == 1)
//{
//    Console.WriteLine("Given numbers are both odd.");
//}
//else if (number1 % 2 == 1 || number2 % 2 == 1)
//{
//    Console.WriteLine($"{number1} - {number2} = {number1 - number2}");
//} else
//{
//    Console.WriteLine($"{number1} + {number2} = {number1 + number2}");
//}

#endregion

#region Salary problem

int salaryOfWorker = 800;
int bankLoan = 5000;
int annualSalary = 12 * salaryOfWorker;

if (bankLoan>(annualSalary*60)/100)
{
    Console.WriteLine("Your request is denied. Please review the loan amount requested.");
} else
{
    Console.WriteLine("Your request has been approved. Thank you for your application.");
}

#endregion