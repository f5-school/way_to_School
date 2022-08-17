using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Passcode : MonoBehaviour
{
    string Code = "32653";
    string Num = null;
    int NumIndex = 0;
    string alpha;
    public Text UiText = null;

    public string nextScene;
    public void SceneChange()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void CodeFunction(string Numbers)
    {
        NumIndex++;
        Num = Num + Numbers;
        UiText.text = Num;
    }
    public void Enter()
    {
        if(Num == Code)
        {
            Debug.Log("It's working!!!");
            SceneChange();
        }
    }
    public void Delete()
    {
        NumIndex++;
        Num = null;
        UiText.text = Num;
    }

}
