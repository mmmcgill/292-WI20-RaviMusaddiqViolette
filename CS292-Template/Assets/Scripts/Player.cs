using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
	{
		Rigidbody2D rb;
		float speed = 5.0f;
private Vector2 originalPosition;
public Joystick joystick;
public AudioSource hitSource;

    void Start(){
rb= GetComponent<Rigidbody2D>();
originalPosition = transform.localPosition;
        hitSource = GetComponent<AudioSource>();

}

void Update()
{
float horizontal = joystick.Horizontal;
float vertical= joystick.Vertical;
Vector2 position =rb.position;
	
		position.x = position.x + speed * horizontal * Time.deltaTime;

	
		position.y = position.y + speed * vertical * Time.deltaTime;
			

rb.MovePosition(position);
CheckCollisions();
}
   
private void CheckCollisions(){
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Collide");

		foreach (GameObject go in gameObjects){
			CollidableObject collidableObject = go.GetComponent<CollidableObject>();

			if (collidableObject.IsColliding(this.gameObject)){
				if (collidableObject.isSafe){
					
				} else {
					transform.localPosition = originalPosition;
                    hitSource.Play();
					//transform.GetComponent<SpriteRenderer>().sprite = playerUp;
				}	

			}
		}
	}
}