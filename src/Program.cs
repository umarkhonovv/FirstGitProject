namespace ModulFirstPr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text :");
            var text = Console.ReadLine();

            var newText = "";
            if (text[0] == ' ')
            {
                text.Remove(0, 1);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ' && text[i + 1] == ' ')
                {
                    text.Remove(i, 1);
                }
                else
                {
                    newText += text[i];
                }
            }
            Console.WriteLine(newText);

        }
    }
}
