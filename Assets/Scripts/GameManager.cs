using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void ChangeScene1()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


    public void ChangeScene0()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
