using System;
using System.Threading.Tasks;
using XamFormsTVSeries.Models;

namespace XamFormsTVSeries.Services
{
    public interface ITVSeriesAPIService
    {
        Task<TVShowsApiData<Show>> GetShowsAsync();
        Task<Show> GetShowByIdAsync(int id);
        Task<TVShowsApiData<Episode>> GetEpisodesFromShow(int id);
    }
}
