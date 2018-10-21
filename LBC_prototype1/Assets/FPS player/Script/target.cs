using UnityEngine;

public class target : MonoBehaviour {

    public int health = 50;
    public GameObject objective;

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
        objective_marker ob = objective.GetComponent<objective_marker>();
        ob.addkill(1);
        Destroy(gameObject);
    }
}
