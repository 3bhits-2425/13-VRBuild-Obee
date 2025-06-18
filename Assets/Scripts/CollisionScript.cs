using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour
{
    public Collider triggerZone;  // Im Inspector deinen eigenen Collider reinziehen
    public AudioClip clip;        // Soundclip reinziehen

    private AudioSource source;

    void Start()
    {
        source = GetComponent<AudioSource>();
        if (source == null)
        {
            Debug.LogWarning("AudioSource fehlt! Bitte hinzufügen.");
        }

        if (triggerZone == null)
        {
            Debug.LogWarning("Kein Trigger Collider zugewiesen!");
        }
        else
        {
            triggerZone.isTrigger = true;  // sicherstellen, dass es ein Trigger ist
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("MainCamera"))
        {
            if (clip != null && source != null)
            {
                source.Play();
                Debug.Log("Sound abgespielt: " + clip.name);
            }
        }
    }
   

}
