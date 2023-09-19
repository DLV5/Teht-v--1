using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainGameScript : MonoBehaviour
{
    private PlayerData _playerData;

    [SerializeField] private TMP_Text _nameText;
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Slider _healthSlider;

    void OnEnable()
    {
        Initialize();
    }

    private void Initialize()
    {
        _playerData = DataManager.Instance.ReadParameters();
        _nameText.text = _playerData.name;
        UpdateHealthText();
        ChangeSliderValue(0);
    }

    public void ChangeSliderValue(int health)
    {
        _playerData.Health += health;

        _healthSlider.value = (float)_playerData.Health / 100;

        UpdateHealthText();
    }

    private void UpdateHealthText()
    {
        _healthText.text = _playerData.Health + " years old";
    }

    public void Save()
    {
        DataManager.Instance.PlayerData = _playerData;
        DataManager.Instance.WriteData();
        Debug.Log("Saved");
    }
}
