using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_starte_story : MonoBehaviour {

  
    public GameObject GameEndPanel;
 
    public GameObject Countdown;
    public GameObject gameStart;
    public Text starttext;
    public Text counttext;
    private int Counter = 0;
    bool timestarts = false;
    public GameObject Objectivespanel;

    public GameObject[] UIlist = new GameObject[6];



    void Start()
    {


        DoFreeze();
        Cursor.lockState = CursorLockMode.None;

        for (int i = 0; i < UIlist.Length; i++)
        {
            UIlist[i].SetActive(false);
        }
        //Just making sure that the timeScale is right             
    }

    public void startgame(bool start)
    {
        Time.timeScale = 1;
        Objectivespanel.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        //Countdown.SetActive(true);
        //StartCoroutine("LoseTime");
        Counter = 1;
        Debug.Log("PAUSE");
    }

    public void DoFreeze()
    {
        var original = Time.timeScale;
        Time.timeScale = 0f;
    }

   

    void Update()
    {
        
        if (Counter == 1)
        {
            for (int i = 0; i < UIlist.Length; i++)
            {
                UIlist[i].SetActive(true);
            }
            Counter = 0;
            //Countdown.SetActive(false);
            //timestarts = true;
           // gameStart.SetActive(true);

        }

    }

    //IEnumerator LoseTime()
    //{
    //    while (true)
    //    {
    //        yield return new WaitForSeconds(1);
    //        Counter--;
    //        if (timestarts == true)
    //        {
    //            gameStart.SetActive(false);

    //        }

    //    }
    //}
}


