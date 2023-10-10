using System.Text.Json;
using USUARIOS1;

internal class Program
{
    private static void Main(string[] args)
    {
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        path += @"\MOCK_DATA.json";
        string jsonString = File.ReadAllText(path);


        // Lee el contenido del archivo JSON en una cadena

        // Deserializa la cadena JSON en una lista de objetos de tipo Usuario
        List<Usuario> listaUsuarios = JsonSerializer.Deserialize<List<Usuario>>(jsonString);

        // Accede a los objetos
        foreach (var usuario in listaUsuarios)
        {
            Console.WriteLine($"Apellido: {usuario.apellido}");
            Console.WriteLine($"Nombre: {usuario.nombre}");
            Console.WriteLine($"Legajo: {usuario.legajo}");
            Console.WriteLine($"Correo: {usuario.correo}");
            Console.WriteLine($"Clave: {usuario.clave}");
            Console.WriteLine($"Perfil: {usuario.perfil}");
            Console.WriteLine();
        }

    }
}