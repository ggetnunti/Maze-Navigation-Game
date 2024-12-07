using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldLever1 : MonoBehaviour
{
    public Animator goldLeverAnimator;
    public Animator goldGate1Animator;
    public Animator goldGate2Animator;
    public Animator goldDoorAnimator;
    public GameObject activateText;
    bool interactable, goldLeverActive;

    void Start()
    {
        goldLeverActive = false;
    }

    // Active the lever when the player press E to the lever
    void Update()
    {
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                activateText.SetActive(false);
                goldLeverActive = true;
            }
        }

        if (goldLeverActive)
        {
            goldLeverAnimator.SetBool("isActive", true);
            goldGate1Animator.SetBool("isOpened", true);
            goldGate2Animator.SetBool("isOpened", true);
            goldDoorAnimator.SetBool("isOpened", true);
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
