using UnityEngine;
using UnityEngine.SceneManagement;

public class levelhandler : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene("level1");
        RestartLevel();
    }

    public void Level1Hard()
    {
        SceneManager.LoadScene("level1hard");
        RestartLevel();
    }

    public void Level2()
    {
        SceneManager.LoadScene("level2");
        RestartLevel();
    }

    public void Level2Hard()
    {
        SceneManager.LoadScene("level2hard");
        RestartLevel();
    }

    public void Level3()
    {
        SceneManager.LoadScene("level3");
        RestartLevel();
    }

    public void Level3Hard()
    {
        SceneManager.LoadScene("level3hard");
        RestartLevel();
    }

    public void Level4()
    {
        SceneManager.LoadScene("level4");
        RestartLevel();
    }

    public void Level4Hard()
    {
        SceneManager.LoadScene("level4hard");
        RestartLevel();
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("credits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void RestartLevel()
    {
        Time.timeScale = 1;
        TimerScript.activeTimer = true;
        GameManager.health = 4;
        CoinManager.coinCount = 0;
        GameManager.isCompleteLevel = false;
        GameManager.isGameOver = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
