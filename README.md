<div id="top"></div>

<p align="center">
  <h1 align="center">Maze navigation game in Unity</h1>
</p>

<p align="center">
  <a href="#abstract">Abstract</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#game-designs">Game Designs</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#implementation">Implementation</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#test-and-evaluation">Test and Evaluation</a>&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
  <a href="#conclusion">Conclusion</a>
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
<b>Figure 14:</b> Gate animator</p>

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

<p align="center"><img src="https://drive.google.com/uc?id=1BRpN4AS1q4fRzdkoVhc277CwWL0mzG0G" width="500" height="350"><br /> 
<b>Figure 15:</b> Lever animation and animator</p>

<p align="center"><img src="https://drive.google.com/uc?id=1iwqfwhOil9WIxU_rTrDfYxomvfBJsRDD" width="500" height="350"><br /> 
<b>Figure 16:</b> Lever Collison Object</p>

- Active the lever in LeverScript.cs
```bash
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
```

### Keypad

The keypad is for the player to enter a code after finding all three digits on the level to open the exit door on the second level. The keypad used is from Unity's Asset Store. When the player presses the [E] key on the keyboard, the UI for entering a code on the keypad will appear. The player then enters a code on the screen. The keypad script will then check the code entered. If the number of codes entered is equal to the number of codes that are set in the script, it will check the correct code correctly. If it is correct, the exit door will open. If not, it will clear the value and require entering a new code.

- Enter the value in Keypad.cs
```bash
// When player input the value by click the button on screen
    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": // QUIT
                keyCode.SetActive(false);
                btnClicked = 0;
                keypadScreen = false;
                input = "";
                displayText.text = input.ToString();
                Cursor.lockState = CursorLockMode.Locked;
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0;// Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Buton clicked add a variable
                btnClicked++; // Add a guess
                input += valueEntered;
                displayText.text = input.ToString();
                break;
        }
    }
```

- Check the value and open the Keypad screen in Keypad.cs
```bash
void Update()
    {
        // Player active the keypad
        if (interactable == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                activateText.SetActive(false);
                keypadScreen = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }

        // Enter the password
        if (btnClicked == numOfGuesses)
        {
            // Enter correct password then the door will open
            if (input == curPassword)
            {
                input = ""; //Clear Password
                btnClicked = 0;
                FindObjectOfType<PlayControl>().doorAnimator.SetBool("isCollected", true);
                keypadScreen = false;
            }
            // Enter not correct password then reset the input password
            else
            {
                //Reset input varible
                input = "";
                displayText.text = input.ToString();
                audioData.Play();
                btnClicked = 0;
            }

        }

        // Show UI of entering the keypad
        if (keypadScreen)
        {
            keyCode.SetActive(true);
        }
        else if (!keypadScreen)
        {
            keyCode.SetActive(false);
        }
    }
```

- On trigger stay and exit in Keypad.cs
```bash
// Player near the keypad
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(true);
            interactable = true;
        }
    }

    // Player leave the keypad
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            activateText.SetActive(false);
            interactable = false;
        }
    }
```

### Enemy

To create enemies in the game, start by importing enemy models and animations from the mixamo website, then write a script for the enemy's actions. Within the script, the enemy will start patrolling and stop within the level. If the enemy encounters a player within the enemy's line of sight and a specified distance, the enemy's status will change from walking to chasing the player immediately. If the enemy collides with the player's collision, a game over will occur. Within the script, we can set the values of the enemy's destinations, walking speed, running speed, visibility distance, minimum and maximum idle time, and minimum and maximum chase time. After that, add a Nav Mesh Agent component to the enemy and change the size of the radius, height and base offset of the Nav Mesh Agent to match the size of the enemy. Add the destinations of the enemy to walk to by creating the game object to be the destination of the enemy and duplicating the destination a bunch so the enemy will have random destinations to go to. In the enemy script, add the destination objects to the destination elements. All of this is to create an enemy patrol within the level, where the enemy will move to the destination that we have set in the level. After that, go to the enemy animator to create the enemy animation condition to change the work, whether it is idle, walking, or chasing, by importing all the animations that we downloaded from the mixamo website and creating a transition arrow that goes to and from each animation. For each transition arrow, disable 'Has exit time' and apply the condition to it, such as if the transition arrow going to walk animation has the 'walk' condition. In the script component, set the walking speed, chase speed, min idle time, max idle time, min chase time, max chase time, sight distance and catch distance. Finally, AI navigation will be added to the scene. Select the level's floor and set it as 'Navigation Static' and set' Navigation Area' to 'Walkable', then select the maze's walls and set it as 'Navigation Static' and set' Navigation Area' to 'Not Walkable'. After that, go to the bake tab and bake the nav mesh. All of these are like enemy areas that can be walked around within the level.

<p align="center"><img src="https://drive.google.com/uc?id=1gRabuqWKj2WuYBq7eiHuXMtnW6lzBknE" width="300" height="500"><br /> 
<b>Figure 17:</b> Lever Collison Object</p>

<p align="center"><img src="https://drive.google.com/uc?id=1vTcQhipe5IHyhFBoIvXxh4g-wTJ6Fouw" width="300" height="350"><br /> 
<b>Figure 18:</b> Lever Collison Object</p>

<p align="center"><img src="https://drive.google.com/uc?id=1H01sS6vMz7LfgP6xihANWMJbbzwT5TjO" width="500" height="250"><br /> 
<b>Figure 19:</b> Lever Collison Object</p>

<p align="center"><img src="https://drive.google.com/uc?id=1tGq6PklnnRdRaEqjQfnM1eb3GaJ-Ynej" width="500" height="250"><br /> 
<b>Figure 20:</b> Enemy Animator</p>

- Enemy Behaviours in EnemyAI.cs
```bash
public NavMeshAgent ai;
    public List<Transform> destinations;
    public Animator aiAnim;
    public float walkSpeed, chaseSpeed, minIdleTime, maxIdleTime, idleTime, sightDistance, chaseTime, minChaseTime, maxChaseTime;
    public bool walking, chasing;
    public Transform player;
    Transform currentDest;
    Vector3 dest;
    int randNum;
    public int destinationAmount;
    public Vector3 rayCastOffset;

    // When start the enemy will patrol to the destination points.
    void Start()
    {
        walking = true;
        randNum = Random.Range(0, destinationAmount);
        currentDest = destinations[randNum];
    }

    void Update()
    {
        // The enemy will chase the player if the player's position on sight distance of the enemy.
        Vector3 direction = (player.position - transform.position).normalized;
        RaycastHit hit;
        if (Physics.Raycast(transform.position + rayCastOffset, direction, out hit, sightDistance))
        {
            if (hit.collider.gameObject.tag == "Player")
            {
                walking = false;
                StopCoroutine("stayIdle");
                StopCoroutine("chaseRoutine");
                StartCoroutine("chaseRoutine");
                chasing = true;
            }
        }
        // If enemy is chasing enemy will go to player position, change the speed and play the chasing animation.
        if (chasing == true)
        {
            dest = player.position;
            ai.destination = dest;
            ai.speed = chaseSpeed;
            aiAnim.ResetTrigger("walk");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("sprint");
        }
        // If enemy is not chasing the player, enemy will go to destination points and play the walking animation.
        if (walking == true)
        {
            dest = currentDest.position;
            ai.destination = dest;
            ai.speed = walkSpeed;
            aiAnim.ResetTrigger("sprint");
            aiAnim.ResetTrigger("idle");
            aiAnim.SetTrigger("walk");
            // When the enemy reach at some destination point, it will stop walking and play the idle animation.
            if (ai.remainingDistance <= ai.stoppingDistance)
            {
                aiAnim.ResetTrigger("sprint");
                aiAnim.ResetTrigger("walk");
                aiAnim.SetTrigger("idle");
                ai.speed = 0;
                StopCoroutine("stayIdle");
                StartCoroutine("stayIdle");
                walking = false;
            }
        }
    }
```

- Enemy Routine in EnemyAI.cs
```bash
// Routine for stay idle of the enemy.
    IEnumerator stayIdle()
    {
        idleTime = Random.Range(minIdleTime, maxIdleTime);
        yield return new WaitForSeconds(idleTime);
        walking = true;
        randNum = Random.Range(0, destinationAmount);
        currentDest = destinations[randNum];
    }

    // Routine for chasing of the enemy.
    IEnumerator chaseRoutine()
    {
        chaseTime = Random.Range(minChaseTime, maxChaseTime);
        yield return new WaitForSeconds(chaseTime);
        walking = true;
        chasing = false;
        randNum = Random.Range(0, destinationAmount);
        currentDest = destinations[randNum];
    }
```

- On Trigger Enter in PlayControl.cs
```bash
// When player enter the collider of any objects
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            audioManager.PlaySFX(audioManager.bush);
            GameManager.health -= 5;
        }
    }
```

### Sound Effect

In the part of creating sound effects within the game, we started by finding the sound effects that are suitable for the objects in the game, such as the sound of the background, the sound of collecting items, or the sound of enemies. We found and downloaded various sound effects from freesound website [18]. After that, in the game we created an object called Audio Manager, which contains two more objects:
- <b>Music:</b> This object is used to play the background music of the game. It is set to play on awake, loop, and have sound throughout the level.
- <b>SFX:</b> This object is used to play the sound effects of various objects in the game, such as the sound of picking up items, the sound of opening doors, the sound of hitting obstacles, or the sound of game over and level complete. This sound will be set to play when the object of that sound is active.

After that, a script is written for the Audio Manager object, which is a script that tells the game to start playing sounds from the Music object and playing other effects through the SFX object according to the parameters that are passed in.

<p align="center"><img src="https://drive.google.com/uc?id=1RXmeGTA3Ak3sAapjMiRfNasT9VWysUbQ" width="200" height="250"><img src="https://drive.google.com/uc?id=10lz53RJHee-DnBaVt05zlv4uJipg_kNh" width="200" height="400"><img src="https://drive.google.com/uc?id=1Y_FYclugPHtGISFhBLJhVUdclVLj2H4Q" width="200" height="400"><br /> 
<b>Figure 21:</b> Audio Manager, Music and SFX objects</p>

- AudioManager.cs
```bash
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    public AudioClip background;
    public AudioClip bush;
    public AudioClip coin;
    public AudioClip doorOpen;
    public AudioClip gameover;
    public AudioClip levelcomplete;
    public AudioClip bigCoin;
    public AudioClip heart;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
```

- Example of calling the Audio Manager class
```bash
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
```

For some sound effects, they will be played within the object animation, such as the sound of spikes going up and down, or the sound of enemies walking or chasing the player. These sounds are set to play through the object animation, playing the sound object when the animation starts or changes.

<p align="center"><img src="https://drive.google.com/uc?id=199LJn-Ziyxbc1r6quDBDsDxvTq1-N5hf" width="200" height="400"><img src="https://drive.google.com/uc?id=1teXDKxjKO379MN1L_DzSOg0USvhEdDP0" width="200" height="400"><br /> 
<b>Figure 22:</b> Spike up and spike down sound object</p>

<p align="center"><img src="https://drive.google.com/uc?id=1WncAJ7xxNgcvlgXF77iw9NnmWey-Ieeq" width="600" height="150"><br /> 
<b>Figure 22:</b> Spike up and spike down sound object</p>

## Test and Evaluation

### Main Menu

<p align="center"><img src="https://drive.google.com/uc?id=1uHUQ13esUD3MADVzZoNgzdi70tEdpqkx" width="500" height="350"><br /> 
<b>Figure 23:</b> Screenshot of Main menu scene</p>

After the player starts the game application, the game will start in the main menu scene and wait for the player for the next action. This scene is like a connection to other scenes. There are four options that the player can choose:

Start: Go to the first level scene (level 1) and select the difficulty level between Normal or Hard mode.

<p align="center"><img src="https://drive.google.com/uc?id=1rkr2UU3XheXuPxYS42IFJTBKoG6_vybd" width="400" height="250"><br /> 
<b>Figure 24:</b> Screenshot of Start option in menu</p>

Select Level: Go to choose the level and difficulty to play and show the high score (time spent and collected coins) of each level.

<p align="center"><img src="https://drive.google.com/uc?id=1OiUWApHIeZfxnO0JnznVy5q7Y2IrKrmg" width="400" height="250"><br /> 
<b>Figure 25:</b> Screenshot of Select Level option in menu</p>

How To Play?: Go to show you how to play and guide the object in the game, such as how to control the in-game character, collect the item, the obstacles and find the exit gate.

<p align="center"><img src="https://drive.google.com/uc?id=15G5yURxKnim5LqP0wAvuFzbnRUdyLeeq" width="400" height="250"><br /> 
<b>Figure 26:</b> Screenshot of How To Play? option in Menu</p>

Exit: Go to close the game application.


### Level 1

If the player chooses the Start option or Select Level 1 option and selects the difficulty mode at the Main Menu scene, the game will go to the first level (level 1) at the normal or hard mode that the player has chosen. Once the game starts, the screen will show the UI of hearts, time, collected coins, and the character's story chat dialogue. The playfield is the main viewport, which displays the maze environment and the in-game characters controlled by the player. The main character is always displayed at the centre of the screen while the player controls it via the keyboard; the in-game character and main camera will move to another position, reflecting the fact that this character is moving around the map. 
- The heart UI displays the health point or life of the in-game character, when game started player can have the max of heart is 5. If character hit the obstacle, the heart will reduce by 1 health.
- The time UI displays the time that player spend in the level, when game started it will begin the time at 00:00 and will increase by the time that player spend in the game. The time that player spend will be the final score for the game.
- The coin UI displays the coin that player has collect along the way in the level, when game started the coin will begin at 0 coin, then player need to collect the coin along the way. The coins that player collect will be the final score for the game.
- The chat dialogue displays the narration of the characters' conversations when begin the game and represent to the story of the game.

<p align="center"><img src="https://drive.google.com/uc?id=1w7uAaMIOSCoD-yU6n74e_KfuKCnqVnvK" width="500" height="350"><br /> 
<b>Figure 27:</b> Screenshot of Maze navigation level 1</p>

Along the way, players will collect items such as coins and hearts. The coins collected will be the final score for the game; when the player collects the small coin, it will increase to 1 coin, and the big coin will increase to 10 coins. When hearts are collected, they will restore the missing life, increasing by 1 per collecting heart, and the maximum life of character is five.

<p align="center"><img src="https://drive.google.com/uc?id=1QN0PPbHeOV8FEFW_SVnCbWmBafNToqvg" width="200" height="150"><br /> 
<b>Figure 28:</b> Screenshot of coins</p>

<p align="center"><img src="https://drive.google.com/uc?id=1potWOOssyGq-ak5yG3FWa7-8W4xHKRGO" width="200" height="150"><br /> 
<b>Figure 29:</b> Screenshot of heart</p>

On the level, there will be many obstacles, such as thorns and barbed wire. Players must avoid these obstacles. If players hit an obstacle, their lives will decrease by 1 unit per hit. If the player hits an obstacle until their life is 0, the game will be over immediately.

<p align="center"><img src="https://drive.google.com/uc?id=1x3LVlZRz7qDDYzB0eFm-M3FcgejMyO2Y" width="300" height="150"><br /> 
<b>Figure 30:</b> Screenshot of obstacles</p>

The goal of the game is to exit the door, but the door cannot be opened until the player has picked up the key. The player must find the key within the level to open the exit door. The key is hidden somewhere within the level, and when the player picks up the key, the door will automatically open, and the player can finish the level through of the exit the door.

<p align="center"><img src="https://drive.google.com/uc?id=1BFfDBtINJpBp46chS_mBRnVYUHsaIb3-" width="450" height="300"><br /> 
<b>Figure 31:</b> Screenshot of closed gate</p>

<p align="center"><img src="https://drive.google.com/uc?id=1R81GvOgmaHzOEBFoCWAgmw7rprS2gqn7" width="300" height="200"><br /> 
<b>Figure 32:</b> Screenshot of key</p>

<p align="center"><img src="https://drive.google.com/uc?id=1R8lzOt7FR-Utgd5VPSj-xWaxklxW1V03" width="450" height="300"><br /> 
<b>Figure 33:</b> Screenshot of opened gate after collect the key</p>

When the level ends, the score board will be displayed, including the time spent playing and the coins collected, and the player will be given the option to replay the level or move on to the next level (Level 2).

<p align="center"><img src="https://drive.google.com/uc?id=1O5k-cQg3x7zKE92zNvl9-RzAIrhbcT7u" width="450" height="300"><br /> 
<b>Figure 34:</b> Screenshot of Level complete</p>

### Level 2

In this level, the player must find the three codes throughout the map to open the exit door, similar to a puzzle in the game. There will be a keypad at the exit door for the player to enter the correct three digits code. In this level, there will be obstacles, such as spikes and enemies, that the player must avoid. If the player collides with a spike, life will decrease by 1 unit per hit. Enemies will patrol around the map. The player must avoid and hide from the enemy. If the enemy encounters the player, the enemy will chase the player. The player must run away from the enemy to avoid being hunted. If the player is caught by the enemy, the game will be over immediately.

<p align="center"><img src="https://drive.google.com/uc?id=1p5sASmg_y-BqN2q9eGOiqDZfbMHj16-f" width="450" height="300"><br /> 
<b>Figure 35:</b> Screenshot of Maze navigation level 2</p>

<p align="center"><img src="https://drive.google.com/uc?id=1VaEOl6jtncPpY4qY5dKpMbXDltLXAh-U" width="200" height="200"><br /> 
<b>Figure 36:</b> Screenshot of the hidden digit in the map</p>

<p align="center"><img src="https://drive.google.com/uc?id=1EI16RNO83blN3Wvw49G-ecXYhGQSrvMS" width="200" height="200"><br /> 
<b>Figure 37:</b> Screenshot of the keypad</p>

<p align="center"><img src="https://drive.google.com/uc?id=1RvoSfu7RFafevU2z3bWnj7IDyno9w2Fj" width="450" height="300"><br /> 
<b>Figure 38:</b> Screenshot of the keypad screen</p>

<p align="center"><img src="https://drive.google.com/uc?id=13RCaTFLKx157JZRoujilUSLO7A8o45O1" width="200" height="200"><br /> 
<b>Figure 39:</b> Screenshot of obstacles</p>

<p align="center"><img src="https://drive.google.com/uc?id=1sk8Wuj-a6gbq2jK8uiNZHNGs7tDsGTfi" width="200" height="200"><br /> 
<b>Figure 40:</b> Screenshot of the enemy</p>

In this level, there is a new special item hidden, which is energy drink. When the player plays this item, it will increase the running speed of the character in the game.

<p align="center"><img src="https://drive.google.com/uc?id=1TZ_ZnIOi6Blw6_ZL4NysfzVvGwp0ape5" width="200" height="200"><br /> 
<b>Figure 41:</b> Screenshot of the energy drink</p>

### Level 3

At this level, the player must help Malina escape from the cage by finding a way out of the two mazes to pull the lever and open the door. Along the way, the player will collect items and coins and avoid many obstacles. And use the process of thinking and memory to find a way out of the maze. The player must find a way out of the first maze to open the first lever. When reaching the first lever, the player will pull the lever to open the cage door and the second maze door. Then, the player must find a way to the second lever inside the second maze. When the player finds the second lever, the player will pull the second lever; then the exit door will open. The player must go to the exit door to finish the game.

<p align="center"><img src="https://drive.google.com/uc?id=15eIli6eJpZe_36JKFbTU6wtZfZSV8E-0" width="450" height="300"><br /> 
<b>Figure 42:</b> Screenshot of Maze navigation level 3</p>

<p align="center"><img src="https://drive.google.com/uc?id=18p_rKPTLrY3KYVpM2JZWgpvYSorL2udd" width="450" height="300"><br /> 
<b>Figure 43:</b> Screenshot of the lever</p>

### Level 4

This is the last level of the game. The player must lead Malina to escape from the maze. Malina will run after the character Oliver (the player's character). Inside the maze, the player will collect coins and items. And must avoid obstacles and enemies that patrol around the maze. At this level, the maze is divided into two parts. In the first part, the player must choose the path to go. There will be a left and a right path. Both paths will have obstacles and enemies patrolling. But there will be only one path that will have an exit to the second part. When the player finds the lever in the first part, pull the lever to go to the second part. In the second part, there will be the last enemy, which is like the last boss who captured Malina and locked her in this maze. The player must find a way to open the lever to open the exit door and go to the exit door. Players must be careful not to get caught by the enemy. When the player goes to the exit door, it will be considered the end of the game. Moreover, there will go to the next scene to show the end credits.

<p align="center"><img src="https://drive.google.com/uc?id=1FP9D6H7RENfFGCVdRArXd8eDIZooFfuK" width="450" height="300"><br /> 
<b>Figure 44:</b> Screenshot of Maze navigation level 4</p>

<p align="center"><img src="https://drive.google.com/uc?id=1mlGFAzfeiXUUPoGYf12rkE2QWGFpMnl-" width="450" height="300"><br /> 
<b>Figure 45:</b> Screenshot of end credits scene</p>

## Conclusion

The development of the Maze Navigation Game in Unity has successfully met many of the project’s key objectives. The main program we used to develop the game is Unity and we used Visual Studio to write the script in C#. The game offers multiple levels of increasing difficulty, incorporating collectables, power-ups, and a clean user interface for a polished user experience. Essential features such as smooth and responsive controls, well-designed UI, and engaging gameplay have been implemented effectively, aligning with the original aim of creating an educational yet enjoyable 3D puzzle game. Unity's physics engine and C# scripting were leveraged to simulate realistic player interactions, and the dynamic camera control enhances the overall gameplay immersion.

Comparison to Similar Games: The game compares favourably to other maze navigation games, particularly in its use of procedurally generated maze designs, which offer attractiveness and challenge. While some games focus on aesthetics or overly simplistic mazes, this project successfully strikes a balance between gameplay complexity and accessibility, targeting both beginner and advanced players. The inclusion of AI enemies and obstacles adds depth to the challenge, further distinguishing it from more basic maze games.

Unachieved Aims: A few objectives, such as the optional implementation of AI difficulty adjustment and more complex puzzle elements, have not been fully realized. While basic AI enemy behaviours and patrols are present, refining AI difficulty for more granular control remains underdeveloped due to time constraints. The puzzle elements are implemented at a basic level but could benefit from more intuitive mechanics to better challenge players. The lack of these features can be attributed to the complexity of balancing the existing mechanics and optimizing the game’s performance.

Moving forward, addressing these limitations, along with potential expansions like multiplayer mode or more sophisticated puzzle design, could greatly enhance the game’s appeal and depth. Overall, the project demonstrates significant technical and creative achievement in Unity-based game development.
