using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    DrivewayPrefabs _drivewayPre;

    public void PlayAnim()
    {
        _drivewayPre = FindObjectOfType<DrivewayPrefabs>();
        GameObject currentObject = _drivewayPre.gameObject;
        _drivewayPre.PlayAnimation();
    }
}
