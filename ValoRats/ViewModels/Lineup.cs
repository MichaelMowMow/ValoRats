namespace ValoRats.ViewModels
{
	public class Lineup
	{
		public string? Agent { get; set; }
		List<Screenshot>? Screenshots { get; set; }
	}

	class Screenshot
	{
	public string? Title { get; set; }
	public string? Description { get; set; }
	public string? Type { get; set; }
	public string? Image { get; set; }

	}

}
