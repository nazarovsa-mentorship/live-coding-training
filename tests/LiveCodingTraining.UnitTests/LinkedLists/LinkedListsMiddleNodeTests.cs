using LiveCodingTraining.LinkedLists;
using LiveCodingTraining.LinkedLists.Infrastructure;

namespace LiveCodingTraining.UnitTests.LinkedLists;

public class LinkedListsMiddleNodeTests
{
    [Fact]
    public void MiddleNode_WithVariousLists_ReturnsExpectedMiddleNode()
    {
        // Test case 1: Single node
        var singleNode = new Node(1);
        var result1 = singleNode.MiddleNode();
        Assert.Equal(1, result1.Data);
        
        // Test case 2: Two nodes - return second
        var twoNodes = new Node(1, new Node(2));
        var result2 = twoNodes.MiddleNode();
        Assert.Equal(2, result2.Data);
        
        // Test case 3: Three nodes - return middle
        var threeNodes = new Node(1, new Node(2, new Node(3)));
        var result3 = threeNodes.MiddleNode();
        Assert.Equal(2, result3.Data);
        
        // Test case 4: Four nodes - return second of two middle (node 3)
        var fourNodes = new Node(1, new Node(2, new Node(3, new Node(4))));
        var result4 = fourNodes.MiddleNode();
        Assert.Equal(3, result4.Data);
        
        // Test case 5: Five nodes [1,2,3,4,5] - return middle (node 3)
        var fiveNodes = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5)))));
        var result5 = fiveNodes.MiddleNode();
        Assert.Equal(3, result5.Data);
        
        // Test case 6: Six nodes [1,2,3,4,5,6] - return second of two middle (node 4)
        var sixNodes = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5, new Node(6))))));
        var result6 = sixNodes.MiddleNode();
        Assert.Equal(4, result6.Data);
        
        // Test case 7: Seven nodes - return middle
        var sevenNodes = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5, new Node(6, new Node(7)))))));
        var result7 = sevenNodes.MiddleNode();
        Assert.Equal(4, result7.Data);
        
        // Test case 8: Eight nodes - return second of two middle (node 5)
        var eightNodes = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5, new Node(6, new Node(7, new Node(8))))))));
        var result8 = eightNodes.MiddleNode();
        Assert.Equal(5, result8.Data);
        
        // Test case 9: Different data values
        var differentValues = new Node(10, new Node(20, new Node(30, new Node(40, new Node(50)))));
        var result9 = differentValues.MiddleNode();
        Assert.Equal(30, result9.Data);
        
        // Test case 10: Large list (10 nodes) - return second of two middle (node 6)
        var tenNodes = new Node(1, new Node(2, new Node(3, new Node(4, new Node(5, 
                       new Node(6, new Node(7, new Node(8, new Node(9, new Node(10))))))))));
        var result10 = tenNodes.MiddleNode();
        Assert.Equal(6, result10.Data);
    }
}