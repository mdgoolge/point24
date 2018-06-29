using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace calc24WithExpressionTree
{
    public class Node
    {
        public Node Left { get; private set; }
        public Node Right { get; private set; }
        public Node(Node left, Node right)
        {
            this.Left = left;
            this.Right = right;
        }


       
    }

}
