namespace DisappearingScaffolding
{
    internal class Program
    {
        public enum Position
        {
            Y,
            X
        }



        public static int solution(int[,] board, int[] aloc, int[] bloc)
        {
            int answer = -1;
            return answer;
        }

        public static bool IsMoveable(int[,] board, int[] player)
        {
            if(board[player[(int)Position.Y + 1], player[(int)Position.X + 1]] == 0)
            {



















            }

            return false;
        }

        static void Main(string[] args)
        {
            int[,] board = { { 1, 1, 1},
                              { 1, 1, 1},
                              { 1, 1, 1} };
            int[] aloc = { 1, 0 };
            int[] bloc = { 1, 2 };

            Console.WriteLine(solution(board, aloc, bloc));
        }
    }
}