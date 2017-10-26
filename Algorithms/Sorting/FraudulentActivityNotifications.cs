using System;
using System.Collections.Generic;
using HackerRank.Library;

namespace HackerRank.Algorithms.Sorting
{
    // https://www.hackerrank.com/challenges/fraudulent-activity-notifications/problem
    public class FraudulentActivityNotifications : IChallenge
    {
        const int MAX_EXPENDITURE = 201;
        static int activityNotifications(int[] expenditure, int d) {
            var queue = new Queue<int>();
            var activity = new int[MAX_EXPENDITURE];
            for(int i = 0; i < d; i++)
            {
                var amount = expenditure[i];
                queue.Enqueue(amount);
                activity[amount]++;
            }
                
            var notifications = 0;
            for(int i = d; i < expenditure.Length; i++)
            {
                int amount = expenditure[i];
                
                if(amount >= (2* activity.FrequencyMedian(d)))
                    notifications++;
                    
                int oldestAmount = queue.Dequeue();
                activity[oldestAmount]--;
                
                queue.Enqueue(amount);
                activity[amount]++;
            }
        
            return notifications;
        }

        public void Run()
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int d = Convert.ToInt32(tokens_n[1]);
            string[] expenditure_temp = Console.ReadLine().Split(' ');
            int[] expenditure = Array.ConvertAll(expenditure_temp,Int32.Parse);
            int result = activityNotifications(expenditure, d);
            Console.WriteLine(result);
        }

    }
}