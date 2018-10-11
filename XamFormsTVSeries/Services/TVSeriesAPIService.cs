using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XamFormsTVSeries.Models;

namespace XamFormsTVSeries.Services
{
    public class TVSeriesAPIService : ITVSeriesAPIService
    {
        private const string TVshowDns = "http://api-public.guidebox.com/v2/";
        private const string APIKey = "?api_key=YOUR_API_KEY";
        private const string ShowEndPoint = "shows";
        private const string EpisodesEndPoint = "episodes";

        public async Task<TVShowsApiData<Show>> GetShowsAsync()
        {
            var result = await this.MakeHttpCall<TVShowsApiData<Show>>(ShowEndPoint);
            return result.Data;
        }

        async Task<TVShowsApiData<Episode>> ITVSeriesAPIService.GetEpisodesFromShow(string id)
        {
            string endPoint = $"{ShowEndPoint}/{id}/{EpisodesEndPoint}";
            var result = await this.MakeHttpCall<TVShowsApiData<Episode>>(endPoint);
            return result.Data;
        }

        async Task<TVShowsApiData<Show>> ITVSeriesAPIService.GetShowByIdAsync(string id)
        {
            string endPoint = $"{ShowEndPoint}/{id}";
            var result = await this.MakeHttpCall<TVShowsApiData<Show>>(endPoint);
            return result.Data;
        }

        #region MakeHttpCall

        private async Task<TOutput> MakeHttpCall<TOutput>(string endPoint)
        {

            HttpClient client = new HttpClient();

            string url = $"{TVshowDns}{endPoint}{APIKey}";


            HttpResponseMessage response = new HttpResponseMessage();
            try
            {

                response = await client.GetAsync(url);

                string responseText = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<TOutput>(responseText);
                }
                else
                {
                    throw new Exception(string.Format("Response Statuscode for {0}: {1}", url, response.StatusCode));
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        #endregion
    }
}
