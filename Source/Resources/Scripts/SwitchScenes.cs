using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScenes : MonoBehaviour
{
    public void SwitchScene(string SCENE)
    {
        SceneManager.LoadScene(SCENE);
        Time.timeScale = 1.0f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
