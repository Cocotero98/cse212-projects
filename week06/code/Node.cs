public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (!Contains(value))
        {
            if (value < Data)
            {
                // Insert to the left
                if (Left is null)
                    Left = new Node(value);
                else
                    Left.Insert(value);
            }
            else
            {
                // Insert to the right
                if (Right is null)
                    Right = new Node(value);
                else
                    Right.Insert(value);
            }
        }

    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
        {
            return true;
        }
        if (Left == null && Right == null)
        {
            return false;
        }
        if ((Left != null && Left.Contains(value)) || (Right != null && Right.Contains(value)))
        {
            return true;
        };

        return false;
    }

    public int GetHeight(int h = 0)
    {
        // TODO Start Problem 4
        h = h + 1;
        var rightSubtree = Right?.GetHeight(h) ?? h;
        var leftSubtree = Left?.GetHeight(h) ?? h;
        if (rightSubtree > leftSubtree)
        {
            return rightSubtree;
        };
        return leftSubtree;
    }
}