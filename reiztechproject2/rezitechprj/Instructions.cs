using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rezitechprj
{
    internal class Instructions
    {
        // !!!!!!!!!!!!!!!!!!    FOR CODE REVIEWER
        // building the tree in `treeElements` array has to be done from left to right
        // that means that position of the element in array is important 

        // HERE IS AN EXAMPLE
        /*
         *          treeElements.Add(new TreeElement("root", -1, null));
                    treeElements.Add(new TreeElement("c1", 0));
                    treeElements.Add(new TreeElement("c3", 1));
                    treeElements.Add(new TreeElement("c5", 2));
                    treeElements.Add(new TreeElement("c4", 1));
                    treeElements.Add(new TreeElement("c6", 2));
                    treeElements.Add(new TreeElement("c2", 0));

        /*            THIS IS THE GRAPH OF THE ABOVE ARRAY // this is also test1 in main()
         *           
         *                  Root
         *                 /   \
         *                c1    c2
         *               /  \
         *              c3   c4
         *             /      \
         *            c5       c6
         *              
         *   TO SEE GRAPH IN VISUAL FORM ('KINDA') ENABLE `PrintTree` function in main() function
         * 
         */
        /*
            Limitations: there has to be atleast 2 nodes
            There is only 1 root
            Tree nodes cannot go from lvl 1 -> lvl 6, whitout being connected via other lower nodes

            USE Test 1 and Test 2 to test out the program, if needed make your own array and test out the program
         */
    }
}
