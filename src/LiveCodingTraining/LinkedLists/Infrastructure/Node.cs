using System.Collections;
using System.Text;

namespace LiveCodingTraining.LinkedLists.Infrastructure;

public class Node : IEnumerable<Node>
{
    public int Data { get; }
    public Node? Next { get; set; }

    public Node(int data, Node? next = null)
    {
        Data = data;
        Next = next;
    }

    public static Node FromEnumerable(IEnumerable<int> collection)
    {
        Node? head = null;
        Node? current = null;
        foreach (var item in collection)
        {
            var node = new Node(item);
            if (head == null)
            {
                head = node;
                current = node;
                continue;
            }

            current.Next = node;
            current = node;
        }

        if (head == null)
            throw new ArgumentException("Collection is empty");

        return head;
    }

    public IEnumerator<Node> GetEnumerator()
    {
        var current = this;
        while (current != null)
        {
            yield return current;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    protected bool Equals(Node other)
    {
        return Data == other.Data;
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) 
            return false;
        
        if (ReferenceEquals(this, obj)) 
            return true;
        
        if (obj.GetType() != GetType()) 
            return false;
        
        return Equals((Node)obj);
    }

    public override int GetHashCode()
    {
        return Data;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        var current = this;
        while (current != null)
        {
            sb.Append($"{current.Data} ");
            current = current.Next;
        }

        return sb.ToString().TrimEnd();
    }
}