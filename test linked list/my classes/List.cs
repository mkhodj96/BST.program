using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_linked_list.NewFolder1
{
    class List
    {
        private ListNode firstnode;
        private ListNode lastnode;
        private string name;


        
        public List()
        {
            name = "list";
            firstnode = lastnode = null;

        }
       

        public bool IsEmpty()
        {
            lock (this)
            {
                return firstnode == null;
            }
        }


        public void InsertAtFront(object insertItem)
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    firstnode = lastnode = new ListNode(insertItem);
                }
                else {

                    firstnode = new ListNode(insertItem, firstnode);
                }
            }
        }

        public void InsertAtBack(object insertItem)
        {
            lock (this)
            {
                if (IsEmpty())
                { firstnode = lastnode = new ListNode(insertItem); }
                else { lastnode = lastnode.Next = new ListNode(insertItem); }

            }
        }


       
        public object RemoveFromFront()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    Console.Write("list is empty");
                   
                }
                object removeItem = firstnode.Data;

                if (firstnode == lastnode)
                {
                    firstnode = lastnode = null;
                }
                else
                {
                    firstnode = firstnode.Next;

                }
                return removeItem;



            }



        }

        public object RemoveFromBack()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    
                    Console.Write("the list is empty");
                }
                object removeItem = lastnode.Data;

                if (firstnode == lastnode)
                {
                    firstnode = lastnode = null;
                }
                else
                {
                    ListNode current = firstnode;
                    while (current.Next != lastnode)
                    {
                        current = current.Next;
                    }

                    lastnode = current;
                    current.Next = null;
                }
                return removeItem;

            }
        }

        virtual public void print()
        {
            lock (this)
            {
                if (IsEmpty())
                {
                    Console.WriteLine("Empty " + name);
                    return;
                }
                Console.Write("The " + name + " is: ");
                ListNode current = firstnode;

                while (current != null)
                {
                    Console.Write(current.Data + "  ");
                    current = current.Next;
                }
                Console.WriteLine("\n");
            }
        }


        public object getdata()
        {
            return firstnode.Data;
        }

        public void nextnode()
        {
            firstnode = firstnode.Next;
        }












    }
}
