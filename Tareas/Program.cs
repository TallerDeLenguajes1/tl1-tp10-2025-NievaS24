HttpClient client = new HttpClient();
HttpResponseMessage response = await client.GetAsync("https://jsonplaceholder.typicode.com/todos/");
response.EnsureSuccessStatusCode();
string responseBody = await response.Content.ReadAsStringAsync();
Console.WriteLine(responseBody); // Para ver si funciona la solicitud GET