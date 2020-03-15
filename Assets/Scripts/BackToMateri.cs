using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackToMateri : MonoBehaviour
{
    void Update()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                BackButton();
            }
        }

        public void BackButton(){
        	UnityEngine.SceneManagement.SceneManager.LoadScene("Materi");
        }
}
