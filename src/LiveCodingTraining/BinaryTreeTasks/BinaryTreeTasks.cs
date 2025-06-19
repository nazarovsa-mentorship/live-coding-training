namespace LiveCodingTraining.BinaryTreeTasks;

public static class BinaryTreeTasks
{
    /// <summary>
    /// Задача: Path Sum (Сумма пути)
    /// 
    /// Дано бинарное дерево и целое число targetSum. Определить, существует ли путь 
    /// от корня до листа, такой что сумма всех значений узлов на этом пути равна targetSum.
    ///
    /// Лист - это узел, у которого нет дочерних узлов.
    /// 
    /// Примеры:
    /// 
    /// Пример 1:
    /// Дерево:      5
    ///             / \
    ///            4   8
    ///           /   / \
    ///          11  13  4
    ///         / \      \
    ///        7   2      1
    /// 
    /// Ввод: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
    /// Вывод: true
    /// Объяснение: Путь 5->4->11->2 дает сумму 22
    /// 
    /// Пример 2:
    /// Дерево:    1
    ///           / \
    ///          2   3
    /// 
    /// Ввод: root = [1,2,3], targetSum = 5
    /// Вывод: false
    /// Объяснение: Есть два пути от корня до листьев:
    /// - 1->2 (сумма = 3)
    /// - 1->3 (сумма = 4)
    /// Ни один из них не равен 5
    public static bool HasPathSum(TreeNode root, int targetSum)
    {
        throw new NotImplementedException();
    }
        
    public class TreeNode 
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) 
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}