using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using OpenLib.Collections;
using UnityEngine;
using UnityEngine.TestTools;

public class PreOrderTraversal
{
    // A Test behaves as an ordinary method
    [Test]
    public void PreOrderTraversalSimplePasses()
    {
        var tree = new TreeNode<int>(1);
        tree.Left = new TreeNode<int>(2);
        tree.Right = new TreeNode<int>(3);
        tree.Left.Left = new TreeNode<int>(4);
        tree.Left.Right = new TreeNode<int>(5);
        tree.Right.Left = new TreeNode<int>(6);
        tree.Right.Right = new TreeNode<int>(7);

        CollectionAssert.AreEqual(new[] { 1, 2, 4, 5, 3, 6, 7 }, tree.PreOrder());
    }
}
