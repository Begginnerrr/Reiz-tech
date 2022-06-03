using System;
using System.Collections.Generic;


// !!!!!!!!!!!!!!!!!!!!! FOR CODE REVIEWER
// You can find instructions how to use the code in `Instructions.cs` class


namespace rezitechprj
{
    internal class Program
    {
        public static void PrintTree(TreeElement branch, int depth) // prints out the graph
        {
            Console.WriteLine(new string('\t', depth) + branch.name);
            foreach (var subBranch in branch.children)
            {
                //  Console.WriteLine("Branch name : " + subBranch.name + " branch children : " + subBranch.children.Count);
                PrintTree(subBranch, depth + 1);
            }
        }

        public static int depths(TreeElement branch, int depth, int sum)
        {
            int tempsum = 0;
            if (branch.children.Count == 0)
            {
                return 0;   
            }
            else
            {
                foreach (var subBranch in branch.children)
                {
                    int a = depths(subBranch, depth + 1, tempsum) + 1; 
                 //   Console.WriteLine("this is a: "+a); // check a in process
                 //   Console.WriteLine("this is sum: " + sum); // check sum in process
                    if (sum < a)
                    {
                        sum = a;
                    }
                            
                }
                
                return sum ;
            }
        }

        static void Main(string[] args)
        {
            int sum = 0;
            int Finalsum = 0;
            List<TreeElement> treeElements = new List<TreeElement>();
            
            // This is test 1
            
            treeElements.Add(new TreeElement("root", -1, null));
            treeElements.Add(new TreeElement("c1", 0));
            treeElements.Add(new TreeElement("c3", 1));
            treeElements.Add(new TreeElement("c5", 2));
            treeElements.Add(new TreeElement("c4", 1));
            treeElements.Add(new TreeElement("c6", 2));
            treeElements.Add(new TreeElement("c2", 0));
            

            // This is test 2
            /*
            treeElements.Add(new TreeElement("root", -1, null));
            treeElements.Add(new TreeElement("c1", 0));
            treeElements.Add(new TreeElement("c2", 1));
            treeElements.Add(new TreeElement("c3", 2));
            treeElements.Add(new TreeElement("c4", 2));
            treeElements.Add(new TreeElement("c5", 3));
            treeElements.Add(new TreeElement("c6", 3));
            treeElements.Add(new TreeElement("c7", 2));
            treeElements.Add(new TreeElement("c8", 0));
            treeElements.Add(new TreeElement("c9", 0));
            treeElements.Add(new TreeElement("c10", 1));
            treeElements.Add(new TreeElement("c11", 1));
            */

            if (treeElements.Count < 2)
            {
                Console.WriteLine("List is too short");
            }
            else
            {
                TreeElement root1 = new TreeElement();
                root1 = GenerateTreeStructure(treeElements);
              //  PrintTree(root1, 0);                                        // USE THIS FUNCTION TO SEE TREE IMAGE 
                Finalsum = depths(root1, -1, sum);
                Finalsum = Finalsum + 1; // since root is also considered a level
                Console.WriteLine("Depth of tree is : "+Finalsum);
            }
        }

        public class TreeElement  // this is the class of the structure node
        {
            public string name;
            public int depth;
            public int id;
            public TreeElement parent;
            public List<TreeElement> children = new List<TreeElement>();

            public TreeElement(string name, int depth, TreeElement parent)
            {
                this.name = name;
                this.depth = depth;
                this.parent = parent;
            }
            public TreeElement(string name, int depth)
            {
                this.name = name;
                this.depth = depth;
            }
            public TreeElement()
            {

            }
        }

        public static TreeElement GenerateTreeStructure(List<TreeElement> baseList)
        {
            TreeElement root = null;
            if (baseList == null || baseList.Count == 0) return root;

            int baseIdx = -1;

            TreeElement prevNode = null;
            TreeElement parent = null;

            while (baseIdx < baseList.Count - 1)
            {
                baseIdx++;
                TreeElement item = baseList[baseIdx];

                if (item.depth == -1)
                {
                    root = new TreeElement("root", -1, null);
                    prevNode = root;
                    continue;
                }

                if (item.depth == prevNode.depth) parent = prevNode.parent; // same  If our node is on the same level
                else if (item.depth > prevNode.depth) parent = prevNode;    // deeper If our node has to go deeper
                else                                                        // shallower If our node has to go in with and is jumping few levels up
                {
                    parent = prevNode.parent;
                    while (parent.depth >= item.depth) parent = parent.parent;
                }

                TreeElement newNode = new TreeElement(item.name, item.depth, parent);
                parent.children.Add(newNode);
                prevNode = newNode;
            }

            return root;
        }

       
    }


}
  


