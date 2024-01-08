using CloudProjectTest.Models;
using System;
using System.Net.Http;
using System.Runtime.ConstrainedExecution;
using System.Text.Json;
using System.Threading.Tasks;

namespace CloudProjectTest.Service {
    public class WeatherTrentinoService {
        HttpClient client = new HttpClient();
        string url1 = "https://www.meteotrentino.it/protcivtn-meteo/api/front/localitaOpenData";
        string url2 = "https://www.meteotrentino.it/protcivtn-meteo/api/front/previsioneOpenDataLocalita?localita=";

        public async Task<List<City>> getCities() {
            HttpResponseMessage response = await client.GetAsync(url1);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            Cities cities = JsonSerializer.Deserialize<Cities>(responseBody) ?? new ();
            return cities.localita ?? new ();
        }

        public async Task<PrevisioneData> getCity(string city) {
            HttpResponseMessage response = await client.GetAsync(url2+city);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<PrevisioneData>(responseBody) ?? new ();
        }

        internal async Task<Giorni?> GetMeteo(string comune, int distanzaGiorni) {
            var previsioneData = await getCity(comune);
            var giorni = previsioneData.previsione[0].giorni;
            if (distanzaGiorni >= giorni.Length)
                return null;
            return giorni[distanzaGiorni];
        }
    }
}

