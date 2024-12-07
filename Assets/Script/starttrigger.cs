using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class starttrigger : MonoBehaviour
{
    private void OnTriggerEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
