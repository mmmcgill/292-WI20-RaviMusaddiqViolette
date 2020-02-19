using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider){
	GameObject hitObj = collider.gameObject;

	if (hitObj.tag == "Player"){
		GameOver();
	}

    }

	private void GameOver(){
      	  SceneManager.LoadScene(0); 
        }
}
