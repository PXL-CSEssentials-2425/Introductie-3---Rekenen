Console.Write("Geef een geheel getal: ");
string firstInput = Console.ReadLine();
Console.Write("Geef nog een geheel getal: ");
string secondInput = Console.ReadLine();

int firstNumber = int.Parse(firstInput);
int secondNumber = int.Parse(secondInput);

int sum = firstNumber + secondNumber;
Console.WriteLine($"De som van {firstNumber} en {secondNumber} is {sum}.");
int difference = firstNumber - secondNumber;
Console.WriteLine($"Het verschil tussen {firstNumber} en {secondNumber} is {difference}.");
int product = firstNumber * secondNumber;
Console.WriteLine($"Het product van {firstNumber} en {secondNumber} is {product}.");
int quotient = firstNumber / secondNumber;
Console.WriteLine($"Het quotiënt van {firstNumber} en {secondNumber} is {quotient:N2}.");

Console.WriteLine("Druk op Enter om af te sluiten.");
Console.ReadLine();
