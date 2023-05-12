using System.Diagnostics;
using GrowMark_Backend.Data;
using GrowMark_Backend.Models;
using GrowMark_Backend.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GrowMark_Backend.Controllers;

public class HomeController : Controller
{
    private readonly AppDbContext _context;

    public HomeController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        List<Slider> sliders = await _context.sliders.Where(m => !m.SoftDelete).ToListAsync();
        List<Features> features = await _context.features.Where(m => !m.SoftDelete).ToListAsync();
        List<Services> services = await _context.services.Where(m => !m.SoftDelete).ToListAsync();
        List<TeamMembers> teamMembers = await _context.teamMembers.Where(m => !m.SoftDelete).ToListAsync();
        List<ProjectDetails> projectDetails = await _context.projectDetails.Where(m => !m.SoftDelete).ToListAsync();

        HomeVM home = new()
        {
            sliders = sliders,
            features = features,
            services = services,
            teamMembers = teamMembers,
            projectDetails = projectDetails
        };
        return View(home);
    }
}

