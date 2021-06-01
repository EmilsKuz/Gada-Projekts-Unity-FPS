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
    private bool shooting = false;
    AudioSource shoot;

    void Start()
    {
        Invoke("canShoot", 3.0f);
        shoot = GetComponent<AudioSource>();
    }
    
        void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire && Time.deltaTime!=0 && shooting) {
            nextFire = Time.time + fireRate;
            muzzleFlash.Play();
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = cam.transform.position + cam.transform.forward;
            bulletObject.transform.forward = cam.transform.forward;
            shoot.Play();
        }
    }

    public void canShoot() {
        
        shooting = true;
    }
}
