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
public Animator animator;
public bool facingRight = true; //Depends on if your animation is by default facing right or left

    
    



    void Start(){
rb= GetComponent<Rigidbody2D>();
originalPosition = transform.localPosition;
        hitSource = GetComponent<AudioSource>();

}

void Update()
{
    float horizontal = joystick.Horizontal;
    float vertical= joystick.Vertical;
        
    if (horizontal > 0 && !facingRight)
        Flip();
    else if (horizontal < 0 && facingRight)
        Flip();

        //animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        animator.SetFloat("Horizontal", joystick.Horizontal);

Vector3 horizontal2 = new Vector3(Input.GetAxis("Horizontal"), 0.0f, 0.0f);


Vector2 position =rb.position;
	
		position.x = position.x + speed * horizontal * Time.deltaTime;

	
		position.y = position.y + speed * vertical * Time.deltaTime;
			

rb.MovePosition(position);
CheckCollisions();



}

private void OnTriggerEnter2D(Collider2D other) {

	if(other.gameObject.CompareTag("Acorns")){
		Destroy(other.gameObject);
	}


}

    private void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
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