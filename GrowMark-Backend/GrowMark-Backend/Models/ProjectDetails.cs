using System;
namespace GrowMark_Backend.Models
{
	public class ProjectDetails:BaseEntity
	{
        public string Image { get; set; }
        public string Caption { get; set; }
        public string Detail { get; set; }
    }
}

