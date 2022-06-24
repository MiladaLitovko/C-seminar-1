//функция(процедура) возведения числа в квадрат

int number = 6;
OurPower(number); // вызов метода
OurPower(7); // вызов метода
OurPower(number + number); // вызов метода

void OurPower(int currentnumber)
{
    Console.WriteLine(currentnumber * currentnumber);
}

