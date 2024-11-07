using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ExaminedObject : MonoBehaviour
{
    ExamineManager _examineManager;

    //ARSelectionInteractable _selection;



    private void Start()
    {
        _examineManager = FindObjectOfType<ExamineManager>();

        //_selection = GetComponent<ARSelectionInteractable>();

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
