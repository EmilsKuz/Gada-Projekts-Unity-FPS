using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScriptProject : MonoBehaviour
{
    public Camera cam;
    public GameObject projectile;
    public Transform FirePoint;
    public float damage = 10f;
    public float projectileSpeed = 30;
    private Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) {

            ShootProjectile();
        }
    }

    void ShootProjectile() {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(1000);
        }


        InstantianteProjectile();

        

    }
    void InstantianteProjectile() {
        var projectileObj = Instantiate(projectile, FirePoint.position,Quaternion.identity)as GameObject;
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - FirePoint.position).normalized * projectileSpeed;
    
    }
}
