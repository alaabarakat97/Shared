namespace Dev
{
    internal class Program
    {
        static string[] ReverseArrayWay1(string[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len / 2; i++)
            {
                string temp = arr[i];
                arr[i] = arr[len - i - 1];
                arr[len - i - 1] = temp;
            }
            return arr;
        }
        static string[] ReverseArrayWay2(string[] arr)
        {
            int startIndex = 0;
            int endIndex = arr.Length - 1;

            while (startIndex < endIndex)
            {
                string temp = arr[startIndex];
                arr[startIndex] = arr[endIndex];
                arr[endIndex] = temp;
                startIndex++;
                endIndex--;
            }
            return arr;
        }
        static void Main(string[] args)
        {
            #region Way 1
            string[] words = { "a1", "a2", "a3", "a4", "a5" };
            int len = words.Length;
            // عكس ترتيب عناصر المصفوفة
            for (int i = 0; i < len / 2; i++)
            {
                string temp = words[i];
                words[i] = words[len - i - 1];
                words[len - i - 1] = temp;
            }
            // طباعة العناصر بعد عكس الترتيب
            for (int i = 0; i < len; i++)
            {
                Console.Write($"{words[i]} ");
            }
            Console.WriteLine("");
            #endregion

            #region Way 2

            string[] words2 = { "a1", "a2", "a3", "a4", "a5", "a6" };

            int startIndex = 0;
            int endIndex = words2.Length - 1;

            while (startIndex < endIndex)
            {
                string temp = words2[startIndex];
                words2[startIndex] = words2[endIndex];
                words2[endIndex] = temp;
                startIndex++;
                endIndex--;
            }

            foreach (var item in words2)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
            #endregion

            #region Function ReverseArrayWay1

            string[] arr = { "a1", "a2", "a3", "a4" };

            var result = ReverseArrayWay1(arr);

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"{result[i]} ");
            }
            Console.WriteLine("");
            #endregion

            #region Function ReverseArrayWay2

            string[] arr1 = { "a1", "a2", "a3", "a4" };

            var result2 = ReverseArrayWay2(arr1);

            for (int i = 0; i < result2.Length; i++)
            {
                Console.Write($"{result2[i]} ");
            }
            #endregion
        }
    }
}