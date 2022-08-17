using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S5_Click : MonoBehaviour
{
    public GameObject Click_Somewhere;
    public void SceneChange1()
    {
        SceneManager.LoadScene("S5_1_Zoom_Poster");
    }
    public void SceneChange2()
    {
        SceneManager.LoadScene("S5_2_Zoom_Artwork");
    }
    public void SceneChange3()
    {
        SceneManager.LoadScene("S5_6_0_Zoom_Carpet");
    }
    public void SceneChange4()
    {
        SceneManager.LoadScene("S5_6_1_Zoom_Findkey");
    }
    public void SceneChange5()
    {
        SceneManager.LoadScene("S5_3_Zoom_Com1");
    }

    public void SceneChange6()
    {
        SceneManager.LoadScene("S5_4_Zoom_Com2");
    }

    public void SceneChange7()
    {
        SceneManager.LoadScene("S5_5_Zoom_Calender");
    }

    public void SceneChange8()
    {
        SceneManager.LoadScene("S5_7_Zoom_Drawers");
    }

    public void SceneChange9()
    {
        SceneManager.LoadScene("S5_8_Zoom_Opemdrawers");
    }

    public void SceneChange10()
    {
        SceneManager.LoadScene("S5_9_Zoom_Emptydrawers");
    }
    public void SceneChange11()
    {
        SceneManager.LoadScene("S5_10_Zoom_Picture");

    }

    public void SceneChange12()
    {
        SceneManager.LoadScene("S5_10_Zoom_Seconddrawers");

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
