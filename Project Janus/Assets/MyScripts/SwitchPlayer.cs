using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPlayer : MonoBehaviour
{

    public GameObject player1, player2;

    int activePlayer = 1;


    // Start is called before the first frame update
    void Start()
    {
        player1.gameObject.SetActive(true);
        player2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            ChangePlayer();
        }
    }

    public void ChangePlayer()
    {
        switch (activePlayer)
        {
            case 1:
                activePlayer = 2;

                player1.gameObject.SetActive(false);
                player2.gameObject.SetActive(true);
                break;


            case 2:
                activePlayer = 1;

                player1.gameObject.SetActive(true);
                player2.gameObject.SetActive(false);
                break;
        }
    }
}
