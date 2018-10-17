using System;
using System.Threading.Tasks;
using XamFormsTVSeries.Models;

namespace XamFormsTVSeries.Services
{
    public interface ITVSeriesAPIService
    {
        Task<TVShowsApiData<Show>> GetShowsAsync();
        Task<Show> GetShowByIdAsync(string id);
        Task<TVShowsApiData<Episode>> GetEpisodesFromShow(string id);
    }
}
