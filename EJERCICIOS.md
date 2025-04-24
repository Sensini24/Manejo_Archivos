## Manejar archivos

```csharp
Console.WriteLine("Escribe algo...");
string texto = Console.ReadLine();
string rutaCarpeta = "C:\\Users\\Brandon\\Desktop\\carpeta1";

//Exists sirve para verificar si un directorio o carpeta existe.
if(!Directory.Exists(rutaCarpeta))
{
    //CreateDirectory sirve para crear un directorio o carpeta.
    Directory.CreateDirectory(rutaCarpeta);
    Console.WriteLine("Carpeta creada.");

    //CreateText sirve para crear un archivo de texto.
    File.CreateText(rutaCarpeta + "\\archivo1.txt").Close();
    Console.WriteLine("Archivo creado.");

    File.WriteAllText(rutaCarpeta + "\\archivo1.txt", texto);
}
else
{
    Console.WriteLine("La carpeta ya existe.");
    File.CreateText(rutaCarpeta + "\\archivo1.txt").Close();
    Console.WriteLine("Archivo creado.");

    File.WriteAllText(rutaCarpeta + "\\archivo1.txt", texto);
}
```