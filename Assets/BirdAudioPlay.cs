using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class BirdAudioPlay : MonoBehaviour
{
    public AudioClip saw;
    XRGrabInteractable m_GrabInteractable;
    void Start()
    {
        GetComponent<AudioSource> ().clip = saw;
    }
    void Update ()
    {
    }
    
    protected void OnEnable()
    {
        m_GrabInteractable = GetComponent<XRGrabInteractable>();

        m_GrabInteractable.firstHoverEntered.AddListener(OnFirstHoverEntered);
        
    }
    
    
    void OnCollisionEnter(Collision collision)
    {
        // //GetComponent<AudioSource> ().Play ();
        // if(collision.gameObject.tag == "floor")
        // {
        //     GetComponent<AudioSource> ().Play ();
        //     //gameObject.SetActive(false);
        //     //Destroy(gameObject);
        // }
        //
        // // Debug.Log("Collision game object ");
        // // Debug.Log(collision.gameObject.tag);
    }

    protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
    {
        Debug.Log("-------------------------OnFirstHoverEntered");
        GetComponent<AudioSource> ().Play ();
    }
    protected void OnDisable()
    {
        m_GrabInteractable.firstHoverEntered.RemoveListener(OnFirstHoverEntered);
        
    }
}