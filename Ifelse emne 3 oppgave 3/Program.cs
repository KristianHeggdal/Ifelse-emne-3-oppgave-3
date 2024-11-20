// See https://aka.ms/new-console-template for more information
Console.WriteLine("Skriv inn to tall");
var number1Input = Console.ReadLine();
var number2Input = Console.ReadLine();
int number1 = int .Parse(number1Input);
int number2 = int .Parse(number2Input);

bool is30 = CheckNumbers();
CheckNumbers();
print();

bool CheckNumbers()
{
    if (number1 + number2 == 30 || number1 + number2 > 30)
    {
        return true;
    };
    return false;
}

void print()
{
    if (is30 == true)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("false");
    }
}

;

