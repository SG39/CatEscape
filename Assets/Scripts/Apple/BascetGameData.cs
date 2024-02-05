using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BascetGameData : MonoBehaviour
{
    private float gameScore;
    public float GameScore
    {
        get
        {
            return this.gameScore;
        }
        set
        {
            this.gameScore = value;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }


}
