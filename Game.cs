using System;
using System.Text;

namespace Puissance4
{
    public class Game
    {
        public void Start()
        {
            Board board = new Board();
            Player player1 = new Player(1);
            ManagePlayer player2;
           
        
            Console.WriteLine("Voulez-vous jouer contre l'ordinateur ? Y or N");
            string res = Console.ReadLine();
            if(res.Equals("Y"))
            {
                player2 = new Computer(2);
            } 
            else {
                player2 = new Player(2);
            }

            while (true)
            {
                board.drawnBoard();

                int columnP1 = player1.play();

                board.AddJeton(columnP1, player1.currentPlayer);

                board.drawnBoard();
                int columnP2 = player2.play();

                board.AddJeton(columnP2, player2.currentPlayer);
                
            }
        }
    }
}