using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class start_game : MonoBehaviour {

    public GameObject gamemanager;
    public Button startbutton;
    
    void Start()
    {
        Button strt = startbutton.GetComponent<Button>();
            strt.onClick.AddListener(ToggleStart);
    }
    public void ToggleStart()
    {
        game_starter start = gamemanager.GetComponent<game_starter>();

        start.startgame(true);
    }
}
