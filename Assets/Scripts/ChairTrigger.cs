using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChairTrigger : MonoBehaviour
{
    [SerializeField]
    private GameObject presstext;
    [SerializeField]
    private GameObject boardtext;

    [SerializeField]
    private GameObject optionstext;

    [SerializeField]
    private GameObject camera;

    private bool isPlayerInside;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            presstext.SetActive(true);
            boardtext.SetActive(false);
            optionstext.SetActive(false);
            isPlayerInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            boardtext.SetActive(false);
            presstext.SetActive(false);
            optionstext.SetActive(false);
            isPlayerInside = false;
        }
    }

    private void Update()
    {
        if (isPlayerInside && Keyboard.current.eKey.wasPressedThisFrame)
        {
            Debug.Log("E key pressed while inside trigger");
            presstext.SetActive(false);
            boardtext.SetActive(true);
            optionstext.SetActive(false);
            camera.SetActive(false);

            if (boardtext == true)
            {
                optionstext.SetActive(true);
            }
        }
    }
}