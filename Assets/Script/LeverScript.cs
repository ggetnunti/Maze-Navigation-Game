using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript : MonoBehaviour
{
    public Animator goldLeverAnimator;
    public Animator copperLeverAnimator;
    public Animator goldGate1Animator;
    public Animator goldGate2Animator;
    public Animator goldDoorAnimator;
    public Animator CopperGateAnimator;

    private bool goldLeverActive, copperLeverActive;

    void Start()
    {
        goldLeverActive = false;
        copperLeverActive = false;
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        // Action for clicking Lever( GameObject ) on screen
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                var selection = hit.transform;

                if (selection.CompareTag("GoldLever"))
                {
                    goldLeverActive = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        goldLeverActive = true;
                    }
                }

                if (selection.CompareTag("CopperLever"))
                {
                    copperLeverActive = true;

                    var selectionRender = selection.GetComponent<Renderer>();
                    if (selectionRender != null)
                    {
                        copperLeverActive = true;
                    }
                }
            }
        }

        if (goldLeverActive)
        {
            goldLeverAnimator.SetBool("isActive", true);
            goldGate1Animator.SetBool("isOpened", true);
            goldGate2Animator.SetBool("isOpened", true);
            goldDoorAnimator.SetBool("isOpened", true);
        }

        if (copperLeverActive)
        {
            copperLeverAnimator.SetBool("isActive", true);
            CopperGateAnimator.SetBool("isOpened", true);
            FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
        }
    }
}
