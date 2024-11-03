using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class Examinable : MonoBehaviour
{
    ARSelectionInteractable _selectionInteractable;

    ExamineManager _examineManager;


    void Start()
    {
        _selectionInteractable = GetComponent<ARSelectionInteractable>();

        _examineManager = FindObjectOfType<ExamineManager>();
    }

    public void SelectingObject()
    {
        SelectEnterEvent selectedItem = _selectionInteractable.selectEntered;
        selectedItem.AddListener(Select);
    }


    public void DeselectObject()
    {

    }


    void Select(SelectEnterEventArgs selected)
    {
        selected = _examineManager.currentExaminedObject;
    }

}
