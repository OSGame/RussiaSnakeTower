using UnityEngine;
using System.Collections;

public class CInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
        print("input start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void FixedUpdate() {
        float x = CKeyboard.GetHorizontal();
        if (x > 0) {
            // right
            OnRight(x);
        } else if (x < 0) {
            // left
            OnLeft(x);
        }

        float y = CKeyboard.GetVertical();
        if (y > 0) {
            // up
            OnUp(y);
        } else if (y < 0) {
            // down
            OnDown(y);
        }
    }

    void OnLeft(float value) {
        print("OnLeft : " + value);
    }
    void OnRight(float value) {
        print("OnRight : " + value);
    }
    void OnUp(float value) {
        print("OnUp : " + value);
    }
    void OnDown(float value) {
        print("OnDown : " + value);
    }

    void OnJump(float value) {
        print("OnJump : " + value);
    }
}
