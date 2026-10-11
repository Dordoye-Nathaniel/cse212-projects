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
        // TODO Start Problem 1

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            // (changed from a plain 'else' so that a value equal to Data
            // falls through and is ignored, keeping every value unique)
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, it's a duplicate, so do nothing.
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true; // found the value
        }

        if (value < Data)
        {
            // The value can only be in the left subtree
            return Left is not null && Left.Contains(value);
        }

        // Otherwise it can only be in the right subtree
        return Right is not null && Right.Contains(value);
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        // A missing subtree has a height of 0
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // Height is one (this node) plus the taller of the two subtrees
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}