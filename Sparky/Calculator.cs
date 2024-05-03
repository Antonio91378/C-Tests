namespace Sparky
{
    public class Calculator
    {
        public List<int> NumberRange = new();

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public bool IsOddNumber(int a)
        {
            return a % 2 != 0;
        }

        public double AddNumbersDouble(double a, double b)
        {
            return a + b;
        }

        public List<int> GetOddRange(int min, int max)
        {
            NumberRange.Clear();
            for (int i = min; i <= max; i++)
            { 
                bool isOdd = (i % 2 != 0);
                if(isOdd)
                {
                    NumberRange.Add(i);
                }
            }
            return NumberRange;
        }


    }
}