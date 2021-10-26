using PostSharpBlazorSyncfusionGrid.Aspects;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace PostSharpBlazorSyncfusionGrid.Services
{
  [AutoRetry]
  public class WeatherService
  {
    private int counter;
    private HttpClient httpClient;

    public WeatherService(HttpClient httpClient)
    {
      this.httpClient = httpClient;
    }

    public async Task<WeatherForecast[]> GetCurrentForecast()
    {
        // Fail every other request.
        if (++counter != 4)
      {
            throw new Exception("Service unavailable.");
      }

      return await this.httpClient.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
  }

  public class WeatherForecast
  {
    public DateTime Date
    {
      get; set;
    }

    public int TemperatureC
    {
      get; set;
    }

    public string Summary
    {
      get; set;
    }

    public int TemperatureF => 32 + (int) (TemperatureC / 0.5556);
  }
}
