namespace Calculator
{
    public class Computing
    {
        public string OddOrEvent(int number) => (number % 2 == 0) ? "even" : "odd";

        /// <summary>
        /// calculate age
        /// </summary>
        /// <param name="birthdayYear"></param>
        /// <param name="currentYear"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CalculateAge(int birthdayYear, int currentYear)
        {
            if(birthdayYear < 0)
                return 0;

            if (birthdayYear == 0 || currentYear == 0)
                throw new ArgumentException();

            return currentYear - birthdayYear;
        }
    }
}
