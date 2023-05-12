using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowMark_Backend.Data;
using GrowMark_Backend.Models;
using GrowMark_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrowMark_Backend.Controllers
{
    public class MemberController : Controller
    {
        private readonly AppDbContext _context;

        public MemberController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            TeamMembers teamMembers = await _context.teamMembers.Where(m => !m.SoftDelete).FirstOrDefaultAsync(p => p.Id == id);

            MembersVM member = new MembersVM()
            {
                Id = teamMembers.Id,
                Image = teamMembers.Image,
                FullName = teamMembers.FullName,
                Position = teamMembers.Position
            };

            return View(member);
        }
    }
}

