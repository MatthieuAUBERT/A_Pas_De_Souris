
using UnityEngine;

public class IndicesManager : MonoBehaviour
{
    public GameObject IndicesUI;
    public GameObject BananeUI;

    GameManager gm;

    private void Awake()
    {
        gm = ManagerManager.Instance.gameManager;
    }

    public void SetIndicesUIActive(bool a)
    {
        IndicesUI.SetActive(a);
        if (gm.clues.IndexOf("Banane") >= 0)
        {
            BananeUI.SetActive(true);
        }
        else
        {
            Debug.Log("No");
        }
    }

    public void SetUnactiveIndicesUI(bool a)
    {
        IndicesUI.SetActive(a);
    }

    public void Accusation()
    {

    }
}
