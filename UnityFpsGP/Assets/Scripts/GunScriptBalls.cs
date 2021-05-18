using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScriptBalls : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Camera cam;
    public Transform FirePoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {
            GameObject bulletObject = Instantiate(bulletPrefab);
            bulletObject.transform.position = cam.transform.position + cam.transform.forward;
            bulletObject.transform.forward = cam.transform.forward;
        }
    }
}
