using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float bulletSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        DestroyBullet();
    }

    private void Shoot()
    {
        this.transform.Translate(transform.up * this.bulletSpeed * Time.deltaTime);
        
    }

    private void DestroyBullet()
    {
        Debug.Log(this.transform.position.y);
        if(this.transform.position.y > 5)
        {
            Destroy(this.gameObject);
        }
    }
}
