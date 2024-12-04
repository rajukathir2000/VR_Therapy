using UnityEngine;
using UnityEngine.UI;

public class DDSelection : MonoBehaviour
{
    public Dropdown d1,d2;

    private const string d1Key = "Dropdown1Selection";
    private const string d2Key = "Dropdown2Selection";

    void Start()
    {
        // Load saved selections
        if (PlayerPrefs.HasKey(d1Key))
            d1.value = PlayerPrefs.GetInt(d1Key);

        if (PlayerPrefs.HasKey(d2Key))
            d2.value = PlayerPrefs.GetInt(d2Key);

        d1.onValueChanged.AddListener(SaveDropdown1Selection);
        d2.onValueChanged.AddListener(SaveDropdown2Selection);
    }

    void SaveDropdown1Selection(int value)
    {
        PlayerPrefs.SetInt(d1Key, value);
        PlayerPrefs.Save();
        Debug.Log($"Dropdown1 selection saved: {d1.options[value].text}");
    }

    void SaveDropdown2Selection(int value)
    {
        PlayerPrefs.SetInt(d2Key, value);
        PlayerPrefs.Save();
        Debug.Log($"Dropdown2 selection saved: {d2.options[value].text}");
    }

    public void DisplaySelections()
    {
        Debug.Log($"Dropdown1 Selected: {d1.options[d1.value].text}");
        Debug.Log($"Dropdown2 Selected: {d2.options[d2.value].text}");
    }
}
