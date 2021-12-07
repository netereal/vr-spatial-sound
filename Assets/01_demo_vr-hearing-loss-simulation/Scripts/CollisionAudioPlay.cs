using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudioPlay : MonoBehaviour
{
    public AudioClip saw;
    void Start()
    {
        GetComponent<AudioSource> ().clip = saw;
    }
    void Update ()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        //GetComponent<AudioSource> ().Play ();
        if(collision.gameObject.tag == "floor")
        {
            GetComponent<AudioSource> ().Play ();
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }

        // Debug.Log("Collision game object ");
        // Debug.Log(collision.gameObject.tag);
    }
    
}
  
