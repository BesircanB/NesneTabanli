using System;
using System.Linq;

class Program
{
    static int[,] grid = new int[9, 9];
    static int gap = 150;
    static Random rand = new Random();

    // Sudoku çözümü bulmak için kullanılan geri izleme (backtracking) fonksiyonu
    static bool SolveGrid(int[,] grid)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (grid[row, col] == 0)
                {
                    for (int value = 1; value <= 9; value++)
                    {
                        if (IsValid(grid, row, col, value))
                        {
                            grid[row, col] = value;

                            if (SolveGrid(grid))
                                return true;

                            grid[row, col] = 0;
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    // Bu fonksiyon hücreye sayı yerleştirmenin uygun olup olmadığını kontrol eder
    static bool IsValid(int[,] grid, int row, int col, int value)
    {
        // Aynı satırda bu sayı var mı?
        if (grid.Cast<int>().Where((val, index) => index / 9 == row).Contains(value))
            return false;

        // Aynı sütunda bu sayı var mı?
        if (grid.Cast<int>().Where((val, index) => index % 9 == col).Contains(value))
            return false;

        // 3x3 karede bu sayı var mı?
        int rowStart = row / 3 * 3;
        int colStart = col / 3 * 3;
        for (int r = rowStart; r < rowStart + 3; r++)
            for (int c = colStart; c < colStart + 3; c++)
                if (grid[r, c] == value)
                    return false;

        return true;
    }

    // Sudoku'yu doldurmak için rastgele sayılar ekleyen fonksiyon
    static bool FillGrid(int[,] grid)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (grid[row, col] == 0)
                {
                    // Sayıları karıştırarak yerleştiriyoruz
                    var numbers = Enumerable.Range(1, 9).OrderBy(x => rand.Next()).ToArray();

                    foreach (var number in numbers)
                    {
                        if (IsValid(grid, row, col, number))
                        {
                            grid[row, col] = number;

                            if (FillGrid(grid))
                                return true;

                            grid[row, col] = 0;
                        }
                    }

                    return false;
                }
            }
        }
        return true;
    }

    // Sudoku oluşturma işlemi
    static void GenerateSudoku(int[,] grid)
    {
        FillGrid(grid);
    }

    // Sudoku'yu ekranda gösteren fonksiyon
    static void PrintGrid(int[,] grid)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                Console.Write(grid[row, col] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Sudoku oluşturuluyor...");
        GenerateSudoku(grid); // Sudoku'yu oluştur

        Console.WriteLine("Tamamlanmış Sudoku:");
        PrintGrid(grid); // Sudoku'yu yazdır


        Console.ReadLine();
    }
}
