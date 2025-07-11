namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            WeekDays[] values = (WeekDays[])Enum.GetValues(typeof(WeekDays));
            foreach (WeekDays day in values)
            {
                Console.WriteLine(day);
            }
            #endregion
        }
    }
}
