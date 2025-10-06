using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginTour : MonoBehaviour
{
    public string sceneToLoad = "MainScene"; 

    public void LoadTour()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
