using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SettingsMenu : MonoBehaviour
{

    public void SetEyeMovementTap()
    {
        //EyeBehaviour.eyeInstance.ChangeMovement("tap");
        GameManager.instance.movement = 0;
    }
    public void SetEyeMovementHold()
    {
        GameManager.instance.movement = 1;
        //EyeBehaviour.eyeInstance.ChangeMovement("hold");
    }
    public void SetEyeMovementSwing()
    {
        GameManager.instance.movement = 2;
        //EyeBehaviour.eyeInstance.ChangeMovement("swing");
    }
}
