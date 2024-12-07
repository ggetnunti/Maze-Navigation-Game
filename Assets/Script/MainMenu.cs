using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject level1Menu;
    public GameObject level2Menu;
    public GameObject level3Menu;
    public GameObject level4Menu;
    public GameObject howToPlay1Menu;
    public GameObject howToPlay2Menu;
    public GameObject howToPlay3Menu;
    public GameObject howToPlay4Menu;

    levelhandler selectLevel;

    private void Awake()
    {
        selectLevel = GetComponent<levelhandler>();
    }

    void Start()
    {
        startMenu.SetActive(false);
        level1Menu.SetActive(false);
        level2Menu.SetActive(false);
        level3Menu.SetActive(false);
        level4Menu.SetActive(false);
        howToPlay1Menu.SetActive(false);
        howToPlay2Menu.SetActive(false);
        howToPlay3Menu.SetActive(false);
        howToPlay4Menu.SetActive(false);
    }

    public void Back()
    {
        startMenu.SetActive(false);
        level1Menu.SetActive(false);
        level2Menu.SetActive(false);
        level3Menu.SetActive(false);
        level4Menu.SetActive(false);
        howToPlay1Menu.SetActive(false);
        howToPlay2Menu.SetActive(false);
        howToPlay3Menu.SetActive(false);
        howToPlay4Menu.SetActive(false);
    }

    public void StartButton()
    {
        startMenu.SetActive(true);
    }

    public void SelectLevelButton()
    {
        level1Menu.SetActive(true);
    }

    public void SelectLevelNext1()
    {
        level1Menu.SetActive(false);
        level2Menu.SetActive(true);
    }

    public void SelectLevelNext2()
    {
        level2Menu.SetActive(false);
        level3Menu.SetActive(true);
    }

    public void SelectLevelNext3()
    {
        level3Menu.SetActive(false);
        level4Menu.SetActive(true);
    }

    public void SelectLevelBack1()
    {
        level1Menu.SetActive(true);
        level2Menu.SetActive(false);
    }

    public void SelectLevelBack2()
    {
        level2Menu.SetActive(true);
        level3Menu.SetActive(false);
    }

    public void SelectLevelBack3()
    {
        level3Menu.SetActive(true);
        level4Menu.SetActive(false);
    }

    public void HowToPlayButton()
    {
        howToPlay1Menu.SetActive(true);
    }

    public void HowToPlayNext1()
    {
        howToPlay1Menu.SetActive(false);
        howToPlay2Menu.SetActive(true);
    }

    public void HowToPlayNext2()
    {
        howToPlay2Menu.SetActive(false);
        howToPlay3Menu.SetActive(true);
    }

    public void HowToPlayNext3()
    {
        howToPlay3Menu.SetActive(false);
        howToPlay4Menu.SetActive(true);
    }

    public void HowToPlayBack1()
    {
        howToPlay1Menu.SetActive(true);
        howToPlay2Menu.SetActive(false);
    }

    public void HowToPlayBack2()
    {
        howToPlay2Menu.SetActive(true);
        howToPlay3Menu.SetActive(false);
    }

    public void HowToPlayBack3()
    {
        howToPlay3Menu.SetActive(true);
        howToPlay4Menu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
