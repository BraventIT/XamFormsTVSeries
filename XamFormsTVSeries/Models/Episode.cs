using System;
using System.Collections.Generic;

namespace XamFormsTVSeries.Models
{
    public class Episode
    {
		public int id { get; set; }
		public int tvdb { get; set; }
		public string content_type { get; set; }
		public int is_shadow { get; set; }
		public List<object> alternate_tvdb { get; set; }
		public string imdb_id { get; set; }
		public int themoviedb { get; set; }
		public int show_id { get; set; }
		public int season_number { get; set; }
		public int episode_number { get; set; }
		public int special { get; set; }
		public string first_aired { get; set; }
		public string title { get; set; }
		public string original_title { get; set; }
		public List<object> alternate_titles { get; set; }
		public string overview { get; set; }
		public int? duration { get; set; }
		public string production_code { get; set; }
		public string thumbnail_208x117 { get; set; }
		public string thumbnail_304x171 { get; set; }
		public string thumbnail_400x225 { get; set; }
		public string thumbnail_608x342 { get; set; }
    }
}
