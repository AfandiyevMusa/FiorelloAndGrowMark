using System;
using GrowMark_Backend.Models;

namespace GrowMark_Backend.ViewModels
{
	public class MembersVM
	{
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Position { get; set; }
    }
}

