using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour {
    public void LoadScene(string scenename) {
    	SceneManager.LoadScene(scenename);
    }

    public void ExitApp() {
         Application.Quit();
    }

    public void OpenMyUrl() {
    	Application.OpenURL("https://drive.google.com/file/d/1GLA34FCQiYZ4jBBW_EAM87iOtvQvKVXC/view?usp=sharing");
    }
}