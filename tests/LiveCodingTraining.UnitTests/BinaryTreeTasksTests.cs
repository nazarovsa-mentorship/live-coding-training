namespace LiveCodingTraining.UnitTests;

public class BinaryTreeTasksTests
{
    [Fact]
    public void HasPathSum_ShouldReturnCorrectResults()
    {
        // Arrange & Act & Assert
        
        // Тест 1: Пример из задачи - дерево [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
        // Путь 5->4->11->2 = 22
        var root1 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(5,
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(4,
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(11,
                    new BinaryTreeTasks.BinaryTreeTasks.TreeNode(7),
                    new BinaryTreeTasks.BinaryTreeTasks.TreeNode(2))),
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(8,
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(13),
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(4,
                    null,
                    new BinaryTreeTasks.BinaryTreeTasks.TreeNode(1))));
        
        Assert.True(HasPathSum(root1, 22));
        
        // Тест 2: Пример из задачи - дерево [1,2,3], targetSum = 5
        var root2 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(1,
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(2),
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(3));
        
        Assert.False(HasPathSum(root2, 5));
        
        // Тест 3: Пустое дерево
        Assert.False(HasPathSum(null, 1));
        
        // Тест 4: Дерево из одного узла - положительный случай
        var root3 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(5);
        Assert.True(HasPathSum(root3, 5));
        
        // Тест 5: Дерево из одного узла - отрицательный случай
        var root4 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(5);
        Assert.False(HasPathSum(root4, 10));
        
        // Тест 6: Отрицательные числа
        var root5 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(-3,
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(9),
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(20,
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(15),
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(7)));
        Assert.True(HasPathSum(root5, 6)); // -3 + 9 = 6
        
        // Тест 7: Несколько возможных путей, один из которых подходит
        var root6 = new BinaryTreeTasks.BinaryTreeTasks.TreeNode(1,
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(2,
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(3),
                new BinaryTreeTasks.BinaryTreeTasks.TreeNode(4)),
            new BinaryTreeTasks.BinaryTreeTasks.TreeNode(5));
        Assert.True(HasPathSum(root6, 6)); // 1 + 5 = 6
        Assert.True(HasPathSum(root6, 7)); // 1 + 2 + 4 = 7
        Assert.False(HasPathSum(root6, 10));
    }
    
    // Копия метода для тестирования (в реальном проекте он был бы в отдельном классе)
    public static bool HasPathSum(BinaryTreeTasks.BinaryTreeTasks.TreeNode root, int targetSum) 
    {
        // Базовый случай: если дерево пустое
        if (root == null) 
            return false;
        
        // Если это лист (нет дочерних узлов)
        if (root.left == null && root.right == null) 
        {
            // Проверяем, равно ли значение узла оставшейся сумме
            return root.val == targetSum;
        }
        
        // Рекурсивно проверяем левое и правое поддеревья
        // Уменьшаем targetSum на значение текущего узла
        return HasPathSum(root.left, targetSum - root.val) || 
               HasPathSum(root.right, targetSum - root.val);
    }
}