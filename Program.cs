internal class Program
{
	private static void Main(string[] args)
	{
		double openCollarRunningShirt = 41.00;

		double markDownPrice = openCollarRunningShirt * 0.15;
		double newPrice = openCollarRunningShirt - markDownPrice;

		Console.WriteLine("You will be saving {0:C}",markDownPrice);
		Console.WriteLine("The new price will be {0:C}", newPrice);

	}
}