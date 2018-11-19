using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseScript : MonoBehaviour {
    public GameObject imgUse, titleUse, textUse, usebtn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void UseBtn()
    {
        imgUse.SetActive(true);
        titleUse.SetActive(true);
        textUse.SetActive(true);
        usebtn.SetActive(true);
    }
    public void ReadyBtn()
    {
        imgUse.SetActive(false);
        titleUse.SetActive(false);
        textUse.SetActive(false);
        usebtn.SetActive(false);
    }
}
