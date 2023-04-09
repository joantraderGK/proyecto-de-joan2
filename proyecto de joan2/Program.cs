// See https://aka.ms/new-console-template for more information



Console.WriteLine("Ingrese dos números:");
double num1 = Convert.ToInt32(Console.ReadLine());
double num2 = Convert.ToInt32(Console.ReadLine());


double opcion = Convert.ToInt32(Console.ReadLine());

double resultado = 0;
switch (opcion)
{
    case 1:
        resultado = num1 + num2;
        break;
    case 2:
        resultado = num1 - num2;
        break;
    case 3:
        resultado = num1 * num2;
        break;
    case 4:
        resultado = num1 / num2;
        break;
    case 5:
        resultado =  (num1 * num1) / 100.0; ;
        break;
    case 6:
        resultado = Math.Sqrt(num1);
        break;
}


Console.WriteLine("El resultado es: " + resultado);




