// See https://aka.ms/new-console-template for more information

using LinearDataStructuresAssignment;

var myList = new CustomLinkedList<int>();
myList.AddItem(1);
myList.AddItem(2);
myList.AddFirst(3);
myList.AddItem(4);
myList.AddItem(5);
myList.Remove(2);
Console.WriteLine(myList.Tail.Value);
Console.WriteLine(myList.Tail.PreviousNode.Value);
Console.WriteLine(myList.Head.Value);
Console.WriteLine(myList.Head.NextNode.Value);
Console.WriteLine();

var myStack = new CustomStack<int>();
myStack.Push(1);
myStack.Push(2);
myStack.Push(3);
myStack.Push(4);

Console.WriteLine(myStack.Pop());
Console.WriteLine(myStack.MyStack.Head.Value);
Console.WriteLine();

var myQueue = new CustomQueue<string>();
myQueue.Enqueue("Iruoma");
myQueue.Enqueue("Jaja");
myQueue.Enqueue("Suzy");
myQueue.Enqueue("Oshborn");
myQueue.Enqueue("Gideon");

Console.WriteLine(myQueue.Dequeue());
Console.WriteLine(myQueue.MyQueue.Head.Value);
Console.WriteLine(myQueue.Contains("Dozie"));
//myQueue.Clear();
//Console.WriteLine(myQueue.MyQueue.Head.Value);


