using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class Door : MonoBehaviour
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked = false;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;
   // public static bool hasKey = false;
    //public AudioSource audio;
    //public AudioClip[] soundEffect;
    public AudioClip open;
    public AudioClip close;

    void Start()
    {

       // audio = GetComponent<AudioSource>();

    }
    void Update()
    {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (opening)
        {
            if (transform.position.y < 9)
                transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
        }
    }

    public void OnDoorClicked()
    {
        // If the door is clicked and unlocked
        if (Key.hasKey == true)
        {
            locked = false;
            opening = true;
            //audio.clip = soundEffect[1];
            //audio.Play();

            AudioSource.PlayClipAtPoint(open, transform.position);
  
           // transform.Translate(Vector3.up * 3 * Time.deltaTime, Space.World);
        }
        if (Key.hasKey == false)
        {
            opening = false;
            //audio.clip = soundEffect[0];
            //audio.Play();
            AudioSource.PlayClipAtPoint(close, transform.position);
        }




       
        // 



        // Set the "opening" boolean to true
        // (optionally) Else
        // Play a sound to indicate the door is locked
    }

    //public void Unlock()
    //{
    //    // You'll need to set "locked" to false here

    //    locked = false;

    //}
}
