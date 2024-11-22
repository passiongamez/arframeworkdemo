using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ExaminedObject : MonoBehaviour
{
    ExamineManager _examineManager;
    public int _objectPrefab;
    [SerializeField] Animator _animator;

    private void Start()
    {
        _examineManager = FindObjectOfType<ExamineManager>();
    }

    public void SelectingObject()
    {
        _examineManager.SelectedObject(this.gameObject);
        _examineManager.ButtonsActivate();
    }

    public void DeselectingObject()
    {
        _examineManager.Delselect();
        _examineManager.ButtonsDeactivate();
    }

    public void PlayAnim()
    {
        if(_animator != null)
        {
            _animator.SetInteger("Play", 0);
        }
    }
}
