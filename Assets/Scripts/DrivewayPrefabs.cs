using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrivewayPrefabs : MonoBehaviour
{
    Animator _animator;
    [SerializeField] GameObject _currentObject;
    [SerializeField] Color[] _colorSwap;
    Color _defaultColor;
    MeshRenderer _renderer;
    [SerializeField] Material[] _materials;
    GameManager _gameManager;

    void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _renderer = GetComponentInChildren<MeshRenderer>();
        _materials = _renderer.materials;
        _defaultColor = _renderer.material.color;
        _gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    public void Select()
    {
       _gameManager.OnSelect();
    }

    public void OnDeselect()
    {
        _gameManager.Deselect();
    }


    public void PlayAnimation()
    {
        _animator.SetInteger("Play", 0);
    }

    public void ChangeColor1()
    {
        _materials[0].color = _colorSwap[0];
    }

    public void ChangeColor2()
    {
        _materials[0].color = _colorSwap[1];
    }

    public void ChangeColor3()
    {
        _materials[0].color = _colorSwap[2];
    }

    public void ChangeColor4()
    {
        _materials[0].color = _colorSwap[3];
    }

    public void ChangeColor5()
    {
        _materials[0].color = _colorSwap[4];
    }

    public void ChangeColor6()
    {
        _materials[0].color = _colorSwap[5];
    }

    public void DefaultColorChange()
    {
        _materials[0].color = _defaultColor;
    }
}
