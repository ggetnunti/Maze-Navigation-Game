using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    public GameObject doorCollider, keyIcon;

    // Start is called before the first frame update
    void Start()
    {
        keyIcon.gameObject.SetActive(false);
        doorCollider.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keyIcon.gameObject.SetActive(true);
            FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
            Destroy(gameObject);
        }
    }
}
