using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matedaniel 
{
    class Program
    {
        static void Main(string[] args){
            //Ruta del archivo en C.
            //No pude agregarlo dentro del mismo proyecto.
            iPrueba(@"c:\entrada.txt");
            Console.ReadKey();
        }

        public static void iPrueba(string rutita){
            operaciones action = new operaciones();

            string lectura;
            System.IO.StreamReader archivo = new System.IO.StreamReader(rutita);

            while ((lectura = archivo.ReadLine()) != null){
                //Variable para almacenar en el archivo de texto;
                List<string> escribir_Archivo = new List<string>() { };
                string[] vals = lectura.Substring(lectura.IndexOf(":") + 1).Split(':');
                string number = lectura.Substring(0, lectura.IndexOf(":"));
                string metodo = vals[0];
                int[] datos = Array.ConvertAll(vals[1].Split(' '), s => int.Parse(s));
                string resultado = vals[2];

                if (metodo == "mediaAritmetica"){
                    if (action.mediaAritmetica(datos) == double.Parse(resultado)){
                        Console.WriteLine("Exito->>> {0}:{1}:{2}:{3}", number, metodo, vals[1], resultado);
                        escribir_Archivo.Add("Exito->>> {0}:{1}:{2}:{3}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado);
                    }

                    else{
                        Console.WriteLine("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}", number, metodo, vals[1], resultado, action.mediaAritmetica(datos));
                        escribir_Archivo.Add("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado + ", " + action.mediaAritmetica(datos));
                    }
                }

                if (metodo == "mediaGeometrica"){
                    if (action.mediaGeometrica(datos) == double.Parse(resultado)){
                        Console.WriteLine("Exito->>> {0}:{1}:{2}:{3}", number, metodo, vals[1], resultado);
                        escribir_Archivo.Add("Exito->>> {0}:{1}:{2}:{3}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado);
                    }
                    else

                        Console.WriteLine("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}", number, metodo, vals[1], resultado, action.mediaGeometrica(datos));
                    escribir_Archivo.Add("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado + ", " + action.mediaGeometrica(datos));
                }

                if (metodo == "mediaArmonica"){
                    if (action.mediaArmonica(datos) == double.Parse(resultado)){
                        Console.WriteLine("Exito->>> {0}:{1}:{2}:{3}", number, metodo, vals[1], resultado);
                        escribir_Archivo.Add("Exito->>> {0}:{1}:{2}:{3}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado);
                    }
                    else

                        Console.WriteLine("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}", number, metodo, vals[1], resultado, action.mediaArmonica(datos));
                    escribir_Archivo.Add("Fracaso->>> {0}:{1}:{2}:{3} ::: Resultado maquina: {4}" + ", " + number + ", " + metodo + ", " + vals[1] + ", " + resultado + ", " + action.mediaArmonica(datos));
                }

                using (StreamWriter escribir = new StreamWriter(@"c:\Respuestas.txt")){
                    foreach (string x in escribir_Archivo)
                    {
                        escribir.WriteLine(x);
                    }
                }
                Console.ReadKey();
            }
            archivo.Close();


            //List<string> ListaEscribir = new List<string>() { };



            //string[] lines = { "First line", "Second line", "Third line" };
            //System.IO.File.WriteAllLines(@"c:\Respuestas.txt", lines);
        }
    }
}