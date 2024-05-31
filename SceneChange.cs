using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SceneName = "Level_1"; 
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
       
    }
}
