using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    int maxNumber;
    int minNumber;
    int guess;
    [SerializeField] TextMeshProUGUI textComponent;

    void Start()
    {
        startScene();
    }

    void startScene()
    {
        maxNumber = 1000;
        minNumber = 1;
        guess = (maxNumber + minNumber) / 2;
        textComponent.text = guess.ToString();
        maxNumber += 1;
    }

    void nextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
    }

    public void Higher()
    {
        minNumber = guess;
        nextGuess();
        textComponent.text = guess.ToString();
    }

    public void Lower()
    {
        maxNumber = guess;
        nextGuess();
        textComponent.text = guess.ToString();
    }

}
