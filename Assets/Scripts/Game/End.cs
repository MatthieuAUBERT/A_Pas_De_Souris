
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject VictoryScreen, DefeatScreen;

    public void Victory()
    {
        VictoryScreen.SetActive(true);
    }

    public void Defeat()
    {
        DefeatScreen.SetActive(true);
    }

    public void Fin()
    {
        Application.Quit();
    }
}
