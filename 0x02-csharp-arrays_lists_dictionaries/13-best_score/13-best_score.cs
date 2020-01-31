using System.Collections.Generic;

class Dictionary {
    public static string BestScore(Dictionary<string, int> myList){
        if (myList == null)
            return "None";
        string best = "None";
        int score = 0;

        foreach((string k, int v) in myList){
            if (v > score)
                (best, score) = (k,v);
        }

        return score > 0 ? best : "None";
    }
}