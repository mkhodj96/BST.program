using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_linked_list.NewFolder1
{
    class TreeNode
    {
        private TreeNode leftnode;
        private IComparable data;
        private TreeNode rightnode;

        public TreeNode(IComparable nodedata)
        {
            data = nodedata;
            leftnode = rightnode = null;
        }

        public TreeNode LeftNode
        {
            get { return leftnode; }
            set { leftnode = value; }
        }

        public TreeNode RightNode
        {
            get { return rightnode; }
            set { rightnode = value; }

        }

        public IComparable Data
        {
            get { return data; }
            set { data = value; }
        }

      

        public void Insert(IComparable insertvalue)
        {
            if (insertvalue.CompareTo(data) < 0)
            {
                if (leftnode == null)
                {
                    leftnode = new TreeNode(insertvalue);

                }
                else
                {
                    leftnode.Insert(insertvalue);

                }
            }
            else if (insertvalue.CompareTo(data) > 0)
            {
                if (rightnode == null)
                {
                    rightnode = new TreeNode(insertvalue);
                }
                else
                {
                    rightnode.Insert(insertvalue);
                }
            }


        }
    }
    }
