using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BascetGameManager : MonoBehaviour
{
    private GameObject GameData;
    private BascetGameData bascetGameData;
    private float score = 0;
    [SerializeField] private float gameTime = 60f;

    private void Start()
    {
        this.GameData = GameObject.Find("BascetGameData");
        this.bascetGameData = GameData.GetComponent<BascetGameData>();    
    }
    public float Score
    {
        get
        {
            return score;
        }
        set
        {
            this.score = value;
        }
    }
    public float GameTime
    {
        get
        {
            return gameTime;
        }
    }

    public void AddScore(float addScore)
    {
        this.score += addScore;
    }

    public void DiScore(float diScore)
    {
        this.score *= diScore;
        if(this.score <= 0.99)
        {
            this.score = 0;
        }
    }

    private void Update()
    {
        this.gameTime -= Time.deltaTime;
        //Debug.Log(gameTime);

        if(this.gameTime <= 0)
        {
            this.bascetGameData.GameScore = this.score;
            SceneManager.LoadScene(1);
        }
    }


    
}
