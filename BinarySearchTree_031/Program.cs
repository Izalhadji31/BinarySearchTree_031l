using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree_031
{
    class Node
    {
        public string info;
        public Node leftchild;
        public Node rightchild;

        // Constructor for the node class
        public Node(string i, Node l, Node r)
        {
            info = i;
            leftchild = l;
            rightchild = r;
        }
    }


    class program
    {
        public Node ROOT;
        public program()
        {
            ROOT = null; /*intializing ROOT to null*/
        }
        public void search(string element, ref Node parent, ref Node currentNode)
        {
            /* This function search the currentNode of the specified Node as sell
             as the current Node of its parents*/
            currentNode = ROOT;
            parent = null;
            while((currentNode != null) && (currentNode.info != element))
            {
                parent = currentNode;
                if(String.Compare(element, currentNode.info) <0)
                    currentNode = currentNode.leftchild;
                else
                    currentNode = currentNode.rightchild;
            }
        }
        public void insert(string elemnt)/* Insert a node in the binary search tree*/
        {
            Node tmp, parent = null, currentNode = null;
                search(element, ref parent, ref currentNode);
            if (currentNode!+ null)/*Check if the node to be inserted already
                                    * inserted or not*/
            {
                Console.WriteLine("Duplicate word not allowes");
                return;
            }
            else /* If the specified node is not present*/
            {
                tmp = new Node(element, null, null);
                if (parent == null)
                {
                    ROOT = tmp;
                }
                else if (string.Compare(elemnt, parent.info) < 0)
                {
                    parent.leftchild = tmp;
                }
            }
        }
        public void inorder(Node ptr)
        {
            if (ROOT == null)
            {
                Console.WriteLine("Tree is empty");
                return;
            }
            if(ptr != null)
            {
                inorder(ptr.leftchild);
                Console.WriteLine(ptr.info + "");
                inorder(ptr.rightchild);
            }
        }

        public void preorder(Node ptr)
        {

        }
        static void Main(string[] args)
        {

        }
    }
}
