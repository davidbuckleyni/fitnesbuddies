
using AppManagerDL.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
 
namespace FitnessBuddiesDL {
    public class FitnessBuddiesClient {
        HttpClient _httpclient;


        public FitnessBuddiesClient() {
            _httpclient = new HttpClient();
        }

        public void GetAllBmiInformation() {
            _httpclient = new HttpClient();


        }

        /// <summary>
        /// Posts the stock take transaction.
        /// </summary>
        /// <param name="transfer">The transfer.</param>
        /// <returns>Task&lt;System.Int32&gt;.</returns>
        public async Task<List<BmiInformation>> GetBmiInfo(BmiInformation transfer) {
            List<BmiInformation> _result = new List<BmiInformation>();
            var uri = new Uri(string.Format(Constants.ApiUrl + Constants.BmiInforation, string.Empty));

            var response = await _httpclient.GetAsync(uri);
            if (response.IsSuccessStatusCode) {
                var byteArray = await response.Content.ReadAsByteArrayAsync();

                var content = Encoding.UTF8.GetString(byteArray, 0, byteArray.Length);
                _result = JsonConvert.DeserializeObject<List<BmiInformation>>(content);
            }
            return _result;
        }
        
        ///// <summary>
        ///// Posts the stock take transaction.
        ///// </summary>
        ///// <param name="transfer">The transfer.</param>
        ///// <returns>Task&lt;System.Int32&gt;.</returns>
        //public async Task<int> UpdateStockTakeTransaction(StockTakeTransaction transfer) {
        //    var uri = new Uri(string.Format(BaseUrl + Constants.UpdateStockTakeCountQuantity, string.Empty));


        //    var json = JsonConvert.SerializeObject(transfer);
        //    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

        //    // Do the actual request and await the response
        //    var httpResponse = await _client.PostAsync(BaseUrl + Constants.UpdateStockTakeCountQuantity, httpContent);

        //    return 1;



        //}


    }
}
