using UnityEngine;

public class target : MonoBehaviour {

    public int health = 50;
    public GameObject objective;
    objective_marker objc;

     void Start()
    {
        objective = GameObject.FindGameObjectWithTag("GameController");
        objc = objective.GetComponent<objective_marker>();
    }
    public void takedamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            die();
        }
    }

    public void die()
    {
        //objective_marker ob = objective.GetComponent<objective_marker>();
        objc.addkill(1);
        Destroy(gameObject);
    }
}
