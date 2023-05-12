using System;
using GrowMark_Backend.Models;

namespace GrowMark_Backend.ViewModels
{
	public class HomeVM
	{
        public List<Slider> sliders { get; set; }
        public List<Features> features { get; set; }
        public List<Services> services { get; set; }
        public IEnumerable<TeamMembers> teamMembers { get; set; }
        public IEnumerable<ProjectDetails> projectDetails { get; set; }
    }
}

