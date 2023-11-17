namespace Painting
{
    internal class Program
    {
        public static int solution(int n, int m, int[] section)
        {
            int answer = 0;
            int range = section[0] - 1;


            for (int i = 0; i < section.Length; ++i)
            {
                if (section[i] > range)
                {
                    range = section[i] - 1 + m;
                    answer++;
                }
            }

            return answer;
        }

        static void Main(string[] args)
        {
            int wallSize = 5;
            int brushSize = 2;
            int[] section = new int[] { 1, 4, 5};

            Console.WriteLine(solution(wallSize, brushSize, section));
        }
    }
}