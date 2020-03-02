using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pausemenu2 : MonoBehaviour{

   public GameObject Pausemenu;
	public GameObject PauseButton;	

public void Pause()
{
Time.timeScale = 0;
}


public void Resume()
{
Time.timeScale = 1; 
} 





}
