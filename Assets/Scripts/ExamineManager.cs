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

    private void Update()
    {
        if(_isExamining == true)
        {
            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);
                if(touch.phase == TouchPhase.Moved)
                {
                    _currentSelectedObject.transform.Rotate(touch.deltaPosition.x, touch.deltaPosition.y, 0);
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


}



/*for the examined object: i need to cache the examined objects original position, rotation, and scale. i need to adjust the size 
 *of the object when in examined mode and make it a child of the camera at the transform of the examined object.
 *i need a way to track the current selected object and update it when another object is selected. this will be so the examine 
 *button knows which button to go into examine mode with. 
 *also need the play button to know which item is in examine mode to or even just selected so it can play the right animation.
 *play button will use code to play an animation as well because each item has a different animation.
 */