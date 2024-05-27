using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    private int currentScore = 0;
    public TextMeshProUGUI scoreText;
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseScore(int increaseScore)
    {
        currentScore += increaseScore;
        scoreText.text = "Score: " + currentScore.ToString();
    }

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
