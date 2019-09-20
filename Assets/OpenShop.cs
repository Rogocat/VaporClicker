using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenShop : MonoBehaviour

{
    public GameObject InsideShop;
    public GameObject MulticlickerButton;
    public GameObject MultiClickerButtonText;
    public GameObject ShopText;
    public GameObject ShopButton;
    public GameObject ShopButtonText;
    public GameObject ShopText2;
    public GameObject GhostButton;
    public GameObject GhostButtonText;
    public GameObject HelloText;
 

    public void OpenInsideShopPlane()

    {
        if (InsideShop != null)
        {
            bool isActive = InsideShop.activeSelf;

            InsideShop.SetActive(!isActive);
            //To toggle this button
        }


    }

    public void OpenHelloText()
    {
        if (HelloText != null)
        {
            bool isactive = HelloText.activeSelf;

            HelloText.SetActive(!isactive);
        }

    }

    public void OpenShopText()
    {
        if (ShopText != null)
        {
            bool isActive = ShopText.activeSelf;

            ShopText.SetActive(!isActive);
        }
    }


    public void OpenMulticlickerButton()
    {

        if (MulticlickerButton != null)
        {
            bool isActive = MulticlickerButton.activeSelf;

            MulticlickerButton.SetActive(!isActive);
        }
    }

    public void OPenMulitClickerButtonText()
    {
        if (MultiClickerButtonText != null)
        {
            bool isActive = MultiClickerButtonText.activeSelf;

            MultiClickerButtonText.SetActive(!isActive);

        }
    }

    public void OpenShopBUtton()
    {
        if (ShopButton != null)
        {
            bool isActive = ShopButton.activeSelf;

            ShopButton.SetActive(!isActive);

        }
    }

        public void OpenShopBUttonText()
        {
            if (ShopButtonText != null)
            {
                bool isActive = ShopButtonText.activeSelf;

                ShopButtonText.SetActive(!isActive);

            }
        }

    public void OpenShopText2()
    {
        if (ShopText2 != null)
        {
            bool isActive = ShopText2.activeSelf;

            ShopText2.SetActive(!isActive);

        }
    }

    public void OpenGhostButton()
    {
        if (GhostButton != null)
        {
            bool isActive = GhostButton.activeSelf;

            GhostButton.SetActive(!isActive);
        }
    }

    public void OpenGhostButtonText()
    {
        if (GhostButtonText != null)
        {
            bool isActive = GhostButtonText.activeSelf;

            GhostButtonText.SetActive(!isActive);

        }
    }
}
