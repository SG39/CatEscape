using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// 모노 클래스 : new 사용하지 않는다.
public class App : MonoBehaviour
{
    public enum PlatfromType // 열거형식 정의
    {
        PC, Android, iOS
    }
    [SerializeField]
    private PlatfromType platfromType;

    // 멤버 변수
    [SerializeField] // 인스펙터창에서만 노출 시키고 싶을때
    private int hp = 0;
    [SerializeField]
    private float exp = 11.33f;
    [SerializeField]
    private bool isGameOver = false;

    [SerializeField]
    private string appName = "myApp";

    [SerializeField]
    private GameObject[] arrGameObject;

    [SerializeField]
    private List<Transform> arrTransForms;

    private void Awake(/*매개변수*/) 
    {
        Debug.Log("Awake실행");
        // 지역변수 
        Debug.LogFormat("hp : {0}", hp); // 유니티상 출력 포멧
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello Unity!");
        // 클래스의 현재 인스턴스
        //this

        // 현재인스턴스가 붙어있는 게임오브젝트
        // this.gameObject

        // App컴포넌트가 붙어있는 게임오브젝트의 트랜스폼 컴포넌트
        // this.gameObject.transform
        // == this.trancform

        // App컴포넌트가 붙어있는 게임오브젝트의 트랜스폼 컴포넌트의 포지션 속성
        // this.gameObject.transform.position

        // Vector3 pos = this.gameObject.transform.position;
        // Debug.Log(pos);
        // Debug.Log(this);
        // Debug.Log(this.gameObject);
        // Debug.Log(this.gameObject.transform);
        // Debug.Log(this.transform);

        Vector3 targetPosition = this.transform.position + new Vector3(0, 0 ,1);
        Debug.LogFormat("targetPosition{0}",targetPosition);

    }

}
