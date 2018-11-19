using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScript : MonoBehaviour {
    public GameObject imgStory, titleStory, textStory,readybtn;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StoryBtn()
    {
        imgStory.SetActive(true);
        titleStory.SetActive(true);
        textStory.SetActive(true);
        readybtn.SetActive(true);
    }
    public void ReadyBtn()
    {
        imgStory.SetActive(false);
        titleStory.SetActive(false);
        textStory.SetActive(false);
        readybtn.SetActive(false);
    }
}
