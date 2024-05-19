Console.WriteLine("calcule el indice de su masa corporal");
Console.WriteLine("ingrese su peso en kilogramos");

double peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingrese la altura en metros");

double altura = Convert.ToDouble(Console.ReadLine());
double imc = peso / (altura * altura);

Console.WriteLine("su indice de masa corporal es: " + imc);



