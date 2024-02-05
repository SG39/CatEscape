using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletGenerator : MonoBehaviour
{
    [SerializeField] private float generateTime = 0.5f;
    [SerializeField] GameObject BulletPrefab;
    private GameObject shootPos;
    private float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        shootPos = GameObject.Find("shootPos");
    }

    // Update is called once per frame
    void Update()
    {
        generateBullet();
    }

    private void generateBullet()
    {

        if(Input.GetKey(KeyCode.Z))
        {
            delta += Time.deltaTime;
            if(delta > generateTime)
            {
                GameObject Bullet;
                Bullet = Instantiate(BulletPrefab);

                Vector3 firePos = shootPos.transform.position;
                Bullet.transform.position = firePos;
                delta = 0;
            }

        }
    }


}
