using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_linked_list.NewFolder1
{
    class EmptyListExeption:ApplicationException
    {  public EmptyListExeption(string name)
            :base("The "+name +"is empty")
        {}

    }
}