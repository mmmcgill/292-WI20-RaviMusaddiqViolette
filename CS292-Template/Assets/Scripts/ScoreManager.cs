using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
	public static ScoreManager instance;
	public TextMeshProUGUI text;
	public int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null){
		instance = this;
	}
    }

    public void ChangeScore(int acornValue){
	score += acornValue;
	text.text = "X" + score.ToString();
    }
}
