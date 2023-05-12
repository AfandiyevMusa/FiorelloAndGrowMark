using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrowMark_Backend.Data;
using GrowMark_Backend.Models;
using GrowMark_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowMark_Backend.Controllers
{
    public class ProjectDetailController : Controller
    {
        private readonly AppDbContext _context;

        public ProjectDetailController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(int? id)
        {
            ProjectDetails projectDetails = await _context.projectDetails.Where(m => !m.SoftDelete).FirstOrDefaultAsync(p => p.Id == id);

            ProjectDetailVM project = new ()
            {
                Id = projectDetails.Id,
                Image = projectDetails.Image,
                Caption = projectDetails.Caption,
                Detail = projectDetails.Detail
            };

            return View(project);
        }
    }
}

