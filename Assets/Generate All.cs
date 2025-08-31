using TMPro;
using UnityEngine;

public class GenerateAll : MonoBehaviour
{
    //Scripts
    public RandomDay RandomDay;
    public RandomQuote RandomQuote;
    //Panels
    public GameObject RandomDayPanel;
    public GameObject RandomQuotePanel;
    //Only buttons to disable
    public GameObject ExitButtton1;
    public GameObject ExitButtton2;
    //New Exit Button
    public GameObject RealExitButton;
    //Background Blur
    public GameObject BackgroundBlur;

    public void OnButtonClick()
    {
        GenerateAllStuff();
    }

    void Start()
    {
        RandomDayPanel.transform.position = new Vector2(2, -20);
        RealExitButton.SetActive(false);
    }

    void GenerateAllStuff()
    {
        RectTransform rectTransformDay = RandomDayPanel.GetComponent<RectTransform>();
        RectTransform rectTransformQuote = RandomQuotePanel.GetComponent<RectTransform>();


        RandomDay.GenerateDay();
        RandomQuote.GenerateQuote();
        RandomDayPanel.gameObject.SetActive(true);
        RandomQuotePanel.gameObject.SetActive(true);
        rectTransformDay.anchoredPosition = new Vector2(2, -241);
        ExitButtton1.SetActive(false);
        ExitButtton2.SetActive(false);

        RealExitButton.SetActive(true);

        BackgroundBlur.SetActive(true);
    }

    public void ExitButton()
    {
        RandomDayPanel.gameObject.SetActive(false);
        RandomQuotePanel.gameObject.SetActive(false);
        RandomDayPanel.transform.position = new Vector2(2, -20);
        RealExitButton.SetActive(false);
        BackgroundBlur.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ExitButton();
        }
    }
}
