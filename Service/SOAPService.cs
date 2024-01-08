using CloudProjectTest.Models;
using System.ServiceModel;

namespace CloudProjectTest.Service {
    [ServiceContract]
    public interface ISoapService {
        [OperationContract]
        public Task<Giorni?> GetMeteo(string comune, int distanzaGiorni);
    }

    public class SoapService : ISoapService {

        private WeatherTrentinoService _service;

        public SoapService() {
            this._service = new WeatherTrentinoService();
        }

        public async Task<Giorni?> GetMeteo(string comune, int distanzaGiorni) {
            return await this._service.GetMeteo(comune, distanzaGiorni);
        }
    }
}
