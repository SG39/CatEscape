using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BascetGameDirector : MonoBehaviour
{
    private Text ScoerText;
    private GameObject Score;
    private Text TimeText;
    private GameObject Time;
    private GameObject gameManager;
    private BascetGameManager bascetGameManager;
    // Start is called before the first frame update
    void Start()
    {
        this.Score = GameObject.Find("Score");
        this.ScoerText = this.Score.GetComponent<Text>();
        this.Time = GameObject.Find("Time");
        this.TimeText = this.Time.GetComponent<Text>();
        this.gameManager = GameObject.Find("BascetGameManager");
        this.bascetGameManager = gameManager.GetComponent<BascetGameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        ScoerText.text = string.Format("{0}", bascetGameManager.Score);
        TimeText.text = string.Format("{0}",bascetGameManager.GameTime);
    }
}
