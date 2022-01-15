using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class RadioPlay : MonoBehaviour
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
    
    protected void OnDisable()
    {
        m_GrabInteractable.firstHoverEntered.RemoveListener(OnFirstHoverEntered);
        
    }

    protected virtual void OnLastHoverEntered(HoverExitEventArgs args)
    {
        GetComponent<AudioSource> ().Stop();
    }
    protected virtual void OnFirstHoverEntered(HoverEnterEventArgs args)
    {
        GetComponent<AudioSource> ().Play ();
    }
    
}