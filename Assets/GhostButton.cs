using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GhostButton : MonoBehaviour
{

    public int ScoreCheck;
    private Touchh touchh;
    bool locked;
    public int GhostPrice;
    public int counterY;

    public Text ButtonSetActive;
    public Text ClickCountResultGhost;

    // Start is called before the first frame update

    void Awake()
    {
        touchh = GameObject.Find("Touch").GetComponent<Touchh>();
        //gets the other public int,, gameobject + script wird auf diese script angeordnetet

       GhostPrice = PlayerPrefs.GetInt("GhostPrice", GhostPrice);
    }

    void Start()
    {
        
    }

    public void OnMouseDown()
    {

        if (locked == false)
        {
            touchh.score = ScoreCheck - GhostPrice;
            Debug.Log("GimmeGhost");
            touchh.GhostPriceResultCount();


            StartCoroutine("GhostPriceResultCount");

        }

        if (locked == true)
        {
            Debug.Log("NoGhost");

            //Vector3 newPosition = transform.position;
            //newPosition.x += 8;
            //Invoke("JumpBack", 0.1f);
            //transform.position = newPosition;

        }

    }

    //void JumpBack()
    //{
    //    Vector3 newPosition = transform.position;
    //    newPosition.x -= 8;
    //    transform.position = newPosition;

    //}

    void GhostPriceResultCount()
    {
        touchh = GameObject.Find("Touch").GetComponent<Touchh>();

        counterY = touchh.y;
       
        GhostPrice = counterY * 200;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("GhostPrice", GhostPrice);
        PlayerPrefs.Save();

        ScoreCheck = touchh.score;

        if (ScoreCheck < GhostPrice)
        {
            locked = true;
            ButtonSetActive.color = Color.red;

        }

        if (ScoreCheck > GhostPrice)
        {
            locked = false;
            ButtonSetActive.color = Color.green;

        }

        ClickCountResultGhost.text = "if (HACKED DATA > " + GhostPrice.ToString() + ") \n Time + 5 = Score + 1";
    }
}
