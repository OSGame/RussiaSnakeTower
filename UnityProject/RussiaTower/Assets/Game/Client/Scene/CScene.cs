using UnityEngine;
using System.Collections;

public class CScene : MonoBehaviour {
    public GameObject Flats;

	// Use this for initialization
	void Start () {
        m_time = 0;
        m_pMap = GameObject.Find("Map").GetComponent< CSceneMap>();
    }
	
	// Update is called once per frame
	void Update () {
	    
	}

    public void Move(bool isLeft) {
        m_pMap.Move(isLeft);
    }

    void FixedUpdate() {
        //**
        _CreateFlats();

        m_currentFlats.transform.Translate(0, -CFlats.SIZE/10, 0);

        if (m_currentFlats.GetComponent<CFlats>().IsInitial()) {
            var isCross = m_pMap.IsFlatsCrossMap(m_currentFlats);
            if (isCross) {
                if (m_currentFlats) {
                    GameObject.Destroy(m_currentFlats);
                    m_currentFlats = null;
                }
            }
        }
        //*/
    }

    void _CreateFlats() {
        if (m_currentFlats == null) {
            m_currentFlats = Instantiate(Flats);
            m_currentFlats.transform.SetParent(gameObject.transform);
            m_currentFlats.transform.localPosition = new Vector3(5* CFlats.SIZE, 20* CFlats.SIZE, 0);
        }
    }

    private GameObject m_currentFlats;
    private float m_time;
    private CSceneMap m_pMap;
}
