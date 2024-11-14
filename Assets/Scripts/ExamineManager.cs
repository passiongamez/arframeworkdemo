using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExamineManager : MonoBehaviour
{
    [SerializeField] Transform _examinedObject;

    Vector3 _originalPos;
    Quaternion _originalRotation;
    Vector3 _originalScale;

    [SerializeField] GameObject _currentSelectedObject;

    [SerializeField] float _rotateSpeed = 1f;
    [SerializeField] float _scaleOffset = .5f;

    bool _isExamining = false;

    ExaminedObject _examiningObject;

    private void Update()
    {
        if (_isExamining == true)
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved)
                {
                    _currentSelectedObject.transform.Rotate(touch.deltaPosition.x, touch.deltaPosition.y, 0 * _rotateSpeed);
                }
            }
        }
    }

    public void SelectedObject(GameObject selected)
    {
        _currentSelectedObject = selected;
        Debug.Log(selected);
    }

    public void Delselect()
    {
        _currentSelectedObject = null;
    }

    public void Examine()
    {
        _originalPos = _currentSelectedObject.transform.position;
        _originalRotation = _currentSelectedObject.transform.rotation;
        _originalScale = _currentSelectedObject.transform.localScale;

        Vector3 scaleOffset = _currentSelectedObject.transform.localScale * _scaleOffset;

        _currentSelectedObject.transform.localScale = scaleOffset;

        _currentSelectedObject.transform.parent = _examinedObject.transform;
        _currentSelectedObject.transform.position = _examinedObject.transform.position;

        _isExamining = true;
    }


    public void Unexamine()
    {
        _currentSelectedObject.transform.position = _originalPos;
        _currentSelectedObject.transform.rotation = _originalRotation;
        _currentSelectedObject.transform.localScale = _originalScale;

        _isExamining = false;
    }

    public void AnimationPlay()
    {
       _examiningObject = _currentSelectedObject.GetComponent<ExaminedObject>();
       _examiningObject.PlayAnim();
    }
}