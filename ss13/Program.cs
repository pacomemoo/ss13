using System;

namespace CajeroAutomaticoModulado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorDinero gd = new GestorDinero(0);
            char opc='1';

            do
            {


                try
                {
                    Console.WriteLine("Menú Operaciones");
                    Console.WriteLine("[1] Depositar");
                    Console.WriteLine("[2] Retirar");
                    Console.WriteLine("[3] Ver saldo");
                    Console.WriteLine("[0] Salir");
                    Console.WriteLine("Indique opción");
                    opc = Console.ReadKey().KeyChar;
                    double monope = 0;
                    if (opc == '1' || opc == '2')
                    {
                        Console.WriteLine("Ingrese monto de la operación");
                        monope = double.Parse(Console.ReadLine());
                    }
                    switch (opc)
                    {
                        case '0': Console.WriteLine("Gracias, que tenga buen dia"); break;
                        case '1':
                            bool ope = gd.depositarDinero(monope);
                            if (ope)
                            {
                                Console.WriteLine("Operación OK");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Error en la operación");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            break;
                        case '2':
                            bool oret = gd.depositarDinero(monope);
                            if (oret)
                            {
                                Console.WriteLine("Operación OK");
                            }
                            else
                            {
                                Console.WriteLine("Error en la operacioón");
                            }

                            break;
                        case '3':
                            double resto = gd.obtenerSaldo();
                            Console.WriteLine($"Saldo actual:{resto:F2}");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opción incorrecta");
                            Console.ForegroundColor = ConsoleColor.White;
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error: {ex.Message.ToString()}");
                    Console.ForegroundColor = ConsoleColor.White;
                }

            } while (opc !='0');
            
            Console.ReadKey();

        }
    }
}
