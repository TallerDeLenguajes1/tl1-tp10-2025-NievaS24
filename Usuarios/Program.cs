using System.ComponentModel.DataAnnotations;
using System.Text.Json;
HttpClient client = new HttpClient();
string url = "https://jsonplaceholder.typicode.com/users/";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
System.Console.WriteLine("\n\n **** Primeros 5 usuarios ****\n\n");
for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine($"Usuario {i + 1}:");
    System.Console.WriteLine($"Nombre: {usuarios[i].name}");
    System.Console.WriteLine($"Correo electronico: {usuarios[i].email}");
    System.Console.WriteLine($"Direccion:");
    System.Console.WriteLine($"\t {usuarios[i].address.suite}, {usuarios[i].address.street}, {usuarios[i].address.city}\n\n");
}