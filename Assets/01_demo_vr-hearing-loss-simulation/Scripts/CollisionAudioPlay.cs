using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudioPlay : MonoBehaviour
{
    public AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }
    void Update ()
    {
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            sound.Play();
            Destroy(collision.gameObject);
        }
        
    }
    
}
  
