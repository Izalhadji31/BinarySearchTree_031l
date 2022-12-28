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

        }
    }
}
