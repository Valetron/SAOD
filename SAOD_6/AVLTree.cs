using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SAOD_6
{
    class AVLTree
    {
        public Node root;

        private int height(Node p)
        {
            return p == null ? 0 : p.height;
        }

        public int GetHeight()
        {
            return root.height;
        }

        private int balance(Node p)
        {
            return p == null ? 0 : height(p.left) - height(p.right);
        }

        private void update_height(Node p)
        {
            p.height = 1 + Math.Max(height(p.left), height(p.right));
        }

        private Node rightRotate(Node y)
        {
            var x = y.left;
            var t = x.right;

            x.right = y;
            y.left = t;

            update_height(y);
            update_height(x);

            return x;
        }

        private Node leftRotate(Node x)
        {
            var y = x.right;
            var t = y.left;

            y.left = x;
            x.right = t;

            update_height(x);
            update_height(y);

            return y;
        }

        public void Add(int x)
        {
            root = insert(root, x);
        }

        private Node insert(Node p, int x)
        {
            if(p == null)
                return new Node(x);

            if(x < p.x)
                p.left  = insert(p.left, x);
            else
                p.right = insert(p.right, x);

            update_height(p);
            int b = balance(p);

            if(b > 1 && x < p.left.x)
                return rightRotate(p);
            if(b < -1 && x > p.right.x)
                return leftRotate(p);
            if(b > 1 && x > p.left.x)
            {
                p.left =  leftRotate(p.left);
                return rightRotate(p);
            }
            if(b < -1 && x < p.right.x)
            {
                p.right = rightRotate(p.right);
                return leftRotate(p);
            }
            return p;
        }

        private KeyValuePair<int, string> ToStringHelper(Node n)
        {
            if(n == null)
                return new KeyValuePair<int, string>(1, "\n");

            var left = ToStringHelper(n.left);
            var right = ToStringHelper(n.right);

            var obj = n.x.ToString();
            var str = new System.Text.StringBuilder();

            str.Append(' ', left.Key - 1);
            str.Append(obj);
            str.Append(' ', right.Key - 1);
            str.Append('\n');

            var i = 0;
            while(i * left.Key < left.Value.Length && i * right.Key < right.Value.Length)
            {
                str.Append(left.Value, i * left.Key, left.Key - 1);
                str.Append(' ', obj.Length);
                str.Append(right.Value, i * right.Key, right.Key);
                ++i;
            }
            while(i * left.Key < left.Value.Length)
            {
                str.Append(left.Value, i * left.Key, left.Key - 1);
                str.Append(' ', obj.Length + right.Key - 1);
                str.Append('\n');
                ++i;
            }
            while(i * right.Key < right.Value.Length)
            {
                str.Append(' ', left.Key + obj.Length - 1);
                str.Append(right.Value, i * right.Key, right.Key);
                ++i;
            }
            return new KeyValuePair<int, string>(left.Key + obj.Length + right.Key - 1, str.ToString());
        }

        public override string ToString()
        {
            return ToStringHelper(root).Value;
        }
    }
}