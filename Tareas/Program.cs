using System.Text.Json;

HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
List<Tarea> listTareas = JsonSerializer.Deserialize<List<Tarea>>(responseBody);
//Muestro primero pendientes, luego completadas.
foreach (Tarea tarea in listTareas)
{
    if (!tarea.completed) 
    {
        Console.WriteLine($"\nTitulo: {tarea.title}");
        Console.WriteLine($"Estado: Pendiente");
    }
}
foreach (Tarea tarea in listTareas)
{
    if (tarea.completed)
    {
        Console.WriteLine($"\nTitulo: {tarea.title}");
        Console.WriteLine($"Estado: Completada");
    } 
}