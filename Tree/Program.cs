// See https://aka.ms/new-console-template for more information
using Tree;

//Replicating the structure from the example
// Level 1 
Branch b = new Branch(1);

//Level 2 
b.addBranch(2);
b.addBranch(3);

//Level 3 
b.branches[0].addBranch(4);
b.branches[1].addBranch(5);
b.branches[1].addBranch(6);
b.branches[1].addBranch(7);

//Level 4
b.branches[1].branches[0].addBranch(8);
b.branches[1].branches[1].addBranch(9);
b.branches[1].branches[1].addBranch(10);

//Level 5
b.branches[1].branches[1].branches[0].addBranch(11);

Console.WriteLine("Tree depth: " + Utility.getTreeDepth(b, 1));