using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Finish : MonoBehaviour
{
	
	public ScoreManager scoreManager;
	public float currentTime = 0f;
   	public float startingTime = 60f;
	public Text highscore;
    
      	void Start(){
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
		currentTime = startingTime;

		if (PlayerPrefs.HasKey("Highscore") == true){
			highscore.text = PlayerPrefs.GetFloat("Highscore").ToString();
		} else {
			highscore.text = "No High Scores Yet";
		}
	}

    	void OnTriggerEnter2D(Collider2D collider){
		GameObject hitObj = collider.gameObject;

		if (hitObj.tag == "Player" && scoreManager.score == 3) {
			if (PlayerPrefs.GetFloat("Highscore")<currentTime){
				SetHighscore();
			}
			GameOver();
		}

    	}

	public void SetHighscore(){
		int score = (int) currentTime;
		PlayerPrefs.SetInt("Highscore", score);
		highscore.text = PlayerPrefs.GetInt("Highscore").ToString();	
	}

	void Update() {
        	currentTime -= 1 * Time.deltaTime;
        }

	private void GameOver(){
      	  SceneManager.LoadScene(0); 
        }
}
