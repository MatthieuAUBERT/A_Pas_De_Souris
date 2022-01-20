using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    private InkManager _inkManager;

    public GameObject Container;

    private int compteur = 0;

    void Start()
    {
        _inkManager = FindObjectOfType<InkManager>();

        if (_inkManager == null)
        {
            Debug.LogError("Ink Manager was not found!");
        }
    }
    public void StartStory()
    {
        Container.SetActive(true);
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

    public void EndScriptSalle()
    {
        if (compteur >= 6)
        {
            Container.SetActive(false);
        }
    }
}