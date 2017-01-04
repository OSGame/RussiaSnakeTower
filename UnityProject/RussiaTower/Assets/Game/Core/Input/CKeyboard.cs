using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CKeyboard {
    public float GetAxis(string name)
    {
        return CrossPlatformInputManager.GetAxis(name);
    }

    public float GetHorizontal()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Horizontal);
    }
    public float GetINPUT_Vertical()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Vertical);
    }
    public float GetFire1()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire1);
    }
    public float GetFire2()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire2);
    }
    public float GetFire3()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire3);
    }
    public float GetJump()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Jump);
    }

    public static string INPUT_Horizontal = "Horizontal"; // 水平 x
    public static string INPUT_Vertical = "Vertical"; // 垂直 y
    public static string INPUT_Fire1 = "Fire1"; // 
    public static string INPUT_Fire2 = "Fire2"; // 
    public static string INPUT_Fire3 = "Fire3"; // 
    public static string INPUT_Jump = "Jump"; // space

}
