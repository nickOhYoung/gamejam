using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
    public Text _gameOver;

    public Text _gameWin;

    GameObject Player;

    bool IsOver;

    bool IsWin;

	// Use this for initialization
	void Start () {
        DontDestroyOnLoad(transform.gameObject);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
   
    void Over()
    {
        if (IsOver)
        {
            _gameOver.enabled = true;
        }

        if (IsWin)
        {
            _gameWin.enabled = true;
        }
    }
}
