using System.Collections.Generic;
using NUnit.Framework;
using TMPro;
using UnityEngine;
using PanelManager;

public class RandomQuote : MonoBehaviour
{
    public List<string> Quote = new List<string>();
    public TextMeshProUGUI text;
    public GameObject panel;
    public GameObject Background;

    private string selectedQuote;

    private void Start()
    {
        panel.SetActive(false);
        Background.SetActive(false);
    }
    public void OnButtonClick()
    {
        panel.SetActive(true);
        Background.SetActive(true);
        GenerateQuote();
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

    public void GenerateQuote()
    {
        selectedQuote = Quote[Random.Range(0, Quote.Count)];
        selectedQuote = Quote[Random.Range(0, Quote.Count)];
        selectedQuote = Quote[Random.Range(0, Quote.Count)];
        selectedQuote = Quote[Random.Range(0, Quote.Count)];
        selectedQuote = Quote[Random.Range(0, Quote.Count)];
        text.text = $"You must say \"{selectedQuote}\"";
    }
}
