using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject CréditsObject;
    public void StartGame()
    {
        SceneManager.LoadScene("StartGame");
    }


    public void CréditsOn()
    {
        Debug.Log("Crédits");
        CréditsObject.SetActive(true);
    }

    public void CréditsOff()
    {
        CréditsObject.SetActive(false);
    }
}
