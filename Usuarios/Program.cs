using System.ComponentModel.DataAnnotations;
using System.Text.Json;
HttpClient client = new HttpClient();
string url = "https://jsonplaceholder.typicode.com/users/";
HttpResponseMessage response = await client.GetAsync(url);
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
List<Usuario> usuarios = JsonSerializer.Deserialize<List<Usuario>>(responseBody);
Console.WriteLine("\n\n **** Primeros 5 usuarios ****\n\n");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Usuario {i + 1}:");
    Console.WriteLine($"Nombre: {usuarios[i].name}");
    Console.WriteLine($"Correo electronico: {usuarios[i].email}");
    Console.WriteLine($"Direccion:");
    Console.WriteLine($"\t {usuarios[i].address.suite}, {usuarios[i].address.street}, {usuarios[i].address.city}\n\n");
}