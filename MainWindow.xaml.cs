using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ICE_Task_3_Trees
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private FamilyTree familyTree;

        public MainWindow()
        {
            InitializeComponent();
            familyTree = new FamilyTree();
            DisplayFamilyTree(familyTree.Monarch, null);
        }

        private void DisplayFamilyTree(FamilyTreeNode currentNode, TreeViewItem parentItem)
        {
            TreeViewItem newItem = new TreeViewItem
            {
                Header = $"{currentNode.Member.Name} " +
                       $"(DOB: {currentNode.Member.DOB.ToShortDateString()}, " +
                       $"Alive: {currentNode.Member.VitalStatus})"
            };

            if (parentItem == null)
            {
                FamilyTreeView.Items.Add(newItem);
            }
            else
            {
                parentItem.Items.Add(newItem);
            }

            foreach (var child in currentNode.Children)
            {
                DisplayFamilyTree(child, newItem);
            }
        }

        private FamilyTreeNode SearchFamilyTree(FamilyTreeNode currentNode, string name)
        {
            if (currentNode.Member.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return currentNode;
            }

            foreach (var child in currentNode.Children)
            {
                var result = SearchFamilyTree(child, name);
                if (result != null)
                {
                    return result;
                }
            }
            return null;
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string searchTerm = SearchBox.Text;
            var resultNode = SearchFamilyTree(familyTree.Monarch, searchTerm);

            if (resultNode != null)
            {
                SearchResult.Content = $"{resultNode.Member.Name} found! DOB: {resultNode.Member.DOB.ToShortDateString()}";
            }
            else
            {
                SearchResult.Content = "Family member not found.";
            }
        }

        private void AddMemberButton_Click(object sender, RoutedEventArgs e)
        {
            string name = MemberName.Text;
            DateTime dob = MemberDOB.SelectedDate ?? DateTime.Now;
            bool isAlive = VitalStatus.IsChecked ?? true;

            FamilyTreeNode selectedNode = (FamilyTreeNode)FamilyTreeView.SelectedItem; 

            if (selectedNode != null)
            {
                FamilyMember newMember = new FamilyMember(name, dob, isAlive);
                FamilyTreeNode newNode = new FamilyTreeNode(newMember);
                selectedNode.AddChild(newNode);
                DisplayFamilyTree(selectedNode, null); 
            }
        }


    }
}