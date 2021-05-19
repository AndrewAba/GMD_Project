using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCameraControl : MonoBehaviour
{

    public float Sensitivity = 100f;

    public Transform PlayerBody;

    float xRot = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        // delta time is used in order to keep the camera movemnt locked to the number of frames
        float mX = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float mY = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xRot -= mY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        PlayerBody.Rotate(Vector3.up * mX);
    }
}
