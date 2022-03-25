namespace ValoRats.ViewModels
{
	public class Lineup
	{
		public string? Title { get; set; } // B main to Market
		public List<Screenshot>? Screenshots { get; set; } // All ss
		public string? Description { get; set; } // Good for comboing with ult
		public string? Agent { get; set; } // Sova
		public string? Ability { get; set; } // Recon Dart/ Double Shock Dart
		public string? Type { get; set; } // Attack/ Defense/ Retake
		public int? Time { get; set; } // 14 seconds
		public string? Map { get; set; } // Icebox
		public string? Video { get; set; } // src file name
	}

	public class Screenshot
	{
	public string? Title { get; set; } // Setup, first arrow 
	public string? Description { get; set; } // Jump shot, 2 bar
	public string? Type { get; set; } // Setup, ss of map
	public string? Image { get; set; } // src file name

	}

}
