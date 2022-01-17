using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject Cr�ditsObject;
    public void StartGame()
    {
        SceneManager.LoadScene("StartGame");
    }


    public void Cr�ditsOn()
    {
        Debug.Log("Cr�dits");
        Cr�ditsObject.SetActive(true);
    }

    public void Cr�ditsOff()
    {
        Cr�ditsObject.SetActive(false);
    }
}
