// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Runtime.CompilerServices;
using Humanizer;
Console.WriteLine("Opciones a elegir");
Console.WriteLine("1.- BuscaErrores");
Console.WriteLine("2.- S3");
var Opcion = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese nombre de aplicacion");
var Proyecto = Console.ReadLine();
var Tabla=Proyecto.Replace(" ","-");
//BuscaErrores
if(Opcion==1)
{
Console.WriteLine("Ingrese IP");
var IP = Console.ReadLine();
Console.WriteLine("Ruta de Log");
var Rutalog = Console.ReadLine();
Console.WriteLine("Ingrese los Errores separados por *");
var Errores = Console.ReadLine();
Console.WriteLine("Verifique los datos Y/N");
Console.WriteLine($"Aplicacion: {Tabla}. IP a Monitorear {IP}. Rutalog: {Rutalog}. Errores a Contemplar {Errores}");
var Validacion =Console.ReadLine();
if(Validacion=="y" || Validacion=="Y")
{
//Se espera poder insertar la informacion en una BD, esto sera con proximas clases.
}
else
{
Console.WriteLine("Vuelve a correr el proyecto");
}
}
//S3
else if (Opcion==2)
{
Console.WriteLine("Ingrese el nombre del bucket:");
var bucket = Console.ReadLine();
Console.WriteLine("Ingrese la ruta:");
var ruta = Console.ReadLine();
Console.WriteLine("Verifique los datos Y/N");
Console.WriteLine($"Aplicacion: {Tabla}. Rutalog: {bucket}/{ruta}");
var Validacion =Console.ReadLine();
if(Validacion=="y" || Validacion=="Y")
{
//Se espera poder insertar la informacion en una BD, esto sera con proximas clases.
}
else
{
Console.WriteLine("Vuelve a correr el proyecto");
}
}

