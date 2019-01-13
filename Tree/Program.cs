using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aufgabe11
{
    class Tree
    {
        static void Main(string[] args)
        {
            var tree = new Tree<String>();

            var ebene = tree.CreateNode("Ebene");
            var ebene11 = tree.CreateNode("Ebene1.1");
            var ebene21 = tree.CreateNode("Ebene2.1");
            ebene.AppendChild(ebene11);
            ebene.AppendChild(ebene21);

            var ebene111 = tree.CreateNode("Ebene1.1.1");
            var ebene112 = tree.CreateNode("Ebene1.1.2");
            var ebene113 = tree.CreateNode("Ebene1.1.3");
            ebene11.AppendChild(ebene111);
            ebene11.AppendChild(ebene112);
            ebene11.AppendChild(ebene113);

            var grand21 = tree.CreateNode("Ebene2.1.1");
            ebene21.AppendChild(grand21);
            ebene11.RemoveChild(ebene112);

            ebene.PrintTree();

            string alles = ebene.Liste + " | " +ebene11.Liste + " | " + ebene21.Liste + " | " + ebene111.Liste + " | " + ebene113.Liste + " | " + grand21.Liste;
            Console.WriteLine(alles);

        }       
    }
}