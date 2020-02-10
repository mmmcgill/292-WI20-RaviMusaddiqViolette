using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

	public float moveSpeed = 3f;
	public bool moveUp = false;	

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.localPosition;

	if (moveUp) {
	// enemy moving up
		pos.y += Vector2.up.y * moveSpeed * Time.deltaTime;

		if (pos.y >= 7) {
			pos.y = -7;
		}

	} else {
	// enemy moving down
		pos.y += Vector2.down.y * moveSpeed * Time.deltaTime;

		if (pos.y <= -7) {
			pos.y = 7;
		}
	}

	transform.localPosition = pos;
	
    }
}
