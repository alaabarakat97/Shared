namespace Dev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Dev 1
            //Way 1
            string[] words = { "a1", "a2", "a3", "a4", "a5" };
            int len= words.Length;
            // عكس ترتيب عناصر المصفوفة
            for (int i = 0; i < len/2; i++) 
            {
                string temp = words[i];
                words[i] = words[len-i-1];
                words[len-i-1] = temp;
            }
            // طباعة العناصر بعد عكس الترتيب
            for (int i = 0;i < len; i++) 
            {
                Console.Write($"{words[i]} ");
            }
            #endregion

        }
    }
}