using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homeworkk
{
    class Program
    {
        static void Main(string[] args)
        { 
        
        
    }


        public class Node<T>
        {
            public T Data { get; set; }
            public Node<T> Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        public class SinglyLinkedList<T>
        {
            private Node<T> head;

            public SinglyLinkedList()
            {
                head = null;
            }


            public void AddFirst(T data)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = head;
                head = newNode;
            }


            public void AddLast(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }

                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }


            public void AddAt(int index, T data)
            {
                if (index < 0) throw new ArgumentOutOfRangeException("index");

                if (index == 0)
                {
                    AddFirst(data);
                    return;
                }

                Node<T> newNode = new Node<T>(data);
                Node<T> current = head;

                for (int i = 0; i < index - 1; i++)
                {
                    if (current == null) throw new ArgumentOutOfRangeException("index");
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }


            public void RemoveFirst()
            {
                if (head == null) throw new InvalidOperationException("List is empty");
                head = head.Next;
            }


            public void RemoveLast()
            {
                if (head == null) throw new InvalidOperationException("List is empty");

                if (head.Next == null)
                {
                    head = null;
                    return;
                }

                Node<T> current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }

                current.Next = null;
            }


            public void PrintList()
            {
                Node<T> current = head;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }
    }
        }
    

