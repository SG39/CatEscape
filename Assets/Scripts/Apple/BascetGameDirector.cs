using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class BascetGameDirector : MonoBehaviour
{
    private Text ScoerText;
    private GameObject Score;
    // Start is called before the first frame update
    void Start()
    {
        this.Score = GameObject.Find("Score");
        this.ScoerText = this.Score.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
