using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_Task_3_Trees
{
    public class FamilyTree
    {
        public FamilyTreeNode Monarch { get; set; }

        public FamilyTree()
        {
            // Tree based off of the tree seen at:
            // https://www.britroyals.com/windsortree.asp
            // Tree startsing from George VI and ending with the most recent line of royals (not including recent kids and spouses)

            FamilyMember georgeVI = new FamilyMember("George VI", new DateTime(1895, 12, 14), false);
            Monarch = new FamilyTreeNode(georgeVI);

            FamilyMember elizabethI = new FamilyMember("Elizabeth Bowes Lyon", new DateTime(1900, 8, 4), false);
            FamilyTreeNode elizabethINode = new FamilyTreeNode(elizabethI);

            FamilyMember elizabethII = new FamilyMember("Elizabeth II", new DateTime(1926, 4, 21), false);
            FamilyTreeNode elizabethIINode = new FamilyTreeNode(elizabethII);

            FamilyMember philip = new FamilyMember("Philip Duke of Edinburugh", new DateTime(1921, 6, 10), true);
            FamilyTreeNode philipNode = new FamilyTreeNode(philip);

            FamilyMember charles = new FamilyMember("KIng Charles III", new DateTime(1948, 11, 14), true);
            FamilyTreeNode charlesNode = new FamilyTreeNode(charles);

            FamilyMember anne = new FamilyMember("Princess Anne", new DateTime(1950, 8, 15), true);
            FamilyTreeNode anneNode = new FamilyTreeNode(anne);

            FamilyMember andrew = new FamilyMember("Prince ANdrew Duke of YOrk", new DateTime(1960, 2, 15), true);
            FamilyTreeNode andrewNode = new FamilyTreeNode(andrew);

            FamilyMember edward = new FamilyMember("Princes Edward Duke of Edinburugh", new DateTime(1964, 3, 10), true);
            FamilyTreeNode edwardNode = new FamilyTreeNode(edward);

            FamilyMember harry = new FamilyMember("Prince Harry Duke of Sussex", new DateTime(1984, 9, 15), true);
            FamilyTreeNode harryNode = new FamilyTreeNode(anne);

            FamilyMember william = new FamilyMember("Prince William Duke of Wales", new DateTime(1982, 6, 21), true);
            FamilyTreeNode williamNode = new FamilyTreeNode(william);

            FamilyMember peter = new FamilyMember("Peter Philips", new DateTime(1977, 11, 15), true);
            FamilyTreeNode peterNode = new FamilyTreeNode(peter);

            FamilyMember zara = new FamilyMember("Zara Philps", new DateTime(1981, 5, 15), true);
            FamilyTreeNode zaraNode = new FamilyTreeNode(zara);

            FamilyMember beatrice = new FamilyMember("Princess Beatrice", new DateTime(1988, 8, 8), true);
            FamilyTreeNode beatriceNode = new FamilyTreeNode(beatrice);

            FamilyMember eugenie = new FamilyMember("Princess Eugenie", new DateTime(1990, 3, 23), true);
            FamilyTreeNode eugenieNode = new FamilyTreeNode(eugenie);

            FamilyMember louise = new FamilyMember("Lady Louise", new DateTime(2003, 11, 8), true);
            FamilyTreeNode louiseNode = new FamilyTreeNode(louise);

            FamilyMember earl = new FamilyMember("Earl of Wessex", new DateTime(2007, 12, 17), true);
            FamilyTreeNode earlNode = new FamilyTreeNode(earl);

            Monarch.AddChild(elizabethIINode);
        }
    }

}
