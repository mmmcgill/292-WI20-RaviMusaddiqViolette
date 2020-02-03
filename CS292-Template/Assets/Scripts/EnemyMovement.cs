using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeed = 4f;
    public bool moveUp = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.localPosition;

	if (moveUp) {
	//moving up
		position.y += Vector2.up.y * moveSpeed * Time.deltaTime;
	
		if (position.y >= 895) {
			position.y = -40;
		}
	}
	else {
	//moving down
		position.y += Vector2.down.y *moveSpeed * Time.deltaTime;
	
		if (position.y <= -40) {
			position.y = 895;
		}
	}
	
		
	transform.localPosition = position;
    }
}
