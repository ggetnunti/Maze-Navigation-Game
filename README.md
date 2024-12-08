<div id="top"></div>

<p align="center">
  <h1 align="center">Maze navigation game in Unity</h1>
</p>

<p align="center">
  <a href="#-abstract">Abstract</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-stack">Stack</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-structure">Structure</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#-execution">Execution</a>
</p> 

## Abstract

This project focuses on the building of a maze navigation game using Unity, trying to produce an entertaining and informative gaming experience. The primary purpose is to challenge players with progressively complicated mazes that test their problem-solving and spatial reasoning skills. The game serves not only as an entertaining pastime for players but also as a learning opportunity for the creator, emphasizing the actual application of game design ideas and programming within the Unity environment.

The project's goals encompass the creation of mazes that gradually escalate in complexity, the integration of seamless and instinctive player controls, and the implementation of dynamic camera systems to augment gameplay. Furthermore, the game offers several degrees of difficulty to accommodate a diverse group of players, ranging from novices to those in search of a more demanding experience.

The fundamental gameplay features include the acquisition of keys, the avoidance of traps, and the identification of the maze exit within a predetermined time constraint, therefore introducing a sense of urgency and exhilaration to the player's playing experience. Unity's physics engine is applied to simulate realistic player movements and collisions, contributing to the game's immersive quality. Furthermore, the game is developed with scalability in mind, allowing for the possible inclusion of new features such as a variety of mazes and multiplayer modes.

The outcomes of the project indicate Unity's success in developing a hard, engaging puzzle game with an emphasis on user experience, ensures that the game is both fun and repeatable, delivering lasting value to players and a solid platform for future development.

## Game Designs

This game is designed as a third-person adventure game and is a 3D game. The story is that the player will play the role of a character named Oliver, who goes to find Malina, who is trapped in a maze. Oliver must find the key, solve puzzles (find numbers to open the door), and pull the lever to open the door to the next level. Inside the level, there will be many obstacles, such as thorns or barbed wire, including enemies patrolling the level. The player must hide from the enemies to avoid being caught. The game is designed for the player to control through the [W, A, S, D] keys on the keyboard to walk, [Spacebar] to jump, and [Shift] to run.

### Characters

The characters in the game, whether they are player characters, supporting characters, or enemies, including character animations, were all modelled from the Mixamo website. On this website, developers can download characters and animations for free to use for study. However, within the given time frame, it was not possible to create all the character models in time, so it was necessary to get the models from external websites to complete the project quickly. The free models that are downloaded are like fictional characters in the game.

<p align="center"><img src="https://drive.google.com/uc?id=1DuQ6Hm6lC81MVTGt6gsRyej0ybCPKAbB" width="500" height="350"><br /> 
<b>Figure 1:</b> Characters and Animations in mixamo website</p>

<p align="center"><img src="https://drive.google.com/uc?id=1lZoJu-Ha1kqF3LhMK4mlRKoIO5JBtXRi" width="500" height="350"><br /> 
<b>Figure 2:</b> Characters and Animations in Unity</p>

### Models

Some of the models in the game were created in Blender 3D, such as keys, items, obstacles, and levers, and imported into Unity as .fbx files. Blender 3D is a free and easy-to-use program for creating models. Some models, such as walls and mazes in the level, were created in Unity itself. These models are simple or have a square shape. Some models, such as gates or torches, are quite complex and difficult to create yourself, so they need to be imported from the Asset Store. All these models we import for free.

<p align="center"><img src="https://drive.google.com/uc?id=1srolojESrphz_aM-Si1AyfftiiXBME2J" width="500" height="350"><br /> 
<b>Figure 3:</b> Key model in Blender 3D</p>

### Maps

For each level in the game, from the first level to the last level, we have designed it by planning and sketching the outline of the level first. Each level has different puzzles and gameplay, and we think of various elements that will be used in the level, such as placing obstacles, enemies, and tools in the level, making each level different, including creating a storyline for each level, attracting players to want to play the next level in order to know the story of the game and solve the puzzles that will be encountered.

### Sound Effects

For the in-game sound effects, we used sound files .mp3 and .wav that were downloaded from the freesound website. This website has a variety of sound effects to choose from. You can download them for free for non-profit purposes. The sounds used range from the sounds of collecting items and hitting obstacles to background sounds, enemy sounds, and various sound effects.

<p align="center"><img src="https://drive.google.com/uc?id=1ZV1q_fr-DBsL5rUBQB2LEJv32p_5aPSK" width="500" height="350"><br /> 
<b>Figure 4:</b> Sound effects in freesound.org</p>

## Implementation

In this project, we use Unity to create the game. We arrange the various elements in the game, such as levels, objects, characters, and sounds. We create models of various objects in the game from both the program itself and other programs, including writing scripts in C# to execute commands for objects in the game. We also design the game's UI to respond to standard user experience, making it easy for players to understand the game and attracting players' interest in playing it.

### Load Scenes

When build game application, Unity builds all selected scenes in the Scenes in Build pane. Unity builds scenes in the order in which they appear in the list. Game scenes are stored in the Assets > Scenes file. Scenes can be configured to be called when a button is pressed within the game UI. Scenes within the game are called through the Scene Manager. 

<p align="center"><img src="https://drive.google.com/uc?id=1Fth7v-JAqYuXd3aYMaazqVG2BdeSfURv" width="600" height="150"><br /> 
<b>Figure 5:</b> Scenes in Build Setting</p>

<p align="center"><img src="https://drive.google.com/uc?id=1WSTHA7EWU41Dq_7FXQgI77xo4wKPiU94" width="600" height="150"><br /> 
<b>Figure 6:</b> Game scene files</p>

- Levelhandler.cs
```bash
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
```

### Game Manager

In each game scene, the Game Manager object is used to set the main UI for the game, including hearts, timers, collected coins, displaying the UI of the pause menu, game over and level complete, and loading scenes. Additionally, the Game Manager object is also called other UI objects within the game.

<p align="center"><img src="https://drive.google.com/uc?id=1qsKjmkff8ffpa2CCfHOyjdCB9CaUlEhl" width="275" height="400"><br /> 
<b>Figure 7:</b> Game Manager Object</p>

- Setting when game start in GameManager.cs
```bash
// Set 5 health when game start and hide game over and level complete UI
    void Start()
    {
        health = 5;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
        heart5.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);
        levelComplete.gameObject.SetActive(false);
    }
```

-  Health check in GameManager.cs
```bash
// Check health is called once per frame, when zero health will show game over UI
    void Update()
    {
        if (health > 5)
        {
            health = 5;
        }
        switch(health)
        {
            case 5:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(true);
                break;
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                heart5.gameObject.SetActive(false);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                break;
            default:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                heart5.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                isGameOver = true;
                audioManager.PlaySFX(audioManager.gameover);
                Time.timeScale = 0;
                Cursor.lockState = CursorLockMode.None;
                break;
        }
    }
```

- Complete the level in GameManager.cs
```bash
// when complete the level will show level complete UI and calculate the hight score then record the result
    public void CompleteLevel()
    {
        TimerScript.activeTimer = false;
        levelComplete.gameObject.SetActive(true);
        isCompleteLevel = true;
        audioManager.PlaySFX(audioManager.levelcomplete);
        Cursor.lockState = CursorLockMode.None;
        switch (level)
        {
            case "lv2":
                HightScore("lv2Mins", "lv2Secs", "lv2Time", "lv2Coin");
                break;
            case "lv2h":
                HightScore("lv2hMins", "lv2hSecs", "lv2hTime", "lv2hCoin");
                break;
            case "lv3":
                HightScore("lv3Mins", "lv3Secs", "lv3Time", "lv3Coin");
                break;
            case "lv3h":
                HightScore("lv3hMins", "lv3hSecs", "lv3hTime", "lv3hCoin");
                break;
            case "lv4":
                HightScore("lv4Mins", "lv4Secs", "lv4Time", "lv4Coin");
                break;
            case "lv4h":
                HightScore("lv4hMins", "lv4hSecs", "lv4hTime", "lv4hCoin");
                break;
            case "lv5":
                HightScore("lv5Mins", "lv5Secs", "lv5Time", "lv5Coin");
                break;
            case "lv5h":
                HightScore("lv5hMins", "lv5hSecs", "lv5hTime", "lv5hCoin");
                break;
            default:
                break;
        }
        
    }

    // calculate the hight score
    void HightScore(string mins, string secs, string time, string coin)
    {
        if ((TimerScript.completeMins <= PlayerPrefs.GetInt(mins) && TimerScript.completeSecs <= PlayerPrefs.GetInt(secs)) || PlayerPrefs.GetString(time) == "")
        {
            PlayerPrefs.SetInt(mins, TimerScript.completeMins);
            PlayerPrefs.SetInt(secs, TimerScript.completeSecs);

            PlayerPrefs.SetString(time, TimerScript.completeTime);
        }
        if (CoinManager.coinCount >= PlayerPrefs.GetInt(coin))
        {
            PlayerPrefs.SetInt(coin, CoinManager.coinCount);
        }
    }
```

### Dialogue

Dialogues are the words that the characters say that will appear at the beginning of the level. They will help create the storyline for our game. For dialogues that are used in the game, we will create a dialogue UI object and then write a script for the dialogue text to print each letter every 0.1 seconds; then we can increase the number of lines as needed.

<p align="center"><img src="https://drive.google.com/uc?id=161fB5rX6s_RHlpWL6zqXKiJ1TtoIXb_w" width="300" height="150"><br /> 
<b>Figure 8:</b> Dialogue Script componant in Dialogue object</p>

- Dialogue.cs
```bash
void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        if (textComponent.text == lines[index])
        {
            NextLine();
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    //typing char in line
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //going to next line
    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false); //set active false when finish all lines
        }
    }
```

### Player Character

The player character controls are from Unity's Asset store, which developers can download and import for free for educational and non-profit use. The imported assets are called 'Starter Assets - ThirdPerson | Updates in new CharacterController package' from 'Unity Technologies'. When we import this asset into our game, we have a third-person character that we can control, such as walking, jumping, and running and the main camera will follow the player's character, this asset makes it very easy and time-saving for game development.

<p align="center"><img src="https://drive.google.com/uc?id=1UsUuP2L12qS2R1TpU7ocMFbhm4DS8-xj" width="500" height="350"><br /> 
<b>Figure 9:</b> ‘Starter Assets – ThirdPerson’ in Unity's Asset store</p>

### Items

Items in the game, such as coins, hearts, keys, and energy drinks, can be collected at different levels. When collected, they will interact with the game, such as collecting coins to increase scores, collecting hearts to increase blood, collecting keys to open doors, and collecting energy drinks to increase movement speed. All items that can be collected will be scripted so that objects can rotate, and when items are collected by the player, they will disappear. As for the player's character, it will be scripted to make some changes when entering the collider of any objects.

- ItemScript.cs
```bash
    void Update()
    {
        // rotate the object
        transform.Rotate(new Vector3(0, 45, 0)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // when the item collected by player, it will destroy
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
```

- Collect the items in PlayControl.cs
```bash
    // When player enter the collider of any objects
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key"))
        {
            audioManager.PlaySFX(audioManager.doorOpen);
            other.gameObject.SetActive(false);
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
    }
```

### Maps

There are four levels in the game; each level has two levels of difficulty: normal and hard. In creating each level, we start by creating the floor object of the level and then creating the walls of the maze, with the elements of the level created from Unity's own 3D objects. Then, we lay out the structure of the maze from the previous design, set the starting point of the player character and the ending point of the level, and write a script for the ending point of the level. When the player enters this point, the level will immediately show as complete. Inside the level, we have decorated it with various textures and added lighting and shadows in various parts of the level.

<p align="center"><img src="https://drive.google.com/uc?id=1LcKrvMKK4vVtcuBViybAAdzyC7zDdPCv" width="500" height="350"><br /> 
<b>Figure 10:</b> Level creation in Unity</p>

### Obstacles

In the part of creating obstacles in the level, whether it is thorns or spikes, start by creating a model with the 3D Blender program by creating a 3D model of the Obstacle as we want, then export the model as a .fbx file so that the model created from the 3D Blender program can be used in the Unity program. After that, import the model that we created into the level in the Unity program, then add the texture and material of our model. Then, drag the model into the Prefabs file because this model is used repeatedly at the level. Then we have to change the tag of the obstacle object to Obstacle and write a script for the player that if we hit the Obstacle, it will reduce the heaths by one unit.

<p align="center"><img src="https://drive.google.com/uc?id=1lYTIkKWqJtORgQqWSDsltXh46ndAFIIR" width="250" height="300"><br /> 
<b>Figure 11:</b> Obstacle object</p>

- Hit the obstacle in PlayControl.cs
```bash
// When player enter the collider of any objects
    private void OnTriggerEnter(Collider other)
    {
	// When player hit the obstacle, it will reduce the heaths by 1 unit.
        if (other.gameObject.CompareTag("Obstacle"))
        {
            audioManager.PlaySFX(audioManager.bush);
            GameManager.health -= 1;
        }
    }
```

In obstacles such as spikes, it works differently than other obstacles because it has a rhythmic animation of spikes going up and down. Therefore, we need to create a loop of spike animation that has the spikes going up and down rhythmically so that the player can walk over the spikes if they are going down, but if the player walks over the spikes while they are going up, the player will lose health.

<p align="center"><img src="https://drive.google.com/uc?id=1J6Yn3U5y-q-wrKgVNSAvxnV30DpuZrO2" width="500" height="350"><br /> 
<b>Figure 12:</b> Create animation of spike</p>

### Gates

To create a gate in the game, whether it is an exit gate or a gate to go to another part of the level, the gate model was imported from Unity's Asset Store. Then, the gate animation was created while it was closed and opened. Then, the gate animator was created, which is the arrangement of the door animation. The animation will change from a closed door to an open door if certain actions are performed, such as picking up a key, entering a code into the keypad, or pulling a lever to open the door. Then, the end trigger object was placed behind the exit gate to act as a point where the player reaches it and completes the level.

<p align="center"><img src="https://drive.google.com/uc?id=152eWk7X9u0NtMfYQXJooT2he2JJ9H3yK" width="500" height="350"><br /> 
<b>Figure 13:</b> Gate Animation</p>

<p align="center"><img src="https://drive.google.com/uc?id=1L-3DjAqqCrE3e8y0kXYafd6KcTN2cPXA" width="500" height="300"><br /> 
<b>Figure 14:</b> Gate animator/p>

- Active door animator in KeyScript.cs
```bash
private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            keyIcon.gameObject.SetActive(true);
            FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
            Destroy(gameObject);
        }
    }
```

### Lever

The lever in the game is for the player to pull down to open the door. Creating the lever starts with creating a model in the 3D Blender program; then the model is used in Unity. After adding texture and material, the lever animation is created both when it is not active and when it is active, and the order of the lever animation is arranged in Animator. After that, a script is written for the lever, stating that if the player is near the lever and presses the [E] button on the keyboard, the lever will be activated, and the door will be opened as specified for that lever.
