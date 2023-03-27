using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class manager : MonoBehaviour
{
    public Button pinkButton, greenButton, blueButton;
    private Camera _cameraREF;
    public GameObject ball1;
    public Material _materialBall1;

    private void Start()
    {
        _materialBall1 = ball1.GetComponent<MeshRenderer>().material;
        _cameraREF = Camera.main;
    }
    public void ChangeSceneColorGreen()
    {
        _materialBall1.color = Color.green;
        _cameraREF.backgroundColor = Color.gray;
    }
    public void ChangeSceneColorPink()
    {
        _materialBall1.color = Color.magenta;

        _cameraREF.backgroundColor = Color.black;
    }
    public void ChangeSceneColorBlue()
    {
        _materialBall1.color = Color.green;

        _cameraREF.backgroundColor = Color.white;
    }

    /*public void ChangeSceneColor()
    {
        Color colorin = Color.green;
        _cameraREF.backgroundColor = colorin;
    }*/
}
