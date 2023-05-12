using System;
namespace GrowMark_Backend.Models
{
	public class TeamMembers:BaseEntity
	{
		public string Image { get; set; }
		public string FullName { get; set; }
		public string Position { get; set; }
	}
}

