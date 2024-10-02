double gpa = 88.8;

string grade = gpa switch
{
    >= 91 => "A",
    >= 81 => "B",
    >= 71 => "C",
    >= 61 => "D",
    >= 51 => "E",
    _ => "F",
};

Console.WriteLine($"Your grade is {grade}");