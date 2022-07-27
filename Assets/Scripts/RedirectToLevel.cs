using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RedirectToLevel : MonoBehaviour
{
    public static string scene;
    // Update is called once per frame
    void Update()
    {
        if(scene!=null)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
