using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("Start");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnStart() {
        print("onStart");
        SceneManager.LoadScene("tower");
    }
}
