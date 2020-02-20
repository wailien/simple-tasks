using System;

namespace CustomLinkedList
{
    public class CustomLinkedListImplementation
    {
        static void Main(string[] args)
        {
            var numbers = new CustomLinkedList<int>();
            numbers.AddLast(0);
            numbers.AddLast(1);
            numbers.AddLast(2);
            numbers.AddLast(3);
            numbers.AddLast(4);
            
            Print(numbers);
            
            numbers.RemoveLast();
            
            Print(numbers);
            
            numbers.ReverseList();
            
            Print(numbers);
            
        }

        public static void Print(CustomLinkedList<int> customLinkedList)
        {
            foreach (var num in customLinkedList)
            {
                Console.WriteLine(num);
            }
        }
    }
}