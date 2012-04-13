using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampusDemo.ContinuousIntegration.URLTree
{
    public class TreeNode
    {
        public TreeNode()
        {
            NodeList = new List<TreeNode>();
        }

        public String payload { get; set; }
        public char Character { get; set; }
        public List<TreeNode> NodeList { get; set; }
    }
}
