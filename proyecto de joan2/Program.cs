internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine();
        Console.WriteLine("   Bienvenido a la calculadora cientidica");
        Console.WriteLine();
        Console.WriteLine("*********************************************");
        Console.WriteLine();
        //Movere a pedir el primer valor antes del ciclo
        Console.WriteLine("Ingrese el primer numero: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
       //creando un ciclo
        string terminar = "y";
        while (terminar=="y")
        {
            Console.WriteLine("Ingrese el siguiente numero: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //<<<<<<< HEAD
            Console.WriteLine("Escribe el nombre del operador quieres usar: ");
            Console.WriteLine();
            Console.WriteLine("1 - SUMA");
            Console.WriteLine("2 - RESTA");
            Console.WriteLine("3 - MULTIPLICACION");
            Console.WriteLine("4 - DIVICION");
            Console.WriteLine("5 - SENO");
            Console.WriteLine("6 - COSENO");
            Console.WriteLine("7 - TANGENTE");
            Console.WriteLine("8 - EXPONENCIAL");
            Console.WriteLine("9 - LOGARITMO");
            Console.WriteLine("10 - RAIZ CUADRADA");
            Console.WriteLine();
            int operador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            
//=======
////Console.WriteLine("Ingrese dos números:");
////double num1 = Convert.ToInt32(Console.ReadLine());
////double num2 = Convert.ToInt32(Console.ReadLine());
//>>>>>>> 41abe2098913176a01924cb1eb095ca16fa81140
            //primer comentario

            //double opcion = Convert.ToInt32(Console.ReadLine());

            double resultado ;
            switch (operador)
            {
                //voy a usar la variable resultado que esta desclarada pero no se usa
                case 1:
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma de  {num1} y {num2} es: " + (resultado));
                    num1 = resultado;
                    break;
                case 2:
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta de {num1} y {num2} es: " + (resultado));
                    num1 = resultado;
                    break;
                case 3:
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicacion de  {num1} y {num2} es: " + (resultado));
                    num1 = resultado;
                        break;
                case 4: //Agregando que no se puede dividir entre 0
                    resultado = num1 / num2;
                    if (num2 == 0)
                    {
                        Console.WriteLine("No se puede dividir entre 0");
                    }
                    else
                    {
                        Console.WriteLine($"El resultado de la divicion de {num1} y {num2} es: " + (resultado));
                    }
                    num1 = resultado;
                    break;
                case 5:
                    resultado = Math.Sin(num1);
                    Console.WriteLine($"El resultado del seno de  {num1} es: " + (resultado));
                    num1 = resultado;
                        break;
                case 6:
                    resultado = Math.Cos(num1);   
                    Console.WriteLine($"El resultado del coseno de  {num1} es: " + resultado);
                    num1 = resultado;
                    break;
                case 7:
                    resultado = Math.Tan(num1); 
                    Console.WriteLine($"El resultado la tangente de  {num1} es: " + resultado);
                    num1 = resultado;
                    break;
                case 8:
                    resultado = Math.Exp(num1); 
                    Console.WriteLine($"El resultado el exponencial de  {num1} es: " + resultado);
                    num1 = resultado;
                    break;
                case 9:
                    resultado = Math.Log(num1);
                    Console.WriteLine($"El resultado del logaritmo de {num1} y {num2} es: " + resultado);
                    num1 = resultado;
                    break;
                case 10:
                    resultado = Math.Sqrt(num1);    
                    Console.WriteLine($"El resultado del logaritmo de {num1} y {num2} es: " + resultado);
                    num1 = resultado;
                    break;
                default:
                    Console.WriteLine("Ingresaste un valor invalido, regresa al menu.");
                    break;
                  
    }
            Console.WriteLine("Pulse Y para seguir operando");
            terminar = Console.ReadLine().Trim().ToLower();
        }
    }
}

//Console.WriteLine("El resultado es: " + resultado);



