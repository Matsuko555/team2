using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float lifetime;
    [SerializeField] private GameObject BulletPrefab;
    private GameObject Bullet;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Bullet = Instantiate(BulletPrefab, transform.position, BulletPrefab.transform.rotation);
            rb = Bullet.GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * bulletSpeed);
            Destroy(Bullet, lifetime);
        }
    }
}
