using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] mat = new string[5, 15];
            char OP = 's';
            int op;

            while(OP=='s')
            {
                mat[0, 0] = "Nombre";
                mat[1, 0] = "Apellido";
                mat[2, 0] = "Direccion";
                mat[3, 0] = "Telefono";
                mat[4, 0] = "Correo";

                Console.Clear();
                Console.WriteLine("Qué Desea Hacer:\n 1.Ingresar Contacto\n 2.Mostrar Contactos\n 3.Buscar");
                op = int.Parse(Console.ReadLine());

                if(op==1)
                {
                    Console.Clear();
                    Console.WriteLine("Ingrese los siguientes datos: Nombre, Apellido, Direccion, Telefono, Correo\n");

                    for(int f=1; f< 15; f++)
                    {
                        for(int c=0; c<5; c++)
                        {
                            Console.Write("Ingrese Nota [Valor:" + (f) + ", Dato:" + (c + 1) + "]: ");

                            mat[c, f] = Console.ReadLine();
                        }
                    }
                }
                if(op==2)
                {
                    Console.Clear();
                    Console.WriteLine("\n Datos de los Contactos: ");
                    for(int f=0; f<15; f++)
                    {
                        Console.WriteLine(mat[0,f]+""+mat[1,f]+""mat[3,f]+""+mat[4,f]);
                    }
                }
                if(op==3)
                {
                }


            }
        }
    }
}
