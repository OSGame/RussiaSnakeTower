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

        float space = CKeyboard.GetJump();
        if (space > 0) {
            _OnSpace(space);
        }
    }

    void _OnLeft(float value) {
        print("OnLeft : " + value);
    }
    void _OnRight(float value) {
        print("OnRight : " + value);
    }
    void _OnUp(float value) {
        print("OnUp : " + value);
    }
    void _OnDown(float value) {
        print("OnDown : " + value);
    }

    void _OnJump(float value) {
        print("OnJump : " + value);
    }

    void _OnSpace(float value) {
        print("_OnSpace : " + value);
    }
}
