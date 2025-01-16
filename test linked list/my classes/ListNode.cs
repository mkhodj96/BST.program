using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_linked_list.NewFolder1
{
    class ListNode
    {
        private object data;
        private ListNode next;

       
        public ListNode(object datavalue)
            : this(datavalue, null)
        {

        }

        public ListNode(object datavalue, ListNode nextnode)
        {
            data = datavalue;
            next = nextnode;
        }

        
        public ListNode Next
        {
            get { return next; }
            set { next = value; }

        }

      
        public object Data
        {
            get { return data; }
        }


    }
}
