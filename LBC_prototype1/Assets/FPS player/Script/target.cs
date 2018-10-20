using UnityEngine;

public class target : MonoBehaviour {

    public int health = 50;
 

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
        Destroy(gameObject);
    }
}
