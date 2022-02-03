# VRProject2122-jbaum

### Project description: 
This project serves as sample project for spatial audio. 
Explore sound in its basics in virtual reality (VR).

BASIC IDEA:
Escape room at the beginning there is a small sign with "Welcome to our Escape room". The environment of the Escape room consists of trees and stones covered with snow. In order to leave the maze again, 2 tasks have to be completed. We are guided through the maze acoustically, but also stylistically (by light and colour mood). The maze is basically designed with cold colours (blue, white,...). At the tasks, however, there are lanterns with warm light (orange, yellow,...) to guide us through the maze. Teleportation is used to move around.

## MVP
- You have to be able to move through the labyrinth (teleport) given by project
- 2 Games 
    - Card/letter must be picked up and placed where to open door
    - Enter a numerical code
- audio
	- Forest atmosphere (wind, birds) 
	- Technical sounds in the games (beeping, rustling)

## Milestones:
1. 25 November - working Maze build on the quest (worked).
2. 23 December - build on the quest with a minigame (put a "letter" into a mailbox worked)
3. 20 January - Build on the Quest with 2 games (both games work in the XRInteraction Toolkit - Quest I couldn't try yet, Ambience Sound worked, objects had sound but the volume needs to be adjusted better. Teleporting didn´t work in the XRInteraction Toolkit at that moment).


## Work Steps 
1. download the project and created own GitHub repository
2. make an empty build and see that it works on the quest
3. whitebox the project
4. research about the most difficult minigame (if it is possible at all)
5. programming 1st minigame
6. documentation ReadMe
7. testing if the first mini-game works
8. programming 2nd minigame
9. test the minigame on the Quest
10. documentation ReadMe
11. research audio (atmosphere and Foleys)
12. research integration audio
13. integrating audio
15. testing minigames on the Quest 
16. integrating assets
17. modelling
18. texturing
19. testing on the quest
20. delivery

### Development platform: 
OS: Windows 10, Game Engine: Unity 2020.3.18f1, Visual Studio 2019, XR Interaction Toolkit

## Software/Hardware Requirements: 
Oculus hardware requirements https://support.oculus.com/248749509016567/
You need a VR headset in this case an Oculus Rift/Quest/Quest2

When downlaoded, you have compile time errors in the project. To solve them install the XR interaction toolkit package via the Package Manager. (!Enable in Advanced Settings Preview Packages).

### Packages

- Unity UI 1.0.0
- Version Control 1.9.0
- Visual Studio Code Editor 1.2.4
- Visual Studio Editor 2.0.11
- XR Interaction Toolkit 1.0.0-pre.8
- XR Plugin Management 4.2.0
- Test Framework 1.1.29
- TextMeshPro 3.0.6

### Target platform: 
Oculus Quest/2


### Visuals: 
![image](https://user-images.githubusercontent.com/72390133/152331592-e3a99c44-26fc-4150-ad7a-a8e575620bde.png)
![image](https://user-images.githubusercontent.com/72390133/152341168-281370b2-e00b-4464-abf2-6c1b49698ff2.png)
![image](https://user-images.githubusercontent.com/72390133/152341545-ac0b4731-0be7-4cb7-b1d2-440cb0654abb.png)





### Third party material: 
For testing without a headset, use the XR Device Simulator (included in the xr interaction toolkit package):  https://www.youtube.com/watch?v=d4bTpkvBwrs

### Limitations/Problems:
- XR Device Simulator teleports into the ground with debug modus (works on Quest)
- Sounds not perfectly modified (Volume)



Copyright by jbaum
