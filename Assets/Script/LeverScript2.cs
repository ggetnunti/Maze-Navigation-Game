using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverScript2 : MonoBehaviour
{
    public Animator GoldLeverAnimator;
    public Animator CopperLeverAnimator;
    public Animator GoldDoorAnimator;
    public Animator CopperDoorAnimator;

    private bool goldLeverActive, copperLeverActive;

    void Start()
    {
        goldLeverActive = false;
        copperLeverActive = false;
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
            GoldLeverAnimator.SetBool("isActive", true);
            GoldDoorAnimator.SetBool("isOpened", true);
        }

        if (copperLeverActive)
        {
            CopperLeverAnimator.SetBool("isActive", true);
            FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
        }
    }
}
