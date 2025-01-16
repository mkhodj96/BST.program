using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_linked_list.NewFolder1;

namespace test_linked_list
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data structure project!");
            Console.WriteLine("Hi! This is programe for Binary Search Trees (BST).");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please Choose Your Node Type,For INT Type enter<0> & For STRING Type enter<1>");
            int i = Int32.Parse(Console.ReadLine());

            if (i == 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
             

                #region program
                List list = new List();

                Console.WriteLine("\n\nHow many nodes do you want to enter??!");
                int k = Int32.Parse(Console.ReadLine());
                int j =k;
                for (; k > 0; k--)
                {
                    Console.WriteLine("\nWrite Your Node Please: ");
                    list.InsertAtBack(Console.ReadLine().ToString());
                }

                k = j;
                Console.WriteLine("\n");
                list.print();


                Tree tree = new Tree();
                populatetree1(list, tree, "BST",k);
                traversal(tree, "BST");



                Console.ReadKey();
#endregion
            }
            else if(i==1)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                #region program
                List list = new List();

                Console.WriteLine("\n\nHow many nodes do you want to enter??!");
                int k = Int32.Parse(Console.ReadLine());
                int j = k;
                for (; k > 0; k--)
                {
                    Console.WriteLine("\nWrite Your Node Please: ");
                    list.InsertAtBack(Console.ReadLine().ToString());
                }

                k = j;
                Console.WriteLine("\n");
                list.print();


                Tree tree = new Tree();
                populatetree2(list, tree, "BST", k);
                traversal(tree, "BST");



                Console.ReadKey();
                #endregion
            }

           


          
        }
            static void populatetree1(List list,Tree tree,string name,int j)
            {
                Console.Write("Inserting to " + name + "...  ");
                int i = j;
                for(; i>0;i--)
                {

                    int k = Int32.Parse(list.getdata().ToString());
                    tree.Insertnode(k);
                    list.nextnode();


                }

            }


            static void populatetree2(List list, Tree tree, string name, int j)
            {
                Console.Write("Inserting to " + name + "...  ");
                int i = j;
                for (; i > 0; i--)
                {

                    string k = list.getdata().ToString();
                    tree.Insertnode(k);
                    list.nextnode();


                }

            }
            
            

        static void traversal(Tree tree,string treetype)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n=================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPreorder Traversal: " + treetype);
                tree.preorderTraversal();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n=================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nInorder Traversal: " + treetype);
                tree.inorderTraversal();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n=================================");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPostorder Traversal: " + treetype);
                tree.postorderTraversal();

           
            }
            
            
            
            
       
        }
    }
