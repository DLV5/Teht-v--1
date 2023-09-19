using TMPro;
using UnityEngine;

public class FieldScript : MonoBehaviour
{
    void Start()
    {
        var input = gameObject.GetComponent<TMP_InputField>();
 
        input.onEndEdit.AddListener(SubmitName);
    }

    private void SubmitName(string name)
    {
        Debug.Log(name);
        DataManager.Instance.PlayerData.name = name;
        DataManager.Instance.PlayerData.Health = 100;
    }
}