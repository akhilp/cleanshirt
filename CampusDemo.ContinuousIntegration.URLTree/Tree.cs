using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusDemo.ContinuousIntegration.URLTree
{
    public class Tree
    {
        private int _count { get; set; }
        private TreeNode Root { get; set; }
        public int Count 
        { 
            get
            {
                return _count;
            }
        
        }

        public Tree()
        {
            this.Root = new TreeNode();            
        }

        public void Add(string value, String payload)
        {
            WriteToTree(Root, value, 0, payload);
        }

        public String Findpayload(string url)
        {
            TreeNode node = FindNode(url);
            if (node == null)
            {               
                return String.Empty;
            }
            else
            {
                return node.payload;
            }
        }

        private void WriteToTree(TreeNode node, string value, int index, String payload)
        {
            value = value.ToLower();
            int size = value.Count();

            while (index < size)
            {                

                TreeNode nextNode = node.Contains(value[index]);

                //Continue down the list
                if (nextNode != null && index != size - 1)
                {
                    node = nextNode;
                }
                //At the end. Add node here
                else if(nextNode != null && index == size - 1)
                {
                    nextNode.payload = payload;
                    _count++;
                }
                //At the end and new node
                else
                {
                    TreeNode newNode = new TreeNode();
                    newNode.Character = value[index];
                    if (index == size - 1)
                    {
                        newNode.payload = payload;
                        _count++; 
                    }
                    node.AddNode(newNode);
                    node = newNode;
                }

                index++;
            }
        }

        private TreeNode FindNode(string url)
        {
            url = url.ToLower();

            int i = 0;
            TreeNode returnNode = null;
            int size = url.Count();
            TreeNode node = Root;

            while (i <= size)
            {
                if (!string.IsNullOrEmpty(node.payload))
                {
                    returnNode = node;
                }

                if (i == size)
                {
                    break;
                }
                else
                {
                    TreeNode nextNode = Contains(node, url[i]);
                    if (nextNode == null)
                    {
                        break;
                    }
                    else
                    {
                        node = nextNode;
                        i++;
                    }
                }
            }

            return returnNode;
        }
    }
}
