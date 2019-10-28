using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// Scene management class responsible for transitioning scenes
public class LoadScene : MonoBehaviour {

    [SerializeField]
	// constant time necessary to load a scene
    private float loadTime = 5f;
    private float timeElapsed;
	
	// Update is called once per frame
	void Update () {
	// ensure Unity has enough time to load
        timeElapsed += Time.deltaTime;
        if(timeElapsed > loadTime)
        {
            SceneManager.LoadScene(0);
        }
		
	}
}
