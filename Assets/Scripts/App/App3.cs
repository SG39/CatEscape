using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App3 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private GameObject playerGo; // 게임오브젝트 변수 xxxGo

    [SerializeField]
    private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        // Vector2 playerPos = new Vector2(3.0f, 4.0f);
        // playerGo.transform.position = playerPos;

        // playerPos.x += 8.0f;
        // playerPos.y += 5.0f;

        // Debug.LogFormat("playerGo.transform.position : {0}", playerGo.transform.position); // 3, 4, 0

        // Debug.LogFormat("player.Pos : {0}", playerPos); // 11, 9

        // playerGo.transform.position = playerPos;
    }

    // Update is called once per frame
    void Update()
    {
        //? 방향 * 속도* 시간 => move

        // Vector3 pos = new Vector3(1, 0, 0);
        // playerGo.transform.position += pos;

        playerGo.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
