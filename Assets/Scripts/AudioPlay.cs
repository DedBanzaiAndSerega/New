using UnityEngine;
using System.Collections;

public class AudioPlay : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        GetComponent<AudioSource>().Play(); //Play Explosion Sound
    }

    // Update is called once per frame
    void Update () {
	
	}
}
