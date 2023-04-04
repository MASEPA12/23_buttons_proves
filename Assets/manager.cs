using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    private Camera _cameraREF;

    private void Start()
    {
        _cameraREF = Camera.main;
    }

    public void ChangeSceneColorGreen()
    {
        _cameraREF.backgroundColor = Color.gray;
    }
    public void ChangeSceneColorPink()
    {
        _cameraREF.backgroundColor = Color.yellow;
    }
    public void ChangeSceneColorBlue()
    {
        _cameraREF.backgroundColor = Color.white;
    }
}
