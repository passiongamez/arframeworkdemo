using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButtons : MonoBehaviour
{
    DrivewayPrefabs _drivewayPrefabs;

    private void Start()
    {
        _drivewayPrefabs = FindObjectOfType<DrivewayPrefabs>();
    }

    public void ChangeToColor1()
    {
        _drivewayPrefabs.ChangeColor1();
    }

    public void ChangeToColor2()
    {
        _drivewayPrefabs.ChangeColor2();
    }
    public void ChangeToColor3()
    {
        _drivewayPrefabs.ChangeColor3();
    }
    public void ChangeToColor4()
    {
        _drivewayPrefabs.ChangeColor4();
    }
    public void ChangeToColor5()
    {
        _drivewayPrefabs.ChangeColor5();
    }
    public void ChangeToColor6()
    {
        _drivewayPrefabs.ChangeColor6();
    }
    public void ChangeToDefault()
    {
        _drivewayPrefabs.DefaultColorChange();
    }
}
