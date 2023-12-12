public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value)
    {
        if (value == Data)
        {
            return; // Value already exists, do nothing
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
            {
                Left = new Node(value);
            }
            else
            {
                Left.Insert(value);
            }
        }
        else
        {
            // Insert to the right
            if (Right is null)
            {
                Right = new Node(value);
            }
            else
            {
                Right.Insert(value);
            }
        }
    }

    public bool Contains(int value)
{
    if (value == Data)
    {
        return true; //value in the current node
    }
    else if (value < Data && Left != null)
    {
        return Left.Contains(value); //search in the left
    }
    else if (value > Data && Right != null)
    {
        return Right.Contains(value); //search in the right 
    }
    else
    {
        return false; 
    }
}


    public int GetHeight()
{
    //in case of zero
    if (this == null)
    {
        return 0;
    }

    int leftHeight = Left?.GetHeight() ?? 0;
    int rightHeight = Right?.GetHeight() ?? 0;

    return Math.Max(leftHeight, rightHeight) + 1;
}
}