using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

	public Text ceriseCountertext;
	public LayerMask groundLayer;
	public static int  scoreCherry;
	public Text timerCheriestext;
	public static bool isProtected ;
	public bool isGrounded ,  isDragging  , swiperight, SwipeLeft;
	public Transform character;
	public GameObject CherrySpawner;
	public float tim ;
	public int countertime;
	public GameObject scroll,scroll1 , cherry , protection , timerimg ,scoreObject;
	public Camera cam;
	Vector2 position  , DeltaSwipe , startTouch;

	public Vector2 screenPos;

	Animator anim;
	Touch initTouch;
	bool swiped,protectedPlayer = false;
	// Use this for initialization
	void Start () {
		tim = 5f;
		countertime = 10;
		timerCheriestext.enabled= false;
		timerimg.SetActive (false);
		protection.SetActive (false);

		scoreObject.SetActive (false);
		isProtected = false;

		position = transform.position;
		anim = GetComponent<Animator> ();
		anim.SetBool("Go",false);
		isDragging = false;
		scoreCherry = 0;
		ceriseCountertext.text = scoreCherry.ToString();
		//CherrySpawner.SetActive (false);
		CherrySpawner.GetComponent<CherryFactory> ().enabled= false ;
		scroll.GetComponent<SkyScrollScript>().enabled= false;
		scroll1.GetComponent<SkyScrollScript>().enabled = false;
	}
	public void reset(){
		startTouch = DeltaSwipe = Vector2.zero;

	}

	// Update is called ttttnce per frame
	void Update () {
		if (ButtonsScript.pausePressed) {
			scroll.GetComponent<SkyScrollScript> ().enabled = false;
			scroll1.GetComponent<SkyScrollScript> ().enabled = false;
		}


		if (ButtonsScript.restartPressed) {
			scroll.GetComponent<SkyScrollScript> ().enabled = true;
			scroll1.GetComponent<SkyScrollScript> ().enabled = true;
		}
		if (TextClignotant.playall) {

			anim.SetBool ("Go", true);
			scroll.GetComponent<SkyScrollScript> ().enabled = true;
			scroll1.GetComponent<SkyScrollScript> ().enabled = true;
			CherrySpawner.SetActive (true);
			CherrySpawner.GetComponent<CherryFactory> ().enabled = true;

			scoreObject.SetActive (true);
		}
		if (SpawnRush.avatarTouched) {
			anim.SetBool ("Go", false);
			anim.SetBool ("die", true);
			scroll.GetComponent<SkyScrollScript> ().enabled = false;
			scroll1.GetComponent<SkyScrollScript> ().enabled = false;
		}
		/*if (Input.GetMouseButtonDown (0)) {
			transform.Translate (0.5f, 0f, 0f);
		} else if (Input.GetMouseButtonDown (1)) {
			transform.Translate (-0.5f, 0f, 0f);
		}*/


		Vector2 direction = Vector2.down;
		float distancee = 0.5f;
		Debug.DrawRay (position, direction * 0.33f, Color.green);
		RaycastHit2D hit = Physics2D.Raycast (position, direction, distancee, groundLayer);


		if (hit.collider != null) {
			isGrounded = true;
			//character.position = hit.transform;
			character.GetComponent<Rigidbody2D> ().AddForce (Vector2.right * 0.07f);

		}
	if (scoreCherry >= 3) {
			tim = tim - 0.01f;
			if (tim > 0) {
				isProtected = true;
				protection.SetActive (true);
				countertime = (int)tim;
				timerCheriestext.enabled= true;
				timerimg.SetActive (true);
				timerCheriestext.text = countertime.ToString ();

			} else {
				protection.SetActive (false);
				timerCheriestext.enabled= false;
				timerimg.SetActive (false);
			}

		}




	}

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag.Equals ("pente")) {
			character.GetComponent<Rigidbody2D> ().AddForce (Vector2.right);
		}


		if (coll.gameObject.tag.Equals ("cherrybonus")) {
			scoreCherry += 1;
			ceriseCountertext.text = scoreCherry.ToString();
			coll.gameObject.SetActive (false);
		}




	}







}

/*	foreach (Touch t in Input.touches) {
			if (t.phase == TouchPhase.Began) {
				initTouch = t;
			} else if (t.phase == TouchPhase.Moved && !swiped) {
				float xMoved = initTouch.position.x - t.position.x;

				float distance = Mathf.Sqrt (xMoved * xMoved); // h2 = p2 + b2
				bool swipedLeft = Mathf.Abs (xMoved) > 0;

				if (distance > 50f) {
					if (swipedLeft && xMoved > 0) { // swiped left
						transform.Translate (-0.2f, 0, 0);
					} else if (swipedLeft && xMoved < 0) { // swped right
						
					}

					swiped = true;
				}
			} else if (t.phase == TouchPhase.Ended) {
				initTouch = new Touch ();
				swiped = false;
			}
		}*/

