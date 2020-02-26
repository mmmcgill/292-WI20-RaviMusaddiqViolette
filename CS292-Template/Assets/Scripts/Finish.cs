using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
	
	//[SerializeField]
	public ScoreManager scoreManager;

	void Start(){
		scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
	}

    	void OnTriggerEnter2D(Collider2D collider){
		GameObject hitObj = collider.gameObject;

		if (hitObj.tag == "Player" && scoreManager.score == 3) {
			GameOver();
		}

    	}

	private void GameOver(){
      	  SceneManager.LoadScene(0); 
        }
}
