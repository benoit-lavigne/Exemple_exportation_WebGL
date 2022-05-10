using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionnaireScene : MonoBehaviour
{

    private int sceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
    }

    public void SceneSuivante()
    {
        if(sceneIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(sceneIndex + 1);
        }

    }

    public void ScenePrecedente()
    {
        if (sceneIndex > 0)
        {
            SceneManager.LoadScene(sceneIndex -1);
        }
    }

    public void SceneRejouer()
    {
        SceneManager.LoadScene(0);
    }

}
