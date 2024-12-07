using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keypad : MonoBehaviour
{
    public GameObject keyCode;
    public GameObject activateText;
    bool interactable;

    [Header("Keypad Settings")]
    public string curPassword = "587";
    public string input;
    public Text displayText;
    public AudioSource audioData;

    //Local private variables
    private bool keypadScreen;
    private float btnClicked = 0;
    private float numOfGuesses;

    // Start is called before the first frame update
    void Start()
    {
        btnClicked = 0; // No of times the button was clicked
        numOfGuesses = curPassword.Length; // Set the password length.
    }

    void Update()
    {
        // Player active the keypad
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                activateText.SetActive(false);
                keypadScreen = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        // Enter the password
        if (btnClicked == numOfGuesses)
        {
            // Enter correct password then the door will open
            if (input == curPassword)
            {
                input = ""; //Clear Password
                btnClicked = 0;
                FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
                keypadScreen = false;
            }
            // Enter not correct password then reset the input password
            else
            {
                //Reset input varible
                input = "";
                displayText.text = input.ToString();
                audioData.Play();
                btnClicked = 0;
            }

        }

        // Show UI of entering the keypad
        if (keypadScreen)
        {
            keyCode.SetActive(true);
        }
        else if (!keypadScreen)
        {
            keyCode.SetActive(false);
        }
    }

    void OnGUI()
    {
        // Action for clicking keypad( GameObject ) on screen
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("keypad")) // Tag on the gameobject - Note the gameobject also needs a box collider
                {
                    keypadScreen = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        keypadScreen = true;
                    }
                }

            }
        }

        // Disable sections when keypadScreen is set to true
        if (keypadScreen)
        {
            keyCode.SetActive(true);
        }

    }

    // When player input the value by click the button on screen
    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                keyCode.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                Cursor.lockState = CursorLockMode.Locked;
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }
    }

    // Player near the keypad
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(true);
            interactable = true;
        }
    }

    // Player leave the keypad
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(false);
            interactable = false;
        }
    }
}
