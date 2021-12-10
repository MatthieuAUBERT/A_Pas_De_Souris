
using UnityEngine;

public class IndicesManager : MonoBehaviour
{
    public GameObject IndicesUI;
    public GameObject BananeUI;
    public GameObject HDFUI;
    public GameObject CravateUI;
    public GameObject MaquillageUI;

    public GameObject AccusationUI;

    public string toCheck;
    public string toCheck2;
    public string toCheck3;
    public string toCheck4;

    GameManager gm;

    public void Start()
    {
        gm = ManagerManager.Instance.gameManager;
    }

    public void SetIndicesUIActive(bool a)
    {
        IndicesUI.SetActive(a);
        Debug.Log(gm);
        Debug.Log(gm.clues);

        if (gm.clues.IndexOf(toCheck) >= 0)
        {
            BananeUI.SetActive(true);
        }

        if (gm.clues.IndexOf(toCheck2) >= 0)
        {
            HDFUI.SetActive(true);
        }

        if (gm.clues.IndexOf(toCheck3) >= 0)
        {
            CravateUI.SetActive(true);
        }

        if (gm.clues.IndexOf(toCheck4) >= 0)
        {
            MaquillageUI.SetActive(true);
        }

    }

    public void SetUnactiveIndicesUI(bool a)
    {
        IndicesUI.SetActive(a);
    }

    public void Accusation()
    {
        IndicesUI.SetActive(false);
        AccusationUI.SetActive(true);
    }

    public void SetUnactiveAccusationUI(bool a)
    {
        AccusationUI.SetActive(a);
    }
}
