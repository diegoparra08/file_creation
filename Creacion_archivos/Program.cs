using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.SymbolStore;
using static System.Net.WebRequestMethods;

namespace Creacion_archivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creación de un archivo de texto plano
           /* TextWriter file1 = new StreamWriter("Informacion.txt"); //Esta es la declaración de el archivo y el formato que le daremos. 

            Console.WriteLine("Escribe el mensaje a guardar");
            string message = Console.ReadLine();
            file1.WriteLine(message);

            file1.Close();
            Console.Clear();
            Console.WriteLine("Archivo guardado correctamente");*/

            //Lectrua del archivo
            TextReader readFile = new StreamReader("Informacion.txt");
            Console.WriteLine(readFile.ReadToEnd());
            readFile.Close();

            //Modificación del archivo
            Console.WriteLine("Ingresa el texto que quieres agregar");
            StreamWriter addToFile = System.IO.File.AppendText("Informacion.txt");
            string messagToAdd = Console.ReadLine();
            addToFile.WriteLine(messagToAdd);
            addToFile.Close();

            Console.Clear();
            Console.WriteLine("Archivo actualizado correctamente");


            /*
            //Segundo archivo

            Console.WriteLine("¿Cómo deseas llamar a tu archivo?");
            string fileName = Console.ReadLine();
            //Se le da nombre variable al archivo y se debe usar el using para asegurar que se cierra el textwriter
            using (TextWriter file2 = new StreamWriter($"{fileName}.csv"))
            {
                Console.WriteLine("¿Cuantas columnas tendrá tu archivo?");
                int cicles = int.Parse(Console.ReadLine());

                //Se declara un array paara guardar los headers y una matriz para los contenidos
                string[] headers = new string[cicles];
                string[,] contents = new string[100, 100];

                //Logica para capturar los headers
                for (int i = 0; i < cicles; i++)
                {
                    Console.WriteLine($"Ingresa el nombre del encabezado {i + 1}");
                    string header = Console.ReadLine();
                    headers[i] = header;
                }
                //Se crea un string con todo el contenido de los headers, esto se irá en la primera fila del archivo excel
                string totalHeader = string.Join(",", headers);
                //Se le escribe el titulo al archivo
                file2.WriteLine(totalHeader);

                //Se inicia logica para recolección de datos de las filas
                bool flag = true;
                int rows = 0;

                do
                {  //un ciclo para agregar contenido a cada fila de la matriz
                    for (int i = 0; i < cicles; i++)
                    {
                        Console.WriteLine($"Ingresa el valor de {headers[i]} para la fila {rows + 1}");
                        contents[rows, i] = Console.ReadLine();
                    }
                    rows++;

                    Console.WriteLine("¿Deseas agregar otra linea? (true/false)");
                    bool flagValue = bool.Parse(Console.ReadLine());

                    if (!flagValue)
                    {
                        flag = false;
                    }
                }
                while (flag);

                //un ciclo for anidado para ir enviando el contenido de cada fila al archivo
                for (int row = 0; row < rows; row++)
                {
                    List<string> rowData = new List<string>();

                    for (int col = 0; col < cicles; col++)
                    {
                        rowData.Add(contents[row, col]);
                    }
                    file2.WriteLine(string.Join(",", rowData));
                }

            }*/

            Console.ReadKey();
        }
    }
}
