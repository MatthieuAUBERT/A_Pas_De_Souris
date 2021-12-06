using UnityEngine;
using UnityEngine.SceneManagement;

public class PersistentManager : MonoBehaviour
{
    public GameObject[] objectsToMakePersistents;
    public int idFirstScene;
    public void Awake()
    {
   
        foreach (var item in objectsToMakePersistents)
        {
            DontDestroyOnLoad(item);
        }
        SceneManager.LoadScene(idFirstScene);
    }
}
