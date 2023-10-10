using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizOneCodingChallenge : MonoBehaviour
{
    // Declare Variables

    private int Health= 100;

    // Start is called before the first frame update
    // Public Member/Gobal Variables
    public int Score = 0;
    public string PlayerName = "Achilles";

    // Private Member/Gobal Variables
    private int _totalScore = 0;
    private string _userName = "Achilles";

    void Start()
    {
        IncreaseScore();
        PrintPlayerName();
        DecreaseHealth();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void IncreaseScore()
    {
        // using a local variable to update the total score
        Score += 10;
    }

    private void PrintPlayerName()
    {
        Debug.Log(PlayerName);
    }

    private void DecreaseHealth()
    {
        Health -= 20;
    }
}
