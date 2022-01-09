using System.Collections;
using System.Collections.Generic;

namespace OpenLib.Collections
{
    /// <summary>
    /// Binary Tree
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class TreeNode<T>
    {
        public TreeNode() { }

        public TreeNode(T value, TreeNode<T> left, TreeNode<T> right) 
        {
            Value = value;
            Left = left;
            Right = right;
        }

        public TreeNode<T> Left { get; set; }

        public TreeNode<T> Right { get; set; }

        public T Value { get; set; }
    }
}

