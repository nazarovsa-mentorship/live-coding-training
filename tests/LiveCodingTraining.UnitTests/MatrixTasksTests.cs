using LiveCodingTraining.Arrays;
using LiveCodingTraining.Matrix;

namespace LiveCodingTraining.UnitTests;

public class MatrixTasksTests
{
    public class DiagonalSumTests
    {
        /// <summary>
        /// Тесты для метода DiagonalSum - проверяем различные сценарии:
        /// - Матрица 3x3 с разными числами (нечетный размер)
        /// - Матрица 4x4 с одинаковыми числами (четный размер)  
        /// - Матрица 1x1 (граничный случай)
        /// - Матрица 2x2 (четный размер, минимальный)
        /// - Матрица 5x5 с отрицательными числами (нечетный размер)
        /// </summary>
        [Fact]
        public void DiagonalSum_VariousMatrices_ReturnsCorrectSum()
        {

            // Тест 1: Матрица 3x3 из примера
            var mat1 = new int[][]
            {
                [1, 2, 3],
                [4, 5, 6],
                [7, 8, 9]
            };
            Assert.Equal(25, MatrixTasks.DiagonalSum(mat1)); // 1+5+9+3+7=25

            // Тест 2: Матрица 4x4 с одинаковыми элементами
            var mat2 = new int[][]
            {
                [1, 1, 1, 1],
                [1, 1, 1, 1],
                [1, 1, 1, 1],
                [1, 1, 1, 1]
            };
            Assert.Equal(8, MatrixTasks.DiagonalSum(mat2)); // 4+4=8 (без пересечений)

            // Тест 3: Матрица 1x1
            var mat3 = new int[][]
            {
                [5]
            };
            Assert.Equal(5, MatrixTasks.DiagonalSum(mat3)); // Единственный элемент

            // Тест 4: Матрица 2x2
            var mat4 = new int[][]
            {
                [1, 2],
                [3, 4]
            };
            Assert.Equal(10, MatrixTasks.DiagonalSum(mat4)); // 1+4+2+3=10

            // Тест 5: Матрица 5x5 с отрицательными числами
            var mat5 = new int[][]
            {
                [1, -2, 3, -4, 5],
                [-6, 7, -8, 9, -10],
                [11, -12, 13, -14, 15],
                [-16, 17, -18, 19, -20],
                [21, -22, 23, -24, 25]
            };
            // Главная диагональ: 1+7+13+19+25=65
            // Побочная диагональ: 5+9+13+17+21=65  
            // Центральный элемент 13 вычитается один раз: 65+65-13=117
            Assert.Equal(117, MatrixTasks.DiagonalSum(mat5));
        }
    }
}