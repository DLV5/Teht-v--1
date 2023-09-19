using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    private GameObject _currentPanel;

    private void OnEnable()
    {
        _currentPanel = GameObject.Find("MainMenu");
    }

    public void OpenPanel(GameObject panelToOpen)
    {
        panelToOpen.SetActive(true);
        _currentPanel.SetActive(false);
        _currentPanel = panelToOpen;
    }

    public void DisableButton(string buttonName)
    {
        GameObject.Find(buttonName).GetComponent<Button>().interactable = false;
    }

    public void EnableButton(string buttonName)
    {
        GameObject.Find(buttonName).GetComponent<Button>().interactable = true;
    }
}
