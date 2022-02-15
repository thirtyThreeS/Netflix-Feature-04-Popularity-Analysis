class Solution
{
    public static bool IdentifyTitles(int[] scores)
    {
        bool increasing = true;
        bool decreasing = true;

        for (int i = 0; i < scores.Length - 1; i++)
        {
            if (scores[i] > scores[i + 1]) increasing = false;
            if (scores[i] < scores[i + 1]) decreasing = false;
        }
        if (increasing == true) Console.WriteLine("Popularity Increasing!");
        if (decreasing == true) Console.WriteLine("Popularity Decreasing!");
        
        return increasing || decreasing;
    }

    public static void Main()
    {
        // Driver Code
        int[][] movieRatings = new int[][]
        {
            new int[]{ 1,2,2,3 },
            new int[]{ 4,5,6,3,4 },
            new int[]{ 8,8,7,6,5,4,4,1 }
        };
        foreach (var movieRating in movieRatings)
        {
            if (IdentifyTitles(movieRating)) Console.WriteLine("Title Identified and Separated.");
            else Console.WriteLine("Title Score Fluctuating");
            Console.WriteLine("---");
        }


    }
}