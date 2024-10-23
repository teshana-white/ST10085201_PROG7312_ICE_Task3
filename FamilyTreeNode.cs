using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3_Trees
{
    public class FamilyTreeNode
    {
        public FamilyMember Member { get; set; }
        public List<FamilyTreeNode> Children { get; set; }

        public FamilyTreeNode(FamilyMember member)
        {
            Member = member;
            Children = new List<FamilyTreeNode>();
        }

        public void AddChild(FamilyTreeNode child)
        {
            Children.Add(child);
        }
    }
}


