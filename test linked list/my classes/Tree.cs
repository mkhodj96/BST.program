using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_linked_list.NewFolder1
{
    class Tree
    {
        
        private TreeNode root;

        public Tree()
        {
            root=null;
        }

        public void Insertnode(IComparable insertvalue)
        {
            lock (this)
            {
                if(root ==null)
                {
                    root = new TreeNode(insertvalue);
                }
                else
                {
                    root.Insert(insertvalue);
                }
            }
        }


        //preorder traversal

        public void preorderTraversal()
        {
            lock (this)
            {
                preorderHelper(root);
            }
        }
        private void preorderHelper(TreeNode node)
        {
            if(node==null)
            {
                return;
            }
            Console.Write(node.Data + " ");
            preorderHelper(node.LeftNode);
            preorderHelper(node.RightNode);
        }

        // inorder

        public void inorderTraversal()
        {
            lock(this)
            {
                inorderHelper(root);
            }
        }
        private void inorderHelper(TreeNode node)
        {
            if (node==null)
            {
                return;
            }
            inorderHelper(node.LeftNode);
            Console.Write(node.Data + " ");
            inorderHelper(node.RightNode);


        }

        //postorder
        public void postorderTraversal()
        {
            lock (this)
            {
                postorderHelper(root);
            }
        }
        private void postorderHelper(TreeNode node)
        {
            if(node==null)
            { return; }

            postorderHelper(node.LeftNode);
            postorderHelper(node.RightNode);
            Console.Write(node.Data+" ");
        }
    }
    }

