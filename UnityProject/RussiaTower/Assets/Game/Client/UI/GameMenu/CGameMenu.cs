using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CGameMenu : MonoBehaviour {

    void Awake() {
        m_isDetailShow = false;
    }
	// Use this for initialization
	void Start () {
        print("CGameMenu start");
        m_detail = GameObject.Find("Detail");
        m_detail.SetActive(m_isDetailShow);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnExit() {
        SceneManager.LoadScene("menu");
    }

    public void OnRestart() {
        SceneManager.LoadScene("tower");
    }
    public void OnSwitchMenu() {
        m_isDetailShow = !m_isDetailShow;
        m_detail.SetActive(m_isDetailShow);
    }

    private GameObject m_detail;
    private bool m_isDetailShow;
}
