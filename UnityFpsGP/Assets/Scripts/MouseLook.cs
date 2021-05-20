using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 90f;

    public Transform player;

    float xRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("=")) {
            mouseSensitivity += 10;
            Debug.Log(mouseSensitivity);
        }
        if (Input.GetKeyDown("-") && mouseSensitivity>10)
        {
            mouseSensitivity -= 10;
            Debug.Log(mouseSensitivity);
        }
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        player.Rotate(Vector3.up * mouseX);
    }

    public void changeSensitivity(float _sensitivity)
    {
        mouseSensitivity = _sensitivity;
    }
}
    