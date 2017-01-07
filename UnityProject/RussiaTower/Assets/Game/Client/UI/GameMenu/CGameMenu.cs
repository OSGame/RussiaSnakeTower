using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CGameMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnExit() {
        SceneManager.LoadScene("Menu");
    }
}
