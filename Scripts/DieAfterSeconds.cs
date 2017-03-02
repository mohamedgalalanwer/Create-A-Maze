using UnityEngine;
using System.Collections;
//[RequireComponent(typeof(AudioSource))]
public class DieAfterSeconds : MonoBehaviour {
   
    IEnumerator Start () {
        yield return new WaitForSeconds(2.0f);
        Destroy(gameObject);
	}
}
