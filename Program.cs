public class DateFunctions
{
    
	public  void DaysLeft(DateTime fromDate, DateTime toDate)
	{
        int days = (int)toDate.Subtract(fromDate).TotalDays;
        Console.WriteLine(days);
	}
    public static void Main()
    {
        DateFunctions men = new DateFunctions();
        men.DaysLeft( DateTime.Now.Date.AddDays(-1), DateTime.Now);
          
    }
}