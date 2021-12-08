using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSalles : MonoBehaviour
{

    public void Salle(string salle)
    {
        SceneManager.LoadScene(salle);
    }

}
