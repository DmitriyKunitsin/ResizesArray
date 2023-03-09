namespace Resizes
{
    internal class Program
    {
        static void Resize(ref int[] newMyArray,int sizeLength)
        {
            Random rnd = new Random();
            int[] newArray = new int [sizeLength];
            for (int i = 0; i < newMyArray.Length && i > sizeLength; i++) 
            {
                newArray[i] = newMyArray[i];
            }
            for (int i = 0;i < newArray.Length; i++)
            {
                newArray[i] = rnd.Next(10,200);
            }
            newMyArray= newArray;
        }
        static void Main(string[] args)
        {
            Random RND= new Random();
            int[] myArray = new int[RND.Next(3, 7)];
            Console.WriteLine("длина созданного массива = " + myArray.Length);
            Console.Write("Желаемая длина массива : ");
            int sizeArray = int.Parse(Console.ReadLine()); // желаемая длина массива
            Resize(ref myArray, sizeArray);
            int index = 0;
            foreach (int i in myArray) 
            {
                Console.WriteLine($"индекс {index++} равен  " + i); 
            }
            Console.WriteLine("Новый массив длиной  : "+myArray.Length);
        }
    }
}