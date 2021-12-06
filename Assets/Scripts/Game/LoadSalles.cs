using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSalles : MonoBehaviour
{

    public void Salle1(string salle)
    {
        SceneManager.LoadScene(salle);
    }
    public void Salle2()
    {
        SceneManager.LoadScene("Salle 2");
    }
    public void Salle3()
    {
        SceneManager.LoadScene("Salle 3");
    }
    public void Salle4()
    {
        SceneManager.LoadScene("Salle 4");
    }
}
