using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatEscapeGameDirector : MonoBehaviour
{
    [SerializeField] private Image hpGauge;
    private GameObject player;

    public void Start()
    {
        this.player = GameObject.Find("player");
    }
    public void DecreaseHp()
    {
        this.hpGauge.fillAmount -= 0.1f;
    }

    public float GetHp()
    {
        return this.hpGauge.fillAmount;
    }
}
