using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;
using ZamowieniaRestauracja.Factory;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace ZamowieniaRestauracja.Http;

public class OrderHttpClient
{
    private static OrderHttpClient? Instance;
    private HttpClient HttpClient;

    private OrderHttpClient()
    {
        HttpClient = new HttpClient();
        HttpClient.BaseAddress = new Uri("http://localhost:5066/");
        HttpClient.DefaultRequestHeaders.Accept.Clear();
        HttpClient.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
    }

    public static OrderHttpClient GetInstance()
    {
        Instance ??= new OrderHttpClient();
        return Instance;
    }

    public async Task<HttpStatusCode> PostOrderAsync(Order order)
    {
        Console.WriteLine(JsonSerializer.Serialize(order));
        HttpResponseMessage response = await HttpClient.PostAsJsonAsync("api/Order/add", order);
        response.EnsureSuccessStatusCode();
        return response.StatusCode;
    }

    public async Task<List<Order>?> GetAllOrdersAsync()
    {
        HttpResponseMessage response = await HttpClient.GetAsync("api/Order/getAll");
        response.EnsureSuccessStatusCode();

        string json = await response.Content.ReadAsStringAsync();
        try
        {
            List<Order>? orders = JsonConvert.DeserializeObject<List<Order>>(json);
            return orders;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Deserializacja nieudana: " + ex.Message);
            Console.WriteLine("Otrzymany JSON:");
            Console.WriteLine(json);
            return new List<Order>();
        }
    }
}