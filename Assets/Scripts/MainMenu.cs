using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text scoreText;


	// Use this for initialization
	private void Start () {
        scoreText.text = "Highscore : " + PlayerPrefs.GetInt("score").ToString();
    }
	
	// Update is called once per frame
	public void ToGame()
    {
        SceneManager.LoadScene("game");
	}
}
