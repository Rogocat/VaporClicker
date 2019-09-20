using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsideShop : MonoBehaviour
{
    public GameObject Quit;
    bool Activee;
    // Start is called before the first frame update
    void Start()
    {
        Quit.SetActive(true);
        Activee = true;
    }

    void OnMouseDown() //Nur auf den Bereich vom Collider

    {
        if (Input.GetMouseButtonDown(0)) //One Finger on TouchScreen

        {
            Debug.Log("MeButton");
            Quit.SetActive(false);
            Activee = false;
        }
        else
        {
            if (Activee == false)

            {
                Quit.SetActive(true);
            }
        }

        //if (Activee == false)

        //{
        //    Quit.SetActive(true);
        //}

        //currentParticleSystem.GetComponent<ParticleSystem>().Play(); //Plays PArticle System
    }


    // Update is called once per frame
    void Update()
    {

    }
}
