 Project Documentation – VR Office Tour
1. Introduction
This project is a 360° Virtual Reality Tour designed to provide an immersive walkthrough experience of different rooms. The application is built in Unity with VR support and deployed to VR headsets.
The goal is to simulate real-world navigation between rooms with smooth transitions, interactive buttons, and a professional user experience.

2. Features
Welcome Screen: A start button that launches the main tour.


360° Room Views: Users can look around freely in each room.


Interactive Navigation: Buttons allow moving from one room to the next.


Fade Transition: A smooth black fade effect is triggered before entering the next room (to avoid sudden jumps).


VR Compatibility: Built and tested on VR headsets.



3. Technical Details
Development Environment
Engine: Unity (version 2021)


Language: C# scripts


Version Control: GitHub


Architecture
Each room is represented by a 360 sphere with the panoramic texture applied inside.


Navigation is controlled by UI buttons that trigger room change scripts.


A fade system was added to handle smooth scene transitions.


Canvas overlays are used for the welcome menu and fade effect.


Core Scripts
ButtonTransition.cs


Handles moving from one room to another.


Uses fade-out → switch room → fade-in sequence.


ScreenFader.cs


Controls the black overlay that fades in/out.


Provides FadeIn() and FadeOut() coroutines.


RoomManager.cs


Keeps track of current room and manages navigation.



4. Challenges & Solutions
Problem: Initial room change was instant (no fade).


Solution: Implemented ScreenFader to overlay black image during transition.


Problem: Push to GitHub failed due to large files.


Solution: Added .gitignore to exclude build files and restructured repo.


Problem: Navigation worked in Unity Editor but not in VR build.


Solution: Debugged controller input mapping and ensured button event listeners were correctly wired for VR.



5. Team Contributions
Ange Gitego Rugema


Set up GitHub repositories and managed version control.


Built the fade transition system and integrated it with navigation.


Ensured final VR headset build worked as expected.
Implemented the MainScene


Oluwatidemilade Aremu Olorunsola
Created the .gitignore and cleaned repository structure.


Implemented part of the navigation logic (room switching with button input).


Worked on environment setup and panoramic textures.
Implemented the Welcome and OutroScenes.



6. Conclusion
The VR Tour application successfully allows users to explore a series of rooms in an immersive environment. The collaboration between team members ensured proper functionality, version control, and smooth VR experience.
Future improvements could include:
Adding audio narration for each room.


Including 3D interactable objects inside the rooms.


Expanding to multi-room branching navigation instead of linear flow.




