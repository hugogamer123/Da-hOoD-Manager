using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class RandomDay : MonoBehaviour
{
    public TextMeshProUGUI Text;

    public GameObject panel;
    public GameObject Background;

    private int RandomGenAmount;

    public int SelectedDay;
    private void Start()
    {
        panel.SetActive(false);
        Background.SetActive(false);
    }
    public void OnButtonClick()
    {
        panel.SetActive(true);
        Background.SetActive(true);
        GenerateDay();
    }
    
    public void GenerateDay() 
    {
        SelectedDay = Random.Range(1, 31);
        SelectedDay = Random.Range(1, 31);
        SelectedDay = Random.Range(1, 31);
        SelectedDay = Random.Range(1, 31);
        SelectedDay = Random.Range(1, 31);
        Text.text = $"The new Da Hood day is the {SelectedDay}!";
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitButton();
        }

    }

    public void ExitButton()
    {
        panel.SetActive(false);
        Background.SetActive(false);
    }
}
