using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
// class which defines door behaviour 
public class Door : MonoBehaviour {

    GameObject obj; // door in game acts as mechanism for scene victory
    
    private void OnTriggerStay2D(Collider2D other)
    {
        // check if the character has attained the key within scene
        obj = GameObject.FindGameObjectWithTag("Key");
        bool openDoor = obj.GetComponent<Key>().hasKey;
        Debug.Log(openDoor);
        // The user has beat the level if they have pressed down when atop the door and have previously collided with key
        if(Input.GetKeyDown(KeyCode.UpArrow) && openDoor == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
       
    }
}
