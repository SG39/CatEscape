using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] GameObject applePrefab;
    [SerializeField] GameObject bombPrefab;
    private float delta = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;

        if(delta > 3f)
        {
            randomItem();
            delta = 0f;
        }

    }

    private void randomItem()
    {
        int randomItem = UnityEngine.Random.Range(0, 2);
        
        if(randomItem == 0)
        {
            GameObject Apple;
            Apple = Instantiate(this.applePrefab);
            int posX = UnityEngine.Random.Range(-1, 2);
            int posZ = UnityEngine.Random.Range(-1, 2);
            Vector3 ApplePos = new Vector3(posX, 3, posZ);
            Apple.transform.position = ApplePos;
        }
        else if(randomItem == 1)
        {
            GameObject Bomb;
            Bomb = Instantiate(this.bombPrefab);
            int posX = UnityEngine.Random.Range(-1, 2);
            int posZ = UnityEngine.Random.Range(-1, 2);
            Vector3 BombPos = new Vector3(posX, 3, posZ);
            Bomb.transform.position = BombPos;
        }
        else
        {
            Debug.Log("랜덤 범위 오류");
        }
        
    }

    

}
