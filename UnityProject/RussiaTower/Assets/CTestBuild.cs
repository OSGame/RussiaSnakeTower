using UnityEngine;
using System.Collections;

public class CTestBuild : MonoBehaviour {

    public GameObject Flats;
	// Use this for initialization
	void Start () {
        BuildFlat();
        m_currentTime = 0;
    }

    private float m_currentTime;
    // Update is called once per frame
    void Update() {
        m_currentTime += Time.deltaTime;
        if (m_currentTime > 3) {
            m_currentTime = 0;
            BuildFlat();
        }
	}

    public GameObject BuildFlat() {
        return GameObject.Instantiate(Flats);
        //GameObject flats = GameObject.Instantiate("Flats");
    }
}
