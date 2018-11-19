using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class ADS : MonoBehaviour {

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            Debug.Log("ads is ready ");
        }
        else
        {
            Debug.Log("ads is not ready ");
        }
    }
}
