using System;

namespace CustomBinaryTree
{
    public class CustomBinaryTreeImplementation
    {
        static void Main(string[] args)
        {
            var numbers = new CustomBinaryTree<int>();
            numbers.Add(0);
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            
            numbers.Print();
            
            CustomBinaryTreeNode<int> node = numbers.Search(2);
            
            Console.WriteLine(node.Data);
            
            numbers.Delete(3);
            
            numbers.Print();
        }
    }
}