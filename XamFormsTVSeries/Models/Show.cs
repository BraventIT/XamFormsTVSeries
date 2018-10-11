using System;
using System.Collections.Generic;

namespace XamFormsTVSeries.Models
{
	public class Show
	{
		public int id { get; set; }
		public string title { get; set; }
		public List<string> alternate_titles { get; set; }
		public string status { get; set; }
		public string type { get; set; }
		public int container_show { get; set; }
		public string first_aired { get; set; }
		public string network { get; set; }
		public List<Channel> channels { get; set; }
		public int runtime { get; set; }
		public List<Genre> genres { get; set; }
		public List<Tag> tags { get; set; }
		public List<Cast> cast { get; set; }
		public string overview { get; set; }
		public string air_day_of_week { get; set; }
		public string air_time { get; set; }
		public string rating { get; set; }
		public string imdb_id { get; set; }
		public int tvdb { get; set; }
		public int themoviedb { get; set; }
		public object freebase { get; set; }
		public string tv_com { get; set; }
		public string metacritic { get; set; }
		public string common_sense_media { get; set; }
		public int? wikipedia_id { get; set; }
		public TVRage tvrage { get; set; }
		public Social social { get; set; }
		public string fanart { get; set; }
		public string poster { get; set; }
		public string banner { get; set; }
		public string artwork_208x117 { get; set; }
		public string artwork_304x171 { get; set; }
		public string artwork_448x252 { get; set; }
		public string artwork_608x342 { get; set; }
		public string url { get; set; }
	}
}
