using System;

class SudokuSolver
{
    static int N =  9;
    
    static bool solveSudoku(int [,] board, int row, int col)
    {
        if(row == N-1 && col == N)
        return true;

        if(col == N)
        {
            row++;
            col = 0;
        }

        if(board[row,col] != 0)
            return solveSudoku(board,row,col + 1);
 
        for(int num = 1;num < 10; num++)
        {
            if(numExist(board,row,col,num))
            {
                board[row,col] = num;
                if(solveSudoku(board,row,col + 1))
                return true;
            }
            board[row,col] = 0;
        }
    
    return false;    
    }

    static void Output(int[,] board)
    {
        for(int i = 0;i < N;i++)
        {
            for(int j = 0;j < N;j++)
                Console.Write(board[i,j] + " ");
                Console.WriteLine();
        }
    }

    static bool numExist(int[,] board, int row, int col, int num)
    {
        for(int x = 0;x <= 8;x++)
            if(board[row,x] == num)
                return false;
        
        for(int x = 0;x <= 8;x++)
            if(board[x,col] == num)
                return false;

        int startRow = row - row % 3, startCol = col - col % 3;
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                if (board[i + startRow,j + startCol] == num)
                    return false;
 
    return true;     
    }

    static void Main()
    {
        int[,] board = { { 3, 0, 6, 5, 0, 8, 4, 0, 0 },
                   { 5, 2, 0, 0, 0, 0, 0, 0, 0 },
                   { 0, 8, 7, 0, 0, 0, 0, 3, 1 },
                   { 0, 0, 3, 0, 1, 0, 0, 8, 0 },
                   { 9, 0, 0, 8, 6, 3, 0, 0, 5 },
                   { 0, 5, 0, 0, 9, 0, 6, 0, 0 },
                   { 1, 3, 0, 0, 0, 0, 2, 5, 0 },
                   { 0, 0, 0, 0, 0, 0, 0, 7, 4 },
                   { 0, 0, 5, 2, 0, 6, 3, 0, 0 } };

        if(solveSudoku(board,0,0))
            Output(board);
        else
            Console.WriteLine("Cannot Solve");
    }

}