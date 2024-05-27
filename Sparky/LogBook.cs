namespace Sparky
{
    public interface ILogBook
    {
        void Message(string message);
        bool LogToDb(string message);
        bool LogBalanceAfterWithDraw(int balance);
    }
    public class LogBook : ILogBook
    {
        public bool LogBalanceAfterWithDraw(int balance)
        {
            Console.WriteLine(balance);
            if (balance >= 0)
            {
                Console.WriteLine("Success!");
                return true;
            }
            else
            {
                Console.WriteLine("Failure!");
                 return false;
            }
        }

        public bool LogToDb(string message)
        {
            Console.WriteLine(message);
            return true;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }
    }
}
