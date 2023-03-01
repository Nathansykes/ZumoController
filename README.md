# ZumoController

[Link to repo](https://github.com/Nathansykes/ZumoController)

## Instructions for use

### For the Zumo Robot
Open the sketch "ZumoController.Arduino/ZumoController.Arduino.ino" in Arduino IDE

Add the following url to the additional boards manager: 
https://files.pololu.com/arduino/package_pololu_index.json

Open the boards manager and install Pololu A-Star Boards

Open the libraries manager and install Zumo32u4 libraries

Select the Pololu A-Star 32U4 as the board and upload the sketch


### For the UI
Clone the repo into Visual Studio (not VSCode) 

Connect the zumo robot to the host computer using Serial

Press Start or hit F5 

If the port does not connect, go to the settings tab, click refresh ports and select the correct port. Then click save. You may also need to restart the program

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

### Controlling via Serial Text only
#### Mode Selection

Enter 'm' at any time to enter mode selection - the robot will not move in this mode
Modes are as follows

- p = WASD Keys mode
- o = Controller Mode
- i = Full Auto Mode
- u = Semi Auto Mode

#### WASD Keys mode
enter a command like "w100" where the character is the direction and the number is the speed

#### Controller mode
If not using a controller you must specify both motor speeds comma separeted like "100,100"

#### Automatic mode
This mode does not need any input

#### Semi Automatic Mode
Works the same as automatic mode but when it reaches a corner, or an object it will stop and put the robot back in to mode selection
Then you can select how to control from there

## Packages, Frameworks and Technologies

The arduino source code is bundled into a single .ino file which allows you to select the mode - no need to reupload different sketches.

UI is made with **C# WinForms** in **.NET 7.0** using a mixture of **Metro UI** framework and standard windows controls.

**SharpDX** was used for controller input.

