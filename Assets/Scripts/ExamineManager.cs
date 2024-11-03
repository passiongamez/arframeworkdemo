using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation.VisualScripting;

public class ExamineManager : MonoBehaviour
{
    [SerializeField] Transform _cameraView;
    Vector3 _cachedPosition;
    Vector3 _cachedScale;
    Quaternion _cachedRotation;
    [SerializeField] float _rotateSpeed = .5f;
    [SerializeField] float _examineScaleOffset = .5f;
    bool _isExamining = false;
    public GameObject currentExaminedObject;



    void Update()
    {
      if(_isExamining == true)
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Moved)
                {
                    currentExaminedObject.transform.Rotate(touch.deltaPosition.x, touch.deltaPosition.y, 0 * _rotateSpeed);
                }
            }
        }  
    }

    public void PerformExamination()
    {
        _cachedPosition = currentExaminedObject.transform.position;
        _cachedRotation = currentExaminedObject.transform.rotation;
        _cachedScale = currentExaminedObject.transform.localScale;

        Vector3 scaleOffset = _cachedScale * _examineScaleOffset;
        currentExaminedObject.transform.localScale = scaleOffset;

        currentExaminedObject.transform.position = _cameraView.position;
        currentExaminedObject.transform.parent = _cameraView;
        CurrentSelectedItem();

        _isExamining = true;
    }

    public void PerformUnexamine()
    {
        currentExaminedObject.transform.position = _cachedPosition;
        currentExaminedObject.transform.rotation = _cachedRotation;
        currentExaminedObject.transform.localScale = _cachedScale;

        currentExaminedObject.transform.parent = null;
        DeselectItem();

        _isExamining = false;
    }

    public void CurrentSelectedItem()
    {
        currentExaminedObject = 
    }

    void DeselectItem()
    {
        currentExaminedObject = null;
    }
}



//i need to cache the currently selected gameobject so that when i press examine it uses the examine method on the currently 
//selected gameobject