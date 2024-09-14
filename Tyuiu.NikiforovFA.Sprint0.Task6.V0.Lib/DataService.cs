namespace Tyuiu.NikiforovFA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        // Обычный for
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            return total;
        }
        // Обычный while
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total -= numbers[index];
                index++;// Увеличивает на 1 index
            }
            return total;
        }
        // While только условие после, что даст циклу минимум 1 прогон
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total *= numbers[index];
                index++;
            }
            while (index < numbers.Length);

            return total;
        }

    }
}
