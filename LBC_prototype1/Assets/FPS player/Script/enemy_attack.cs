using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_attack : MonoBehaviour {

   
    public GameObject paintballprefab;
    private GameObject _paintball;
    private float nexttimetofire = 2f;
    public float firerate = 20f;

    void Update () {
		
	}
    
    private void OnTriggerStay(Collider other)
    {
        if (other.GetComponent<player_info>() && Time.time >= nexttimetofire && _paintball == null)
        {
            nexttimetofire = Time.time + 5f / firerate;
            _paintball = Instantiate(paintballprefab) as GameObject;
            _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.1f);
            _paintball.transform.rotation = transform.rotation;

        }
        //if (other.GetComponent<player_info>())
        //{
        //    if (_paintball == null)
        //    {
        //        _paintball = Instantiate(paintballprefab) as GameObject;
        //        _paintball.transform.position = transform.TransformPoint(Vector3.forward * 1.1f);
        //        _paintball.transform.rotation = transform.rotation;
        //    }
        //}
    }
    
}
