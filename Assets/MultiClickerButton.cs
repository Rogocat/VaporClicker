using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MultiClickerButton : MonoBehaviour
{
    public int ScoreCheck;
    private Touchh touchh;
    bool locked;
    public int MultiPrice;
    public int counterX;

    public Text ButtonSetActive;
    public Text ClickCountResult;
    

    // Start is called before the first frame update

    void Awake()
    {
        touchh = GameObject.Find("Touch").GetComponent<Touchh>();
        MultiPrice = PlayerPrefs.GetInt("MultiPrice", MultiPrice);
        //gets the other public int,, gameobject + script wird auf diese script angeordnetet
    }

    void Start()
    {
   

    }

    public void OnMouseDown()
    {
        //if (Input.GetMouseButtonDown(0))
        //   {
        //       //Debug.Log("Nice Score plz work" + touchh.score);

        //Debug.Log("Activated");

        if (locked == false)
            {
            touchh.score = ScoreCheck - MultiPrice;
            Debug.Log("Gimme");
            touchh.MultiClicker();


            StartCoroutine("MultiPriceResultCount");
           


            }

            if (locked == true)
            {
                Debug.Log("NOMulti");
     
            }

        }

    void MultiPriceResultCount()
    {
        touchh = GameObject.Find("Touch").GetComponent<Touchh>();

        counterX = touchh.x;
        //MultiPrice = Mathf.Pow(ScoreCheck);
        MultiPrice = counterX * 200;
    }



    // Update is called once per frame
    void Update()
    {
        ScoreCheck = touchh.score;
        //MultiPrice = Mathf.Pow(ScoreCheck, 1.2f);  Sonst ändert sich nonstop --> result?
        //if (ScoreCheck < 30)
        //    MultiPrice = 30;

        PlayerPrefs.SetInt("MultiPrice", MultiPrice);
        PlayerPrefs.Save();

        if (ScoreCheck < MultiPrice)
        {
            locked = true;
            ButtonSetActive.color = Color.red;

        }

        if (ScoreCheck > MultiPrice)
        {
            locked = false;
            ButtonSetActive.color = Color.green;

        }

        ClickCountResult.text = "if (HACKED DATA > " + MultiPrice.ToString() +") \n Click + 1";
    }
}
