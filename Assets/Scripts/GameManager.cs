using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private UIController _uiController;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _uiController = GameObject.Find("UIController").GetComponent<UIController>();
        if (!DataManager.Instance.CheckData())
        {
            _uiController.DisableButton("ContinueButton");
        }
    }

}
