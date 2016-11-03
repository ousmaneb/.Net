/*
Objective:
Given the linked list class defined below, write a function to reverse the list. 

Restrictions:
None

Signature:
public static void Reverse(List input)

public class List 
{ 
     public Node Head { get; set; } 
} 
public class Node 
{ 
     public object Value { get; set; } 
     public Node Next { get; set; } 
} 
*/

public static void Main(string[] args)
	{
	Console.WriteLine("Enter a limit number to find the Fibonacci: ");
	int number = Convert.ToInt32(Console.ReadLine());

	Fibonacci(0, 1, 1, number);
	Console.WriteLine();
	}

	public static void Reverse(List input)
	{

	}