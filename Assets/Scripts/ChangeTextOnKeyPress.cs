using UnityEngine.InputSystem;
using TMPro;
using UnityEngine;

public class ChangeTextOnKeyPress : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI textMeshProUGUI;
    [SerializeField]
    private GameObject nextButton;
    [SerializeField]
    private float nextButtonDelay = 2f;

    private bool canChangeText = true;
    private int textState = 0;

    private void Start()
    {
        // Lock the cursor and hide it
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        if (Keyboard.current[Key.Digit1].wasPressedThisFrame && canChangeText)
        {
            // Change the text based on the current state
            if (textState == 0)
            {
                textMeshProUGUI.text = "Welcome to the Introduction to C# basics! In this tutorial, you will learn the fundamentals of C#, a modern," +
                    " general-purpose programming language used to build a wide range of applications, including video games, mobile apps, and web services." +
                    " C# was developed by Microsoft and is a key language in the .NET ecosystem.";
            }
          
            // Unlock the cursor and show it
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            // Show the next button after a delay
            Invoke("ShowNextButton", nextButtonDelay);

            canChangeText = false;
        }
    }

    private void ShowNextButton()
    {
        // Show the next button
        nextButton.SetActive(true);
    }

    public void OnNextButtonPressed()
    {
        // Change the text state and update the text based on the new state
        textState++;
        if (textState == 1)
        {
            nextButton.SetActive(false);
            textMeshProUGUI.text = "In this tutorial, we will cover the basic concepts of C#, including data types, variables, operators, control flow statements, " +
                "and object-oriented programming (OOP) principles. We will also explore some of the key features of the C# language, such as garbage collection, " +
                "delegates, and events.";
            Invoke("ShowNextButton", nextButtonDelay);
        }

        else if (textState == 2)
        {
            nextButton.SetActive(false);
            textMeshProUGUI.text = "By the end of this tutorial, you will have a solid understanding of the core concepts of C#, and you will be able to write simple C#" +
                " programs on your own. Let's get started!";
            Invoke("ShowNextButton", nextButtonDelay);
        }

        else if (textState == 3)
        {
            nextButton.SetActive(false);
            textMeshProUGUI.text = "By the end of this tutorial, you will have a solid understanding of the core concepts of C#, and you will be able to write simple C#" +
                " programs on your own. Let's get started!";
        }
    }
}
