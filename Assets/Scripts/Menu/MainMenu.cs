using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("StartGame");
    }


    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
