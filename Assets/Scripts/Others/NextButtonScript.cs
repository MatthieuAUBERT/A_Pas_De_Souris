using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    private InkManager _inkManager;

    private int compteur = 0;

    void Start()
    {
        _inkManager = FindObjectOfType<InkManager>();

        if (_inkManager == null)
        {
            Debug.LogError("Ink Manager was not found!");
        }
    }

    public void OnClick()
    {
        _inkManager?.DisplayNextLine();
        compteur += 1;
    }

    public void EndScript()
    {
        if (compteur >= 7)
        {
            SceneManager.LoadScene("Hub");
        }
    }
}