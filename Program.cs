
using System;
using System.Text;
namespace Manejo_Archivos // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            try
=======
            Console.WriteLine("Escribe el nombre del archivo");
            string fileName = Console.ReadLine();
            string directoryName = "/home/brandon/Documentos/Archivos";

            if (Directory.Exists(directoryName))
            {
                Console.WriteLine("Esta carpeta ya existe");

            }
            else
>>>>>>> 8e29d57 (Cambiando)
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
<<<<<<< HEAD
            catch (Exception ex)
=======

            string archivePath = Path.Combine(directoryName, fileName);

            //Aqui se abre un manejador y no se cierra hasta que se le indique.
            //Además genera un objeto StreamWriter que permite escritura.
            //Close cierra la operación y manejador.
            //File.CreateText(archivePath).Close();
            //string texto = "Hola pinche putita hija de tu puta madre";
            //File.WriteAllText(archivePath, texto);
            //Console.WriteLine("Arhivo creado con el texto");


            //OTRA FORMA: Usar using como Dispose
            using (StreamWriter sw = File.CreateText(archivePath))
>>>>>>> 8e29d57 (Cambiando)
            {
                Console.WriteLine(ex);
            }
        }
    }
}