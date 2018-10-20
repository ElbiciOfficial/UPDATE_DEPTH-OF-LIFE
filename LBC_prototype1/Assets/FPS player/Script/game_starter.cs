using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class game_starter : MonoBehaviour
{
    private GameObject[] numofenemy;

    public GameObject countdown;
    public Text cdtime;
    public GameObject GameEndPanel;

    public int numberofspawn;
        
    public GameObject enemyspawn1;
    public GameObject enemyspawn2;
    public GameObject enemyspawn3;
    public GameObject enemyspawn4;
    public GameObject enemyspawn5;
    public GameObject enemyspawn6;

    public GameObject Countdown;
    public GameObject gameStart;
    public Text starttext;
    public Text counttext;
    private int Counter = 5;
    bool timestarts = false;

    void Start()
    {
        Countdown.SetActive(true);
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right             
      

    }

    public float timeLeft = 30.0f;

    void Update()
    {
         counttext.text = Counter.ToString();
        if (Counter == -1)
        {
            Countdown.SetActive(false);
            timestarts = true;
            gameStart.SetActive(true);

            enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
            enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
            enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
            enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
            enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
            enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

            enemy1.startspawn(true);
            enemy2.startspawn(true);
            enemy3.startspawn(true);
            enemy4.startspawn(true);
            enemy5.startspawn(true);
            enemy6.startspawn(true);

          
            countdown.SetActive(true);
      
        }

        numofenemy = GameObject.FindGameObjectsWithTag("Enemy");
        Debug.Log("Enemy spawn: " + numofenemy.Length);

        if (numofenemy.Length >= numberofspawn)
        {
            enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
            enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
            enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
            enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
            enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
            enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

            enemy1.startspawn(false);
            enemy2.startspawn(false);
            enemy3.startspawn(false);
            enemy4.startspawn(false);
            enemy5.startspawn(false);
            enemy6.startspawn(false);

        }
        else if(numofenemy.Length < numberofspawn)
        {
            enemy_spawn enemy1 = enemyspawn1.GetComponent<enemy_spawn>();
            enemy_spawn enemy2 = enemyspawn2.GetComponent<enemy_spawn>();
            enemy_spawn enemy3 = enemyspawn3.GetComponent<enemy_spawn>();
            enemy_spawn enemy4 = enemyspawn4.GetComponent<enemy_spawn>();
            enemy_spawn enemy5 = enemyspawn5.GetComponent<enemy_spawn>();
            enemy_spawn enemy6 = enemyspawn6.GetComponent<enemy_spawn>();

            enemy1.startspawn(true);
            enemy2.startspawn(true);
            enemy3.startspawn(true);
            enemy4.startspawn(true);
            enemy5.startspawn(true);
            enemy6.startspawn(true);

        }
        
        if(timestarts == true)
        {
            if(timeLeft < 0)
            {
                countdown.SetActive(false);
                timeLeft = 0;
                GameOver();
            }
            else if(timeLeft >= 0)
            {
                timeLeft -= Time.deltaTime;
                cdtime.text = timeLeft.ToString("F2");            
            }
           
        }
     

    }

    void GameOver()
    {
        GameEndPanel.SetActive(true);
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Counter--;
            if (timestarts == true)
            {
                gameStart.SetActive(false);
                
            }
            
        }
    }
}
