using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpawnRush : MonoBehaviour
{

    public static bool groundTouched, avatarTouched = false;
    public RocherSpawnScript rsp;
    public TextClignotant txtcligScript;
    public static Vector2 posrush;
   
    // Use this for initialization
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("ground"))
        {
            groundTouched = true;
            Debug.Log("ground touched " + groundTouched);
            Debug.Log("ground");
            GetComponent<Collider2D>().isTrigger = true;
            Vector2 moving = new Vector2(Random.Range(-2f, 2f), 3);
            gameObject.GetComponent<Rigidbody2D>().velocity = moving;
            //  gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.up * 8;
            posrush = col.gameObject.GetComponent<Transform>().position;
            Debug.Log("Positiooooooooooooooon "+posrush);
            
        }
        if (col.gameObject.tag.Equals("Player"))
        {
            //imgScore.SetActive(true);
            avatarTouched = true;
            Debug.Log("massit fel player");
            Destroy(gameObject);
           
        }

    }


}
