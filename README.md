# ZumoController

[Link to repo](https://github.com/Nathansykes/ZumoController)

## Instructions for use

### For the Zumo Robot
Open the sketch "ZumoController.Arduino/ZumoController.Arduino.ino" in Arduino IDE

Add the following url to the additional boards manager: 
https://files.pololu.com/arduino/package_pololu_index.json

Open the boards manager and install Pololu A-Star Boards

Select the Pololu A-Star 32U4 as the board and upload the sketch

Open the libraries manager aand install Zumo32u4 libraries

### For the UI
Clone the repo into Visual Studio (not VSCode) 

Connect the zumo robot to the host computer using Serial

Press Start or hit F5 

If the port does not connect, go to the settings tab, click refresh ports and select the correct port. Then click save.

Now click "ReOpen Port"

#### Using the controller
> This has only been tested with an Xbox One Controller plugged in via USB

Connect the controller to the computer, before starting the program.

Once launched head to the xbox tab and click to enable the controller, it should now listen for input and send it to the robot.

#### Using the WASD keys

Head to the Key Control tab, click enable keys, this will trigger the application to start listing to keystrokes.

Move the slider to adjust the speed. Controls are as follows:
- w = forward
- s = reverse
- a = turn left
- s = turn right
- x = stop

use SHIFT to apply a speed boost

## Packages, Frameworks and Technologies

The arduino source code is bundled into a single .ino file which allows you to select the mode - no need to reupload different sketches.

UI is made with **C# WinForms** using a mixture of **Metro UI** framework and standard windows controls.

**SharpDX** was used for controller input.

