using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneAdditive : MonoBehaviour
{
	public string nextScene;
    public string nowScene;
	public void SceneChange() {
		SceneManager.LoadScene(nextScene, LoadSceneMode.Additive);
	}

    public void SceneQuit()
    {
        SceneManager.UnloadScene(nowScene);
    }
}
