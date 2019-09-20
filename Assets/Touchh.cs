using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Touchh : MonoBehaviour
{
    //private MultiClickerButton multiClickerButton;
    public int score;
    public Text ScoreText;
    //public GameObject FirstMessage;
    public int x = 0;
    public int y = 0;
    //public static Touchh instance = null; //Idk

    //public GameObject particle;
    //GameObject currentParticleSystem;
    public Material rimm;

    public float timer;
    public bool timeStarted = true;

    public Text Multiclickertext;
    public Text GhostText;

    public float rimbase = 1f;
    // Start is called before the first frame update
    void Awake()
    {
        score = PlayerPrefs.GetInt("score", score);
        x = PlayerPrefs.GetInt("x", x);
        y = PlayerPrefs.GetInt("y", y);

        //multiClickerButton = GameObject.Find("MultiClickerButton").GetComponent<MultiClickerButton>();

    }

    void Start()
    {
        //currentParticleSystem = Instantiate(particle);

        //if (instance == null)
        //{
        //    instance = this;
        //}

        score = PlayerPrefs.GetInt("score", score);

        //FirstMessage.SetActive(false);

        ScoreText.text = "SCORE\n" + score.ToString();

        ResetInvoke();

        //rimm = GetComponent<Renderer>().material;
        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        rimm.SetFloat("_RimPower", rimbase);


    }


    void OnMouseDown() //Nur auf den Bereich vom Collider

    {
        if (Input.GetMouseButtonDown(0)) //One Finger on TouchScreen

        {
            score += 1 + x;
            ScoreText.text = "SCORE\n" + score;

            //currentParticleSystem.GetComponent<ParticleSystem>().Play(); //Plays PArticle System

            if (rimbase > 0.2f)
            {
                rimm.SetFloat("_RimPower", this.rimbase -= 0.05f);
            }


        }
    }

    // Update is called once per frame
    void Update()
    {

        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("x", x);
        PlayerPrefs.SetInt("y", y);
        PlayerPrefs.Save();

        ScoreText.text = "SCORE\n" + score;


        if (rimbase < 1.5f)
        {
            rimm.SetFloat("_RimPower", this.rimbase += 0.005f);
        }

        if (timeStarted == true)
        {
            timer += Time.deltaTime;
        }

        //if (timer > 20)
        //{
        //    score += 1;
        //}

        Multiclickertext.text = "MULTI\n" + x.ToString();

        GhostText.text = "GHOST\n" + y.ToString();

        // if (Input.GetKeyDown(KeyCode.S))
        // {
        //     PlayerPrefs.SetInt("score", score);
        //     PlayerPrefs.Save();
        //     Debug.Log("Saved");
        // }

        //if (Input.GetKeyDown(KeyCode.L))
        // {
        //     Debug.Log("Loaded");
        //   score = PlayerPrefs.GetInt("score", score);
        // }

        if (Input.GetKeyDown(KeyCode.D))
            {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();

            score = 0;
            x = 0;
            y = 0;
        }
  

    }

    public void GhostPriceResultCount()
    {
        y += 1;
        CancelInvoke();
        ResetInvoke();

    }

    public void ResetInvoke()
    {

        InvokeRepeating("Ghost", 5f, 5f);

    }

    public void Ghost()
    {
        score += y;
    }

    public void MultiClicker()
    {
        x +=1;
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("x", x);
        PlayerPrefs.SetInt("y", y);
        PlayerPrefs.Save();
    }


}


