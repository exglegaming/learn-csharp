Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
var firstNumber = Console.ReadLine();
Console.WriteLine("Input the second number:");
var secondNumber = Console.ReadLine();

Console.WriteLine("What do you want to do with those numbers");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
var userSelection = Console.ReadLine();

if (userSelection.ToUpper() == "A") {
    Console.WriteLine(Add(int.Parse(firstNumber), int.Parse(secondNumber)));
} else if (userSelection.ToUpper() == "S") {
    Console.WriteLine(Subtract(int.Parse(firstNumber), int.Parse(secondNumber)));
} else if (userSelection.ToUpper() == "M") {
    Console.WriteLine(Multiply(int.Parse(firstNumber), int.Parse(secondNumber)));
}
else {
    Console.WriteLine("Invalid input");
}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();

int Add(int num1, int num2) {
    return num1 + num2;
}

int Subtract(int num1, int num2) {
    return num1 - num2;
}

int Multiply(int num1, int num2) {
    return num1 * num2;
}