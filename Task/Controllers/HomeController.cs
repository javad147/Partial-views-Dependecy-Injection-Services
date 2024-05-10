using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Task.Data;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {

            SurpriseInfo surpriseInfo = await _context.SurpriseInfos.FirstOrDefaultAsync();

            List<SurpriseAdvantage> surpriseAdvantages = await _context.SurpriseAdvantages.ToListAsync();

            SurpriseVideo surpriseVideo = await _context.SurpriseVideos.FirstOrDefaultAsync();

            ExpertInfo expertInfo = await _context.ExpertInfos.FirstOrDefaultAsync();

            List<Specialist> specialists = await _context.Specialists.ToListAsync();

            List<Position> positions = await _context.Positions.ToListAsync();


            HomeVM model = new()
            {
                SurpriseInfo = surpriseInfo,
                SurpriseAdvantages = surpriseAdvantages,
                SurpriseVideo = surpriseVideo,
                ExpertInfo = expertInfo,
                Specialists = specialists,
                Positions = positions
            };



            return View(model);
        }
    }
}
