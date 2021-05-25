using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScriptBalls : MonoBehaviour
{   
    public GameObject bulletPrefab;
    public Camera cam;
    public ParticleSystem muzzleFlash;
    public float fireRate = 0.25f;
    private float nextFire;
    AudioSource shoot;

    // Start is called before the first frame
    void Start()
    {
        shoot = GetComponent<AudioSource>();
    }
    
        // Update is called once per frame
        void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire && Time.deltaTime!=0 && Time.time>2) {
            nextFire = Time.time + fireRate;
            muzzleFlash.Play();
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = cam.transform.position + cam.transform.forward;
            bulletObject.transform.forward = cam.transform.forward;
            shoot.Play();
            
        }
    }
}
