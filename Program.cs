
namespace Test_12_4_25
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int x = 5;




            #region //Q1 Pattern Print
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            ////int num = 1;
            //for (int i = 1; i <= 4; i++)
            //{

            //    for (int j = 1; j <= i; j++)
            //        Console.Write(j);

            //    for (int k = i - 1; k >= 1; k--)
            //        Console.Write(k);

            //    Console.WriteLine();
            //}
            #endregion

            #region//Q2 Series Print
            //Console.WriteLine("Enter the number");
            //int num = int.Parse(Console.ReadLine());
            //{
            //    //int num = 1;
            //    for (int i = 0; i <= 3; i++)
            //    {
            //        Console.Write(num + ",");
            //        num = (num * 10) + 1;//10*11=110+1=111,     111*10=1110+1=1111
            //    }
            //}
            #endregion

            #region  //Q5
            //   // int[] arr = { 1, 2, 2, 3, 4, 2, 5 };
            //Console.Write("Enter the number of Elements: ");
            //int array = int.Parse(Console.ReadLine());

            //int[] arr = new int[array];

            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write("number " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int find = 2;
            //int count = 0;

            //foreach (int num in arr)
            //{
            //    if (num == find)
            //        count++;
            //}
            //Console.WriteLine("Frequency: " + count);


            #endregion


            #region//Q6

            //  Console.Write("Enter the number of Elements: ");
            //  int array = int.Parse(Console.ReadLine());

            //  int[] arr = new int[array];

            //  Console.WriteLine("Enter the Numbers:");
            //  for (int i = 0; i < array; i++)
            //  {
            //      Console.Write("number " + (i + 1) + ": ");
            //      arr[i] = int.Parse(Console.ReadLine());
            //  }
            //////  int[] arr = { 10, 20, 40, 30, 50 };
            //  int largest = int.MinValue;
            //  int secondLargest = int.MinValue;

            //  for (int i = 0; i < arr.Length; i++)
            //  {
            //      if (arr[i] > largest)
            //      {
            //          secondLargest = largest;
            //          largest = arr[i];
            //      }
            //      else if (arr[i] > secondLargest && arr[i] != largest)
            //      {
            //          secondLargest = arr[i];
            //      }
            //  }
            //  Console.WriteLine("Largest: " + largest);
            //  Console.WriteLine("Second largest: " + secondLargest);




            #endregion



            #region //Q9
            //Console.Write("Enter the number of Elements: ");
            //int array = int.Parse(Console.ReadLine());

            //int[] arr = new int[array];

            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write("number " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //// int[] arr = { 1, 2, 3, 2, 1 };
            //bool isPalindrome = true;

            //for (int i = 0; i < arr.Length / 2; i++)
            //{
            //    if (arr[i] != arr[arr.Length - 1 - i])
            //        isPalindrome = false;
            //}
            //Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");

            #endregion

            #region   //Q10
            //Console.Write("Enter the number of Elements: ");
            //int array = int.Parse(Console.ReadLine());

            //int[] arr = new int[array];
            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write("number " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            ////  int[] arr = { 1, 2, 3, 4, 5, 1, 3 };
            //HashSet<int> seen = new HashSet<int>();
            //HashSet<int> duplicates = new HashSet<int>();

            //foreach (int num in arr)
            //{
            //    if (!seen.Add(num))
            //        duplicates.Add(num);
            //}

            //foreach (int d in duplicates)
            //    Console.WriteLine(d + " ");
            #endregion

            #region  //Q11
            //Console.Write("Enter the number of Elements: ");
            //int array = int.Parse(Console.ReadLine());

            //int[] arr = new int[array];
            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write("number " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int num1 = x * (x + 1) / 2;
            //int num2 = arr.Sum();

            //Console.WriteLine("Missing: " + (num1 - num2));

            #endregion


            #region //Q12

            //Console.Write("Enter the Sentence: ");
            //string array = Console.ReadLine();


            //string[] s1 = { "" };
            //bool isPalindrome = true;

            //for (int i = 0; i < s1.Length / 2; i++)
            //{
            //    if (s1[i] != s1[s1.Length - 1 - i])
            //        isPalindrome = false;
            //}
            //Console.WriteLine(isPalindrome ? "Palindrome" : "Not Palindrome");
            //#endregion


            #region   //Q13

            //Console.Write("Enter the Sentence: ");
            //string arr = Console.ReadLine();
            ////string sentence = "hello world hi jacob";
            //string[] words = arr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //Console.WriteLine("Word Count: " + words.Length);
            #endregion

            //Q15
            #region
            // //string s = "hello";

            //Console.WriteLine("Enter the Word");
            //string s = Console.ReadLine();
            //string updated = s.Replace('o', 'x');

            //Console.WriteLine(updated);
            #endregion



            //Q16

            #region
            //Console.Write("Enter the number of Elements: ");
            //int array = int.Parse(Console.ReadLine());

            //int[] arr = new int[array];

            //Console.WriteLine("Enter the Numbers:");
            //for (int i = 0; i < array; i++)
            //{
            //    Console.Write("number " + (i + 1) + ": ");
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int target = 6;


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    for (int j = i + 1; j < arr.Length; j++)
            //    {
            //        if (arr[i] + arr[j] == target)
            //            Console.WriteLine("(" + arr[i] + "," + arr[j] + ")");
            //    }
            //}
            #endregion


            //Q20
            #region
            //Console.WriteLine("Enter the Word");
            //string s1 = Console.ReadLine();


            ////string input = "hello";
            //string vowels = "aeiouAEIOU";
            //string result = new string(s1.Where(c => vowels.Contains(c)).ToArray());

            //Console.WriteLine(result);
            #endregion



        }
    }
}
       
   


    



   

    



    
    


