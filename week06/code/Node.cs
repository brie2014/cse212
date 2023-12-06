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
        // If the value already exists, don't add it
        if (value == Data) return;
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

    public bool Contains(int value)
    {

        // TODO Start Problem 2
        if (value == Data) return true;
        else if (value < Data)
        {
            // Search to the left
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search to the right
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        if (Left == null && Right == null) return 1;
        else if (Left == null && Right != null)
        {
            return 1 + Right.GetHeight();
        }
        else if (Right == null && Left != null)
        {
            return 1 + Left.GetHeight();
        }
        else
            return 1 + Math.Max(Right.GetHeight(), Left.GetHeight());
    }
}