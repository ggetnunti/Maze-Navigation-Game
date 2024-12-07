using System.Collections;
using System.Collections.Generic;
using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class PlayControl : MonoBehaviour
{
    public Animator doorAnimator;
    public bool isCollected;
    public GameObject energyDrinkIcon;

    AudioManager audioManager;
    ThirdPersonController thirdPersonController;

    private void Awake()
    {
        isCollected = false;
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
        thirdPersonController = GetComponent<ThirdPersonController>();
    }

    // When player enter the collider of any objects
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            audioManager.PlaySFX(audioManager.doorOpen);
            other.gameObject.SetActive(false);
        }

        if (other.gameObject.CompareTag("DoorCollider"))
        {
            isCollected = true;
            doorAnimator.SetBool("isCollected", isCollected);
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            audioManager.PlaySFX(audioManager.bush);
            GameManager.health -= 1;
        }

        if (other.gameObject.CompareTag("Coin"))
        {
            audioManager.PlaySFX(audioManager.coin);
            CoinManager.coinCount += 1;
        }

        if (other.gameObject.CompareTag("BigCoin"))
        {
            audioManager.PlaySFX(audioManager.bigCoin);
            CoinManager.coinCount += 10;
        }

        if (other.gameObject.CompareTag("Heart"))
        {
            audioManager.PlaySFX(audioManager.heart);
            GameManager.health += 1;
        }

        if (other.gameObject.CompareTag("EnergyDrink"))
        {
            energyDrinkIcon.gameObject.SetActive(true);
            audioManager.PlaySFX(audioManager.heart);
            thirdPersonController.IncreaseSpeed();
        }

        if (other.gameObject.CompareTag("Enemy"))
        {
            audioManager.PlaySFX(audioManager.bush);
            GameManager.health -= 5;
        }
    }
}
