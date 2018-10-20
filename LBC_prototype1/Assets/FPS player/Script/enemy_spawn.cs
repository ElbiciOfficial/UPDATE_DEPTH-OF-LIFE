using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spawn : MonoBehaviour {

    public GameObject ball;
    public float spawnTime = 3f;
   
    public GameObject spawn;

    private bool start = false;

    // Use this for initialization
    void Start()
    {
       
        InvokeRepeating("SpawnBall", spawnTime, spawnTime);
        
    }

    void SpawnBall()
    {
        if(start == true)
        {
            var newspawn = spawn.transform.position;
            var newBall = GameObject.Instantiate(ball);
            newBall.transform.position = newspawn;
        }
    
    }
    
    public void startspawn(bool enemy) {
        start = enemy;
    }
}
