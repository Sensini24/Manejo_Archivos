
using System;
using System.Text;
namespace Manejo_Archivos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string rutaArchivoGrande = "/home/brandon/Descargas/Grabación de la reunión.mp4";
                string destinoPath = "/home/brandon/Documentos/Grabación de la reunión.mp4";

                using (FileStream nuevoVideo = File.Create(destinoPath))

                using (FileStream inputStream = new FileStream(rutaArchivoGrande, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[4096];
                    int bytes;
                    int totalBytes = 0;
                    while ((bytes = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        totalBytes += bytes;
                        nuevoVideo.Write(buffer, 0, bytes);
                        // Console.WriteLine($"Numero de bytes leidos: {bytes}");
                    }
                    Console.WriteLine($"Total de bytes leidos: {totalBytes}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}