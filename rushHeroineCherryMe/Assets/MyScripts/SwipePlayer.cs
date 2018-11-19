using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipePlayer : MonoBehaviour {
    [SerializeField]
    float movespeed = 5f;
    Rigidbody2D rb;
    Touch touch;
    Vector3 touchPosition, whereTomove;
    bool isMoving = false;
    public float previousDistancePos, currentDistancePos;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (isMoving)
        {
            currentDistancePos = (touchPosition - transform.position).magnitude;
        }
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                previousDistancePos = 0;
                currentDistancePos = 0;
                isMoving = true;
                touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0;
                whereTomove = (touchPosition - transform.position).normalized;
                rb.velocity = new Vector2(whereTomove.x * movespeed, 0);
            }
        }
        if (currentDistancePos > previousDistancePos)
        {
            isMoving = false;
            rb.velocity = Vector2.zero;
        }
        if (isMoving)
        {
            currentDistancePos = (touchPosition - transform.position).magnitude;
        }
    }
}
