using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class BascetController : MonoBehaviour
{
    [SerializeField] private AudioClip appleSfx;
    [SerializeField] private AudioClip bombsSfX;
    private AudioSource audioSource;
    private GameObject gameManager;
    private BascetGameManager bascetGameManager;
    [SerializeField] private float appleScore = 100f;
    [SerializeField] private float BombScore = 0.5f;

    void Start()
    {
        this.audioSource = this.GetComponent<AudioSource>();
        this.gameManager = GameObject.Find("BascetGameManager");
        this.bascetGameManager = gameManager.GetComponent<BascetGameManager>();
    }


    void Update()
    {
        MoveBascet();
    }

    private void MoveBascet()
    {
        // 화면 터치시 터치 위치로 바스켓 움직이기
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(ray.origin, ray.direction, out hit, 20f))
            {
                int posX = Mathf.RoundToInt(hit.point.x);
                int posZ = Mathf.RoundToInt(hit.point.z);
                this.transform.position = new Vector3(posX, 0 ,posZ);
            }
        }
    }

    private void OnTriggerEnter(Collider other) 
    {
        Debug.Log("잡았다!");
        Debug.Log(other.gameObject.tag);

        if(other.gameObject.tag == "Item")
        {
            Debug.Log("득점");
            this.bascetGameManager.AddScore(appleScore);
            this.audioSource.PlayOneShot(this.appleSfx);
        }
        if(other.gameObject.tag == "Bomb")
        {
            Debug.Log("감점");
            this.bascetGameManager.DiScore(BombScore);
            this.audioSource.PlayOneShot(this.bombsSfX);
        }
        Destroy(other.gameObject);
    }
}
