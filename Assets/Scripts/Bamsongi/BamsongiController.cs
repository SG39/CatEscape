using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    private Rigidbody rbody;
    private ParticleSystem particleSystem;
    // Start is called before the first frame update
    void Start()
    {
        this.rbody = this.gameObject.GetComponent<Rigidbody>();
        this.particleSystem = this.gameObject.GetComponent<ParticleSystem>();
        // Shooting();
    }

    private void OnCollisionEnter(Collision other) 
    {
        Debug.LogFormat("OnCollisionEnter{0}",other.gameObject.name);  
        this.rbody.isKinematic = true;

        // 파티클 시스템 컴포넌트  
        this.particleSystem.Play();
    }

    private void Shooting(Vector3 dir)
    {
        this.rbody.AddForce(dir);
    }


}
