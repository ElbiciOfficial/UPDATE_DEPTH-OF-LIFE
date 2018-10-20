using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_spawn : MonoBehaviour {

    public GameObject energy;
    public Item_limiter count;
    public GameObject spawn;
    private GameObject energy_spawn;

    private bool start = false;

    // Use this for initialization
    void Start()
    {
       
            Invoke("Spawnenergy", Random.Range(20, 100));       

    }

     void Update()
    {
       
    }

    void Spawnenergy()
    {
        float randomTime = Random.Range(20, 100);

         if (energy_spawn == null)
        {
          
            if (start == true)
            {
                
                energy_spawn = Instantiate(energy, transform.position, transform.rotation);
                
            }
            //var newspawn = spawn.transform.position;
            //var newEnergy = GameObject.Instantiate(energy);
            //newEnergy.transform.position = newspawn; 
        }
        Invoke("Spawnenergy", randomTime);
    }
    public void startspawn(bool item)
    {
        start = item;
    }
}

