using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    private GameObject carGo;
    private GameObject flagGo;
    private GameObject distanceGo; // text
    private Text distanceText; // distance오브젝트의 Text로 접근하기
    private string carToflagLength;


    // Start is called before the first frame update
    void Start()
    {
        this.carGo = GameObject.Find("car");
        Debug.LogFormat("this.carGo : {0}",carGo); // car 게임오브젝트의 인스턴스

        this.flagGo = GameObject.Find("flag");
        Debug.LogFormat("this.carGo : {0}",flagGo); // flag 게임오브젝트의 인스턴스

        this.distanceGo = GameObject.Find("distance");
        Debug.LogFormat("this.distanceGo : {0}",distanceGo);// distance 게임오브젝트의 인스턴스
        
        
        distanceText = this.distanceGo.GetComponent<Text>();// distance오브젝트의 Text로 접근하기
        Debug.LogFormat("distanceText : {0}",distanceText);

        distanceText.text = "안녕하세요";
    }

    // Update is called once per frame
    void Update()
    {
        // 자동차와 깃발의 거리 계산
        float length = this.carGo.transform.position.x - this.flagGo.transform.position.x;
        // Debug.Log(length);
        carToflagLength = length.ToString("#.##");

        distanceText.text = "남은 거리 : " + carToflagLength + "m";
    }
}
