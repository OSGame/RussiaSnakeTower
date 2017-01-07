using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class CKeyboard {
    public static float GetAxis(string name)
    {
        return CrossPlatformInputManager.GetAxis(name);
    }

    public static float GetHorizontal()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Horizontal);
    }
    public static float GetVertical()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Vertical);
    }
    public static float GetFire1()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire1);
    }
    public static float GetFire2()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire2);
    }
    public static float GetFire3()
    {
        return CrossPlatformInputManager.GetAxis(INPUT_Fire3);
    }
    public static float GetJump()
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
