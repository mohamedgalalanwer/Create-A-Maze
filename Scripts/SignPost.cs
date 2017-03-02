using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;
public class SignPost : MonoBehaviour
{
   // public static bool hasKey = false;
   // Door door;
	public void ResetScene() 

	{
       //aplication.LoadLevel(0);
        // Reset the scene when the user clicks the sign post
        Key.hasKey = false;
        SceneManager.LoadScene("Maze");
	}
}