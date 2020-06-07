using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ARModeButton : MonoBehaviour
{
    public void ARModeButtonScene()
    {
        Application.LoadLevel("ARScene");
    }
    public void VRModeButtonScene()
    {
        Application.LoadLevel("HelloVR");
    }
}
