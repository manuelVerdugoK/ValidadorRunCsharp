using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int newRut;
            int dv;
            Console.WriteLine("Indique su nnombre completo");
            String nombre = Console.ReadLine();
            Console.WriteLine("Indique su rut con puntos y guión");
            String rut = Console.ReadLine();
            Console.WriteLine("Indique su numero telefonico");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique su correo electronico");
            String correo = Console.ReadLine();
            Console.WriteLine("=================================");
            Console.WriteLine("Usuario\t" + nombre + "\nrun \t" + rut + "\nnumero\t" + numero + "\ncorreo\t" + correo);

            if (rut != null)
            {
                rut = rut.Replace("-", "");
                rut = rut.Replace(".", "");
                if (rut.Length == 8 || rut.Length == 9)
                {
                    dv = int.Parse(rut.Substring(rut.Length - 1, 1));
                    newRut = int.Parse(rut.Substring(0, (rut.Length - 1)));
                    rut = "" + newRut;
                    int largo = rut.Length;
                    int invert;
                    int suma = 0;
                    int multi = 2;
                    for (int x = 0; x < largo; x++)
                    {
                        invert = int.Parse(rut.Substring(rut.Length - 1, 1));
                        invert *= multi;
                        multi += 1;
                        if (multi == 8)
                        {
                            multi = 2;
                        }
                        suma += invert;
                        if (rut.Length == 1)
                        {
                            x = largo;
                        }
                        else
                        {
                            rut = rut.Substring(0, (rut.Length - 1));
                        }
                    }
                    int operacion;
                    operacion = suma / 11;
                    operacion = operacion * 11;
                    operacion = suma - operacion;
                    operacion = 11 - operacion;

                    if (dv != operacion)
                    {
                        Console.WriteLine("El rut ingresado no es valido " + dv);
                    }
                }
                else
                {
                    Console.WriteLine("El rut no tiene la cantidad de cifras suficientes");
                }
            }
        } 
    }
}
