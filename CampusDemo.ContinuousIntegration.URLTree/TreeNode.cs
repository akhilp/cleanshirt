using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeedCollections;

namespace CampusDemo.ContinuousIntegration.URLTree
{
    public class TreeNode
    {
        public String payload { get; set; }
        public char Character { get; set; }
        public List<TreeNode> NodeList { get; set; }
        public SpeedDictionary<char,  TreeNode> NodeDictionary { get; set; }
        
        public TreeNode()
        {         
            NodeDictionary = new SpeedDictionary<char, TreeNode>();
        }

        public void AddNode(TreeNode newNode)
        {            
            this.NodeDictionary.Add(newNode.Character, newNode);
        }

        public TreeNode Contains(char character)
        {
            TreeNode resultNode = null;

            if (NodeDictionary.Contains(character))
            {
                resultNode = NodeDictionary.Retreive(character);
            }               

            return resultNode;
        }
    }
}
