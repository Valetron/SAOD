namespace SAOD_6
{
    public class Node
    {
        public Node left;
        public Node right;
        public int x;
        public int height;

        public Node(int x)
        {
            this.x = x;
            height = 1;
        }
    }
}