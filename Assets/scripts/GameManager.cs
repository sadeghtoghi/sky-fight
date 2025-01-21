using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public bool GameIsOn;
    public bool PlayerIsAlive;
    public bool PlayerDoesnotHaveEnoughScores;
    public static GameManager Instance;


    private void Awake()
    {
        Instance = this;
        
}

    private void Start()
    {
        
        GameIsOn = true;
        PlayerIsAlive = true;
        PlayerDoesnotHaveEnoughScores = true;
    }
    private void Update()
    {
        if (PlayerIsAlive==true && PlayerDoesnotHaveEnoughScores)
        {
            GameIsOn = true;
        }
        else
        {
            GameIsOn=false;
        }
    }

}
