namespace GourmetGame
{
	public class Food
	{
		public Food()
		{
		}

		public Food(string foodName)
		{
			Name = foodName;
		}

		public string Name { get; set; } = string.Empty;
	}
}