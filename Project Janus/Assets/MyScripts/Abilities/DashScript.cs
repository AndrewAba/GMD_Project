using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashScript : MonoBehaviour
{
    public float dashSpeed;
    public float dashTime;
    PlayerMovement moveScript;


    // Start is called before the first frame update
    void Start()
    {
        moveScript = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            StartCoroutine(Dashy());
        }
    }

    IEnumerator Dashy()
    {
        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            moveScript.controller.Move(moveScript.moveDirection * dashSpeed * Time.deltaTime);

            yield return null;
        }
    }
}
