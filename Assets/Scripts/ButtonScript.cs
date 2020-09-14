using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text textDebug;

    public void PrintDebug(string name)
    {
        textDebug.text = name;
    }

    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
