using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResultDiretor : MonoBehaviour
{
    private GameObject BascetData;
    private BascetGameData bascetGameData;
    private GameObject TextUI;
    private Text Score;
    void Start()
    {
        this.BascetData = GameObject.Find("BascetGameData");
        this.bascetGameData = BascetData.GetComponent<BascetGameData>();
        this.TextUI = GameObject.Find("ScoreNum");
        this.Score = TextUI.GetComponent<Text>();

        Score.text = string.Format("{0}", bascetGameData.GameScore);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
