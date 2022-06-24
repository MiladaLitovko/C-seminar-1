//int number = 5;
Console.WriteLine("Введите число, которое нужно возвести в квадрат");
int number = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(number*number);
//Console.WriteLine(Math.Pow(number, 2));
//Console.WriteLine("5 в квадрате равно " + Math.Pow(number, 2));
Console.WriteLine($"{number} в квадрате равно {Math.Pow(number, 2)}");