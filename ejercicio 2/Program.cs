Console.WriteLine("calcule el monto de la propina");
Console.WriteLine("ingrese el total de su cuenta");

double monto = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("ingrese el porcentaje de la propina");

double porcentaje = Convert.ToDouble(Console.ReadLine());
double subtotal = monto * (porcentaje / 100);

Console.WriteLine("el monto de la propina es de: " + subtotal);


