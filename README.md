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
