using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSalles : MonoBehaviour
{
    public GameObject ButtonMenu;
    public GameObject ButtonHub;
    public GameObject Salle1, Salle2, Salle3, Salle4;
    public bool etatUn, etatDeux;

    public void FixedUpdate()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Hub")
        {
            Salle1.SetActive(true);
            Salle2.SetActive(true);
            Salle3.SetActive(true);
            Salle4.SetActive(true);
        }
        else
        {
            Salle1.SetActive(false);
            Salle2.SetActive(false);
            Salle3.SetActive(false);
            Salle4.SetActive(false);
        }
    }
    public void Salle(string salle)
    {
        SceneManager.LoadScene(salle);
        ButtonMenu.SetActive(etatUn);
        ButtonHub.SetActive(etatDeux);
    }

    public void StateButton()
    {
        etatUn = !etatUn;
        etatDeux = !etatDeux;
    }

}
