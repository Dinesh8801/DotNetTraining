namespace CSharpAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to check Palindrome: ");
            string input = Console.ReadLine();

            if (PalindromeChecker.IsPalindrome(input))
                Console.WriteLine("The string is a palindrome.");
            else
                Console.WriteLine("The string is not a palindrome.");

            Console.Write("Enter the number of Fibonacci terms: ");
            int n = int.Parse(Console.ReadLine());

            FibonacciGenerator.PrintFibonacci(n);

            Console.Write("Enter a number to calculate factorial: ");
            int num = int.Parse(Console.ReadLine());

            int result = FactorialCalculator.CalculateFactorial(n);
            Console.WriteLine($"Factorial of {num} is {result}");

            int[] arr = { 1, 3, 5, 7, 9, 11, 13 };
            Console.Write("Enter a number to search: ");
            int target = int.Parse(Console.ReadLine());

            int searchIndex = BinarySearch.Search(arr, target);
            if (searchIndex != -1)
                Console.WriteLine($"Element found at index {searchIndex}");
            else
                Console.WriteLine("Element not found");

            Console.Write("Enter a number to reverse: ");
            int number = int.Parse(Console.ReadLine());

            int reversedNumber = NumberReverser.ReverseNumber(number);
            Console.WriteLine($"Reversed number: {reversedNumber}");

            Console.Write("Enter a string to remove duplicates: ");
            string inputString = Console.ReadLine();

            string resultString = StringProcessor.RemoveDuplicateCharacters(inputString);
            Console.WriteLine($"String after removing duplicates: {resultString}");
        }
    }
}
