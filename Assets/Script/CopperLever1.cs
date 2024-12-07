using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopperLever1 : MonoBehaviour
{
    public Animator copperLeverAnimator;
    public Animator CopperGateAnimator;
    public GameObject activateText;
    bool interactable, copperLeverActive;

    void Start()
    {
        copperLeverActive = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                activateText.SetActive(false);
                copperLeverActive = true;
            }
        }

        if (copperLeverActive)
        {
            copperLeverAnimator.SetBool("isActive", true);
            CopperGateAnimator.SetBool("isOpened", true);
            FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(true);
            interactable = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(false);
            interactable = false;
        }
    }
}
