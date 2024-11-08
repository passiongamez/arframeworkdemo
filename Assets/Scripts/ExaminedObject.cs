using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ExaminedObject : MonoBehaviour
{
    ExamineManager _examineManager;

    private void Start()
    {
        _examineManager = FindObjectOfType<ExamineManager>();
    }

    public void SelectingObject()
    {
        _examineManager.SelectedObject(this.gameObject);
    }

    public void DeselectingObject()
    {
        _examineManager.Delselect();
    }

}
