using UnityEngine;
using System.Collections;

public class CInput : MonoBehaviour {

    private Transform m_pMainCamera;
    private CScene m_pScene;
	// Use this for initialization
	void Start () {
        print("input start");
        m_pMainCamera = gameObject.transform.parent.Find("MainCamera");

        m_pScene = gameObject.transform.parent.Find("Scene").GetComponent<CScene>();
    }
	
	// Update is called once per frame
	//void Update () {
	
	//}

    void FixedUpdate() {
        float x = CKeyboard.GetHorizontal();
        if (x > 0) {
            // right
            _OnRight(x);
        } else if (x < 0) {
            // left
            _OnLeft(x);
        }

        float y = CKeyboard.GetVertical();
        if (y > 0) {
            // up
            _OnUp(y);
        } else if (y < 0) {
            // down
            _OnDown(y);
        }

        // print(m_pMainCamera.position.x + ", " + m_pMainCamera.position.y + ", " + m_pMainCamera.position.z);
        // m_pMainCamera.Translate(x, y, 0);

        float space = CKeyboard.GetJump();
        if (space > 0) {
            _OnSpace(space);
        }
    }

    void _OnLeft(float value) {
        // print("OnLeft : " + value);
        m_pScene.Move(true);
    }
    void _OnRight(float value) {
        // print("OnRight : " + value);
        m_pScene.Move(false);
    }
    void _OnUp(float value) {
       // print("OnUp : " + value);
    }
    void _OnDown(float value) {
       // print("OnDown : " + value);
    }

    void _OnJump(float value) {
        //print("OnJump : " + value);
    }

    void _OnSpace(float value) {
       // print("_OnSpace : " + value);
    }
}
