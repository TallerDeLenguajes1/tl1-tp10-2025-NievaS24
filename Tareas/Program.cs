using System.Text.Json;

//Creo una instancia Http
HttpClient client = new HttpClient();
//Enviar solicitud GET
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
//Verifico que la solicitud fue exitosa
response.EnsureSuccessStatusCode();
//Leo y deserealizo la respuesta
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
//Serealizo y guardo en tareas.json
string ruta = Directory.GetCurrentDirectory(); //Consigo la direccion de donde estoy trabajando, me devuelve dentro de bin
using (StreamWriter sw = new StreamWriter(ruta + @"\tarea.json"))
{
    string jsonString = JsonSerializer.Serialize(listTareas);
    sw.WriteLine(jsonString);
}