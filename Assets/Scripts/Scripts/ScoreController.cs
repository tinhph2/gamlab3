using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    private static ScoreController instance;
    public static ScoreController Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<ScoreController>();
            }
            return instance;
        }
    }
    private int score = 0;
    public void IncreaseScore(int value)
    {
        score += value;
        Debug.Log("Score Increased! New Score: " + score);
    }
}
