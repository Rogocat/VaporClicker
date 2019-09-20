using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonShop : MonoBehaviour
{
    public GameObject ShopScreen;
    bool Quit;
    // Start is called before the first frame update
    void Start()
    {
        ShopScreen.SetActive(false);
        Quit = false;
    }

    void OnMouseDown() //Nur auf den Bereich vom Collider

    {
        if (Input.GetMouseButtonDown(0)) //One Finger on TouchScreen

        {
            Debug.Log("MeButton");
            ShopScreen.SetActive(true);
            Quit = true;
            //currentParticleSystem.GetComponent<ParticleSystem>().Play(); //Plays PArticle System
        }

        ////else
        ////{
        ////    if (Quit == true)

        ////    {
        ////        ShopScreen.SetActive(false);
        ////    }
        ////}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
