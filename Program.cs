double altura, massa, imc;
string resultado;

Console.WriteLine("Meu pau e maior que minha perna");
Console.WriteLine("-- Calculadora de IMC --");
Console.WriteLine("Digite sua massa em quilos...");
massa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digita sua altura em metros...");
altura = Convert.ToDouble(Console.ReadLine());

bool imcvalid = massa > 0 && massa <= 400 && altura > 0 && altura <= 3;

if (imcvalid)
{
imc = massa / (altura * altura);

if (imc < 17)
{
Console.ForegroundColor = ConsoleColor.DarkRed;
resultado = "Você está muito abaixo do peso ideal!";
}
else if (imc >= 17 && imc <= 18.49)
{
Console.ForegroundColor = ConsoleColor.Red;
resultado = "Você está abaixo do peso!";
}
else if (imc >= 17 && imc <= 24.99)
{
Console.ForegroundColor = ConsoleColor.DarkYellow;
resultado = "Seu peso está normal!";

}
else if (imc >= 25 && imc <= 29.99)
{
Console.ForegroundColor = ConsoleColor.Yellow;
resultado = "Você está acima do peso!";
}
else if (imc >= 30 && imc <= 29.99)
{
Console.ForegroundColor = ConsoleColor.Cyan;
resultado = "Você está com obesidade nível 1!";

}
else if (imc >= 35 && imc <= 39.99)
{
Console.ForegroundColor = ConsoleColor.Blue;
resultado = "Você está com obesidade nível 2!";
}
else
{
Console.ForegroundColor = ConsoleColor.DarkMagenta;
resultado = "Você está com obesidade mórbida, procure um tratamento!";
}

Console.WriteLine(resultado);
Console.ResetColor();
}
else
{
Console.WriteLine("Valores inválidos para altura ou massa!");
return;
}