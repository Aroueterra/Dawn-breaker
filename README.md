# Dawn-breaker

DawnBreaker is a stealth, action game built in unity3D with a Field of View and Detection+Way Point implementations

## High Concept Statement

  A freshly retired agent Virtus stumbles upon a secret conspiracy involving some of the most powerful people in the world. There he discovers that he must take up the mantle once more and work against his country, who now conspires with an enemy nation. In transit, his tracks were followed, and he was ambushed; resulting in his entire squadron being murdered. This is the story of a survivor, in his eyes a new fire of vengeance burns where righteousness once flared. His mission—to stop the delivery of this state-of-the-art armament system that will soon shake the very foundations of modern civilization. 

## PLAYER EXPERIENCE GOALS/DESIGN GOALS:

-	**Freedom of action** – The players are presented with problems that may come in the form of a puzzle or a challenge. The methods in which they solve this are up to the players and how they make use of the tools available.
-	**Subterfuge** – Sneaking by an enemy is not the only route to clearing stages; one can employ intelligence gathering through data logs that can give the player an advantage over a tough opponent. The player can also make use of their environment to create distractions. When all else fails—or if the player prefers, violence is always an option. However, it is not an easy path. Later in the game, the player will need to control two characters at exchange-ably, drastically increasing the amount of ways you can clear a stage.
-	**Strategic** – Various tools are made available to the player, such as the mini-map, weapons and inventory items to act with. The game will not rush the player, they can take all the time they need to formulate the best possible path to succeed, until they make their decision.
-	**Tension** – The combination of music, isolation and consequence of action is intended to evoke a feeling of tension in the player and caution them first to think before leaping to action, though either method of play is viable. Even as the second character is introduced, if the player acts irrationally, they will feel the effects of their mistakes as the more mistakes are made, the harder the next level becomes in the form of additional enemy spawns.

## Requirements

Windows 10 / .Net Framework 4.7.2

An Xbox / Xbox interfacing gamepad

## Gameplay

<img src='./Images/asd.png'>

Upon starting the game, the player is greeted with a menu screen with the title Dawnbreaker. Beneath are the texts Start and Exit. When they press start, a character selection screen will appear. Once the player has chosen their character, the game will start. Exit would quit the application.

## Instructions

| Controls | |
| --- | --- |
| A | Interact |
| X | Melee |
| Y | Shoot |
| B | Dodge |
| LB | Toggle Field of View |
| RB | Toggle Map |

<img src='./Images/74940238_1735155749951632_6166881723415003136_n.png'>

## Over-head Display

- The Healthbar: The player can take four hits before he is knocked out.
- The Ammo panel: Records the current amount of ammo. The capital R will appear if the player has picked up any ammo cartridges.
- The Cache panel: The goal of the game, collect all six to claim victory in the level.
- The Minimap: Displays enemies and their corresponding field of view.

<img src='./Images/Gameplay.gif'>

- Regarding the player animations, the movement is based on the player's current state, certain actions prevent other actions from firing until they have exited.
The enemies are special in that their movement is determined by their distance to the player's position on contact. The further the player is, the enemy will begin running. However, as the gap is closed and they enter within firing distance, the enemy will transition to an only-walk stance and slow down significantly; this allows the player to sneak past a corner if they are quick enough.
- The player is capable of dodging, which allows him to avoid getting damaged if timed correctly. These also allow the player a quick burst of speed.

<img src='./Images/74837469_994862267517202_2728340917806170112_n.png'>

The enemies are capable of ranged attacks if the player enters within a 10 meter radius. On triggering the alert phase, the field of view of an enemy will enlarge, increasing the amount of area the player needs to be clear of to escape the threat. The enemies have 15 shots at the player before they run out of ammunition, at which point they transition to melee attacks.

<img src='./Images/battle.png'>

3 kinds of enemy patrols. Stationary, Roaming, and Static patrol. Players must avoid contact or eliminate enemies if they please.

- Players have limited ammunition that they can take to the mission. Ammunition can be acquired throughout the game to replenish what they have.
- Players are given a health bar that depletes if they are harmed by the enemy.
- Player health is regenerated if players are out of combat for a short period of time. 
- Enemies will chase you under Alert phase and will return to their patrols on Clear phase.

<img src='./Images/gameover.png'>

When the player's health reaches zero, he is killed and must reload from the beginning of the level.

### Minimap
<img src='./Images/75233521_447700709220626_3854364429512605696_n.png'>

- Blue: Indicates story elements
- Green: Indicates data caches
- Red: Indicates visible enemies
- White: Indicates the player

These are reflected in the overview of the map below.
<img src='./Images/OverMap.png'>


<img src='./Images/75439372_727171974452129_6547258990814822400_n.png'>
