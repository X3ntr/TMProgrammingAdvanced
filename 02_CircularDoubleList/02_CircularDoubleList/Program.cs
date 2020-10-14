using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_CircularDoubleList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList list = new DoubleLinkedList();

            string[] input = Console.ReadLine().Split();
            while(input[0] != "exit")
            {
                switch (input[0])
                {
                    case "insert":
                        list.Insert(input[1]);
                        break;
                    case "moveBackward":
                        list.MoveBackward(Convert.ToInt32(input[1]));
                        break;
                    case "moveForward":
                        list.MoveForward(Convert.ToInt32(input[1]));
                        break;
                    case "print":
                        list.Print();
                        break;
                    case "delete":
                        list.Delete();
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }

    public class Node
    {
        public string Data { get; set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public Node(string data)
        {
            this.Data = data;
            this.Next = null;
            this.Previous = null;
        }
    }

    public class DoubleLinkedList
    {
        private static Node Current;

        public DoubleLinkedList()
        {
            Current = null;
        }

        public void Insert(string data)
        {
            Node node = new Node(data);

            if(Current == null)
            {
                node.Next = node;
                node.Previous = node;
            }
            else
            {
                node.Next = Current;
                node.Previous = Current.Previous;
                Current.Previous.Next = node;
                Current.Previous = node;
            }           
            Current = node;
        }

        public void Delete()
        {
            //check for null
            if (Current != null)
            {
                //check if not single node
                if(Current.Next != Current && Current.Previous != Current)
                {
                    //previous becomes current
                    Current.Next.Previous = Current.Previous;
                    Current.Previous.Next = Current.Next;
                    Current = Current.Next;
                }
                else
                {
                    Current = null;
                }
            }
        }

        public void MoveForward(int places)
        {
            for(int i = 0; i < places; i++)
            {
                Current = Current.Next;
            }
        }

        public void MoveBackward(int places)
        {
            for (int i = 0; i < places; i++)
            {
                Current = Current.Previous;
            }
        }

        public void Print()
        {
            if (Current != null)
            {
                Node temp = Current;

                while (temp.Next != Current)
                {
                    Console.Write(temp.Data + " ");
                    temp = temp.Next;
                }
                Console.Write(temp.Data + "\n");
            }
        }
    }
}
