using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
                if (_instance == null)
                {
                    GameObject obj = new GameObject();
                    obj.name = "GameManager";
                    _instance = obj.AddComponent<GameManager>();
                }
            }
            return _instance;
        }
    }

    private int score = 0;

    public void IncreaseScore()
    {
        score++;
        Debug.Log("Score: " + score); 
    }
}
