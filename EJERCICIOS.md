## Manejar archivos

```csharp

 Console.WriteLine("Escribe el nombre del archivo");
string fileName = Console.ReadLine();
string directoryName = "C:\\Users\\Brandon\\Desktop\\Archivos";

if (Directory.Exists(directoryName)){
    Console.WriteLine("Esta carpeta ya existe");
                
}
else
{
    Directory.CreateDirectory(directoryName);
    Console.WriteLine("Carpeta creada");
}
            
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
{
    Console.WriteLine("Ingresa el texto");
    string texto = Console.ReadLine();
    sw.WriteLine(texto);
    Console.WriteLine("Arhivo creado con el texto");
}

string textoLeido = File.ReadAllText(archivePath, Encoding.UTF8);
Console.WriteLine(textoLeido);

```