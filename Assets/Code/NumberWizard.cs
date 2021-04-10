using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    [SerializeField] int max;
    int min = 1;
    [SerializeField] Text guessText;
    int guess;

    void StartGame() 
    {
        max = Random.Range(2, 1001);
        guessCalculator();
    }

    public void OnPressHigher()
    {
            max = guess - 1;
            guessCalculator();
    }

    public void OnPressLower()
    {
            min = guess + 1;
            guessCalculator();
    }

    void guessCalculator()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

    public void quitGame()
    {
        Application.Quit();
    }
    void Start()
    {
        StartGame();
    }
    // Update is called once per frame
}
