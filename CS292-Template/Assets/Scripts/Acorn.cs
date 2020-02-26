using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acorn : MonoBehaviour
{
    public int acornValue = 1;

	private void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.CompareTag("Player")){
			ScoreManager.instance.ChangeScore(acornValue);
		}
	}
}
