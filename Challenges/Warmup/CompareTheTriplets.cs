using System;

namespace HackerRank.Challenges.Warmup 
{
    public class CompareTheTriplets : IChallenge
    {
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2){
            byte A = 0, B = 0;

            if (a0 > b0) 
                A++;
            else if (b0 > a0)
                B++;

            if (a1 > b1) 
                A++;
            else if (b1 > a1)
                B++;

            if (a2 > b2) 
                A++;
            else if (b2 > a2)
                B++;

            return new int[2]{A,B};
        }
        public void Run()
        {
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);
            int[] result = solve(a0, a1, a2, b0, b1, b2);
            Console.WriteLine(String.Join(" ", result));
        }
    }
}