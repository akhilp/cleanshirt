using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusDemo.ContinuousIntegration.URLTree
{
    public class TreeNode
    {
        public String payload { get; set; }
        public char Character { get; set; }
        public List<TreeNode> NodeList { get; set; }

        public TreeNode()
        {
            NodeList = new List<TreeNode>();
        }

        public void AddNode(TreeNode newNode)
        {
            this.NodeList.Add(newNode);
        }

        public TreeNode Contains(char character)
        {
            TreeNode resultNode = null;

            for (int i = 0; i < NodeList.Count; i++)
            {
                if (this.NodeList[i].Character == character)
                {
                    resultNode = this.NodeList[i];
                    break;
                }
            }

            return resultNode;
        }
    }
}