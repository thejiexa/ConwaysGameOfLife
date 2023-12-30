namespace ConwaysGameOfLife
{
    internal class GameOfLife
    {
        readonly int rows;
        readonly int cols;
        bool[,] board;

        public GameOfLife(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;
            board = new bool[cols, rows];
            Random random = new();

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    board[x, y] = random.Next(density) is 0;
                }
            }
        }

        int CountNeighbors(int x, int y)
        {
            int neighbors = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    int col = (x + i + cols) % cols;
                    int row = (y + j + rows) % rows; 

                    if (board[col, row] && !(col == x && row == y))
                        neighbors++;
                }
            }

            return neighbors;
        }

        public void NextGeneration()
        {
            bool[,] newBoard = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    int neighbors = CountNeighbors(x, y);
                    bool hasLife = board[x, y];

                    newBoard[x, y] = (hasLife, neighbors) switch
                    {
                        (false, 3) => true,
                        (true, < 2) => false,
                        (true, > 3) => false,
                        _ => board[x, y]
                    };
                }
            }

            board = newBoard;
        }

        public bool[,] GetCurrentGeneration()
        {
            bool[,] result = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    result[x, y] = board[x, y];
                }
            }

            return result;
        }

        public void AddCell(Point location) => UpdateCell(location, true);
        
        public void RemoveCell(Point location) => UpdateCell(location, false);

        void UpdateCell(Point location, bool state)
        {
            if (ValidatePosition(location))
                board[location.X, location.Y] = state;
        }

        bool ValidatePosition(Point location) => location.X >= 0 && location.Y >= 0 && location.X < cols && location.Y < rows;
    }
}