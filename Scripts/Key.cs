using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
   
    public GameObject keyProofPrefab;
    public GameObject doorObject;
    public static bool hasKey;
  //  AudioSource audio;
  
    void Start()
    {
       
        //keyProofPrefab = GameObject.FindGameObjectWithTag("Proof");
        transform.position = new Vector3(11f, 2.5f + Mathf.Sin(Time.time * 5.0f), 45f);
      
    }

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
            hasKey = true;
         
            Object. Instantiate(keyProofPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.4f);
           // Call the Unlock() method on the Door
            // door.Unlock();
           // Set the Key Collected Variable to true
           // Destroy the key. Check the Unity documentation on how to use Destroy
           
       
        // Make sure the poof animates vertically


       
      
       
    }

}
