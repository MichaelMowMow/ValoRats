using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ValoRats.Models;
using ValoRats.ViewModels;

namespace ValoRats.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		public IActionResult Lineups()
		{
			Screenshot ascentSetup = new() {
				Title = "Setup for ascentRecon",
				Type = "Setup",
				Description = "Stand in this corner",
				Image = "~/Images/Ascent-Recon-Attack-SpawntoBFake-Setup.png"
			};
			Screenshot ascentLineup = new()
			{
				Title = "Lineup for ascentRecon",
				Type = "Lineup",
				Description = "Look at crack in bench",
				Image = "ValoRats/Images/Ascent-Recon-Attack-SpawntoBFake-Lineup.png"
			};
			Screenshot ascentFinish = new()
			{
				Title = "Finish for ascentRecon",
				Type = "Finish",
				Description = "Lands by default",
				Image = "ValoRats/Images/Ascent-Recon-Attack-SpawntoBFake-Finish.png"
			};

			Lineup ascentRecon = new()
			{
				Agent = "Sova",
				Ability = "Recon",
				Screenshots = new List<Screenshot> { ascentSetup, ascentLineup, ascentFinish },
				Description = "Good fake arrow to B site from spawn",
				Map = "Ascent",
				Time = 7,
				Title = "Fake B recon from spawn",
				Type = "Recon Dart",
			};

			List<Lineup> vm = new() { ascentRecon };
			return View(vm);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}