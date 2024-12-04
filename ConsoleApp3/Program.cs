namespace ConsoleApp3
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public override string ToString()
        {
            return year + "/" + month + "/" + day;
        }
/*        public int year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }
        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }
*/
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Date datum = new Date(2024, 12, 01);
            Console.WriteLine(datum.ToString());

        }
    }
}
