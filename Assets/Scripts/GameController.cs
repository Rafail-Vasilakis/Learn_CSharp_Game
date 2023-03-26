using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    // The question text
    public TextMeshProUGUI questionText;

    // The four answer buttons
    public Button buttonA;
    public Button buttonB;
    public Button buttonC;
    public Button buttonD;

    // The text for each answer button
    public TextMeshProUGUI textA;
    public TextMeshProUGUI textB;
    public TextMeshProUGUI textC;
    public TextMeshProUGUI textD;

    // The feedback text
    public TextMeshProUGUI feedbackText;

    // The correct answer
    private string correctAnswer;

    // Start is called before the first frame update
    void Start()
    {
        // Set the question text and answer choices
        questionText.text = "What is the difference between a variable and a constant in C#?";
        textA.text = "Variables can be assigned a value only once, while constants can be changed multiple times.";
        textB.text = "Variables can be changed during runtime, while constants cannot be changed.";
        textC.text = "Variables and constants are the same thing in C#.";
        textD.text = "Variables are used for storing data, while constants are used for storing methods.";

        // Set the correct answer
        correctAnswer = "a";

        // Set the text for each answer button
        buttonA.GetComponentInChildren<TextMeshProUGUI>().text = "A) " + textA.text;
        buttonB.GetComponentInChildren<TextMeshProUGUI>().text = "B) " + textB.text;
        buttonC.GetComponentInChildren<TextMeshProUGUI>().text = "C) " + textC.text;
        buttonD.GetComponentInChildren<TextMeshProUGUI>().text = "D) " + textD.text;

        // Add event listeners to each answer button
        buttonA.onClick.AddListener(() => { CheckAnswer("a"); });
        buttonB.onClick.AddListener(() => { CheckAnswer("b"); });
        buttonC.onClick.AddListener(() => { CheckAnswer("c"); });
        buttonD.onClick.AddListener(() => { CheckAnswer("d"); });

        // Hide the feedback text initially
        feedbackText.gameObject.SetActive(false);
    }


    // Check the selected answer against the correct answer
    void CheckAnswer(string selectedAnswer)
    {
        if (selectedAnswer == correctAnswer)
        {
            feedbackText.text = "Correct!";
        }
        else
        {
            feedbackText.text = "Incorrect.";
        }
        questionText.enabled = false;
        buttonA.gameObject.SetActive(false);
        buttonB.gameObject.SetActive(false);
        buttonC.gameObject.SetActive(false);
        buttonD.gameObject.SetActive(false);
        // Show the feedback text
        feedbackText.gameObject.SetActive(true);
    }
}
