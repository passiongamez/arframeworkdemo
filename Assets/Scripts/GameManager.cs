using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   [SerializeField] Canvas _canvas;
   [SerializeField] Play _playButton;
   [SerializeField] GameObject _colorButtonGroup;

    public void OnSelect()
    {
        _playButton.gameObject.SetActive(true);
        _colorButtonGroup.gameObject.SetActive(true);
    }

    public void Deselect()
    {
        _playButton.gameObject.SetActive(false);
        _colorButtonGroup?.gameObject.SetActive(false);
    }
    public void ChangeScene1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


    public void ChangeScene0()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
