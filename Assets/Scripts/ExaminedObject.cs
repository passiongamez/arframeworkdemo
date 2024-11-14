using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ExaminedObject : MonoBehaviour
{
    ExamineManager _examineManager;
    Canvas _uiElements;
    Button _examineButton;
    public int _objectPrefab;
    [SerializeField] ARPlaneManager _planeManager;
    [SerializeField] Animator _animator;

    private void Start()
    {
        _examineManager = FindObjectOfType<ExamineManager>();
        _uiElements = FindObjectOfType<Canvas>();
        _planeManager = GameObject.Find("XR Origin").GetComponent<ARPlaneManager>();
    }

    public void SelectingObject()
    {
        _examineManager.SelectedObject(this.gameObject);

        if(_planeManager != null)
        {
            _planeManager.enabled = true;
        }

        if(_uiElements != null)
        {
            _examineButton = _uiElements.GetComponent<Button>();
            if(_examineButton != null)
            {
                _examineButton.gameObject.SetActive(true);
            }
        }
    }

    public void DeselectingObject()
    {
        _examineManager.Delselect();

        if(_planeManager != null)
        {
            _planeManager.enabled = false;
        }

        if (_uiElements != null)
        {
            _examineButton = _uiElements.GetComponent<Button>();
            if (_examineButton != null)
            {
                _examineButton.gameObject.SetActive(false);
            }
        }
    }

    public void PlayAnim()
    {
        if(_animator != null)
        {
            _animator.SetInteger("Play", 0);
        }
    }
}
