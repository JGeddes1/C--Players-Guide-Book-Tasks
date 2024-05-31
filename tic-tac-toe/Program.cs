using System.Data;

TicTacToeGame newGame = new TicTacToeGame();
newGame.runGame();
public class TicTacToeGame
{
    public void runGame()
    {
        Board board = new Board();
    
        BoardRenderer renderer = new BoardRenderer();
       

        Player player1 = new Player(Cell.X);
        Player player2 = new Player(Cell.O);
        Player currentPlayer = player1;
        int turnNumber = 0;

        while (turnNumber <9)
        {
            renderer.Draw(board);
            Console.WriteLine($"It is {currentPlayer._cell}'s turn.");
            Square square = currentPlayer.Picksquare(board);
            board.FillCell(square.Row, square.Column, currentPlayer._cell);

            if (HasWon(board, Cell.X))
            {
                renderer.Draw(board);
                Console.WriteLine("X Won!");
                return;
            }
            else if (HasWon(board, Cell.O))
            {
                renderer.Draw(board);
                Console.WriteLine("O Won!");
                return;
            }
            if (currentPlayer == player1)
            {
                currentPlayer = player2;
                turnNumber++;
            }
            else
            {
                currentPlayer = player1;
                turnNumber++;
            }
        }

    }

    private bool HasWon(Board board, Cell value)
    {
        // Check rows.
        if (board.ContentsOf(0, 0) == value && board.ContentsOf(0, 1) == value && board.ContentsOf(0, 2) == value) return true;
        if (board.ContentsOf(1, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(1, 2) == value) return true;
        if (board.ContentsOf(2, 0) == value && board.ContentsOf(2, 1) == value && board.ContentsOf(2, 2) == value) return true;

        // Check columns.
        if (board.ContentsOf(0, 0) == value && board.ContentsOf(1, 0) == value && board.ContentsOf(2, 0) == value) return true;
        if (board.ContentsOf(0, 1) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(2, 1) == value) return true;
        if (board.ContentsOf(0, 2) == value && board.ContentsOf(1, 2) == value && board.ContentsOf(2, 2) == value) return true;

        // Check diagonals.
        if (board.ContentsOf(0, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(2, 2) == value) return true;
        if (board.ContentsOf(2, 0) == value && board.ContentsOf(1, 1) == value && board.ContentsOf(0, 2) == value) return true;

        return false;
    }

}

    


public class Square
{
    public int Row { get; }
    public int Column { get; }

    public Square(int row, int column)
    {
        Row = row;
        Column = column;
    }
}


public enum Cell { Empty, X, O }