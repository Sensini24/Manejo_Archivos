
using System;
using System.Reflection.PortableExecutable;
using System.Text;
namespace Manejo_Archivos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                
                string rutaLectura = "C:\\Users\\Brandon\\Desktop\\Archivos\\hola.txt";
                string rutaEscritura = "C:\\Users\\Brandon\\Desktop\\Archivos\\holaCopia.txt";
                using (MemoryStream ms = new MemoryStream())
                {
                    byte[] datosTexto = File.ReadAllBytes(rutaLectura);
                    ms.Write(datosTexto, 0, datosTexto.Length);
                    ms.Position = 0;

                    using (StreamReader sr = new StreamReader(ms))
                    {
                        string textLeido = sr.ReadToEnd();

                        using (MemoryStream ms2 = new MemoryStream())
                        {

                            using(StreamWriter sw = new StreamWriter(ms2, Encoding.UTF8, 1024, true))
                            {
                                sw.Write(textLeido);
                                sw.WriteLine("\nArhivo Copiado y editado");
                            }

                            ms2.Position = 0;

                            using(FileStream fs = new FileStream(rutaEscritura, FileMode.Create, FileAccess.Write))
                            {
                                ms2.CopyTo(fs);
                            }
                        }
                    }
                    
                }
                







                //using (MemoryStream ms = new MemoryStream())
                //{
                //    string texto = "Muchachos de bien, oid mi canto gregoriano.";
                //    byte[] textoBytes = Encoding.UTF8.GetBytes(texto);

                //    ms.Write(textoBytes, 0, textoBytes.Length);

                //    ms.Position = 0;

                //    byte[] datosCompletos = ms.ToArray();
                //    Console.WriteLine($"Tamaño total: {datosCompletos.Length} bytes");
                //    using (StreamReader sr = new StreamReader(ms))
                //    {
                //        Console.WriteLine($"\nTexto completo: {sr.ReadToEnd()}");
                //    }
                //    using (StreamWriter sw = File.CreateText(rutaEscritura))
                //    {
                //        sw.WriteLine(texto);
                //    }

                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}