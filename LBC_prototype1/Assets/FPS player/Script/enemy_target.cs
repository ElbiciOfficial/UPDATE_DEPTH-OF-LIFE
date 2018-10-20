using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_target : MonoBehaviour {

    public GameObject target; //target
    public float speed; //speed

   
    void Update()
    {
        transform.LookAt(target.transform);
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

}
