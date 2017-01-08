using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CMainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("CMainMenu Start");
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnStart() {
        print("onStart");
        SceneManager.LoadScene("tower");
    }
}
