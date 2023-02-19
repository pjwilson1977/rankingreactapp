using System;
namespace RankingReactApp.Models
{
	public class ItemModel
	{
        // https://www.youtube.com/watch?v=4RKuyp_bOhY
        public int Id { get; set; }

		public string Title { get; set; }

		public int ImageId { get; set; }

		public int Ranking { get; set; }

		public int ItemType { get; set; }
		
	}
}

