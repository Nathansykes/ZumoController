#include <Zumo32U4.h>
#include <string.h>

// zumo objects
Zumo32U4Motors motors;
Zumo32U4LineSensors lineSensors;
Zumo32U4ProximitySensors proxSensors;
PololuBuzzer buzzer;

// mode variables
class Mode
{
public:
    static const char ModeSelect = 'm';
    static const char SetMotors = 'p';
    static const char WASD = 'o';
    static const char SemiAuto = 'u';
    static const char Automated = 'i';
};

char SelectedMode = Mode::Automated;

// line sensor variables
int blackLineMaxValue = 1100;
int blackLineMinValue = 200;
int blackLineTargetValue = 700;

unsigned int lineSensorValues[5];
#define leftSensor lineSensorValues[0]
#define middleSensor lineSensorValues[2]
#define rightSensor lineSensorValues[4]

// prox sensor variables
bool objectFound = false;
bool identifyingObject = false;
int foundCount = 0;

void setup()
{
    Serial.begin(9600);
    lineSensors.initFiveSensors();
    proxSensors.initFrontSensor();
}

void loop()
{
    String input = GetInput();
    char oldMode = SelectedMode;
    ModeSelect(input);
    if (oldMode == SelectedMode) // if the mode has changed we skip and get user input again
    {
        RunMode(input); // some modes don't require input so we handle empty input in the method
    }
}

String GetInput()
{
    String input = "";
    delay(10); // delay to allow all the data to get to the zumo
    if (Serial.available() > 0)
    {
        input = Serial.readStringUntil('\n'); // read the next line

        Serial.print("Received Input: ");
        Serial.println(input);
    }
    return input;
}

void ModeSelect(String input)
{
    if (input.length() == 0) // no input so we don't change the mode
        return;
    char c = input.charAt(0);
    if (c == Mode::ModeSelect) // ModeSelect acts like a main menu **
    {
        SelectedMode = Mode::ModeSelect;
        motors.setSpeeds(0, 0); // stop the robot when this mode is active
        Serial.println("Selected Mode: ModeSelect");
    }

    if (SelectedMode == Mode::ModeSelect) //** mode can't be changed unless mode select is selected
    {
        switch (c) // change the mode based on the char entered
        {
        case Mode::SetMotors:
            SelectedMode = Mode::SetMotors;
            Serial.println("Selected Mode: SetMotors");
            break;
        case Mode::WASD:
            SelectedMode = Mode::WASD;
            Serial.println("Selected Mode: WASD");
            break;
        case Mode::Automated:
            SelectedMode = Mode::Automated;
            Serial.println("Selected Mode: Automated");
            break;
        case Mode::SemiAuto:
            SelectedMode = Mode::SemiAuto;
            Serial.println("Selected Mode: SemiAuto");
            break;
        }
    }
}

void RunMode(String input)
{
    if (SelectedMode != Mode::ModeSelect)
    {
        switch (SelectedMode)
        {
        case Mode::SetMotors:
            if (input.length() > 0)
            {
                SetMotorsFromSerial(input); // only needs to be hit when new input received
            }
            break;
        case Mode::WASD:
            if (input.length() > 0)
            {
                SetWASD(input); // only needs to be hit when new input received
            }
            break;
        case Mode::Automated:
        case Mode::SemiAuto:
            AutomatedMode(); // this needs to be hit continuously in a loop
            break;
        }
    }
}

void SetMotorsFromSerial(String input)
{
    // Find index of comma
    int commaIndex = input.indexOf(',');

    // Extract first number
    String num1Str = input.substring(0, commaIndex);

    int num1 = num1Str.toInt();

    // Extract second number
    String num2Str = input.substring(commaIndex + 1);

    int num2 = num2Str.toInt();
    motors.setSpeeds(num1, num2);
}

// input should be a string like "w90" or "d-120"
void SetWASD(String input)
{
    char c = input.charAt(0);               // get the first character for the direction
    int speed = input.substring(1).toInt(); // get the remainder of the string and convert to int
    const float boostMultiplier = 1.3;

    Serial.print("c: ");
    Serial.println(c);
    Serial.print("speed: ");
    Serial.println(speed);

    switch (c)
    {
    case 'w':
        motors.setSpeeds(speed, speed);
        break;
    case 's':
        motors.setSpeeds(-speed, -speed);
        break;
    case 'a':
        motors.setSpeeds(-speed, speed);
        break;
    case 'd':
        motors.setSpeeds(speed, -speed);
        break;
    case 'W':
        motors.setSpeeds(speed * boostMultiplier, speed * boostMultiplier);
        break;
    case 'S':
        motors.setSpeeds(-speed * boostMultiplier, -speed * boostMultiplier);
        break;
    case 'A':
        motors.setSpeeds(-speed * boostMultiplier, speed * boostMultiplier);
        break;
    case 'D':
        motors.setSpeeds(speed * boostMultiplier, -speed * boostMultiplier);
        break;
    case 'x':
    case 'X':
        motors.setSpeeds(0, 0);
        break;
    }
}

void AutomatedMode()
{
    lineSensors.read(lineSensorValues);
    followLines();
}

const char melody[] PROGMEM = "!L16 V15 cdefgab>cbagfedc";
int lastPersonFoundCount = 1000;
void ReadProxSensors()
{
    proxSensors.read();
    uint8_t leftValue = proxSensors.countsFrontWithLeftLeds();
    uint8_t rightValue = proxSensors.countsFrontWithRightLeds();
    // Serial.print("Left: ");
    // Serial.println(leftValue);
    // Serial.print("Right: ");
    // Serial.println(rightValue);
    if (leftValue < 4 && rightValue < 4)
    {
        return;
    }
    int total = leftValue + rightValue;

    lastPersonFoundCount++;
    if (total > 11)
    {
        if (objectFound == false)
        {
            motors.setSpeeds(0, 0);
            Serial.println("Object Found");
            objectFound = true;
        }
        else
        {
            foundCount++;
            if (foundCount > 200)
            {
                if (lastPersonFoundCount > 1000)// if we haven't seen an object in a while then it will be a new object
                {
                    Serial.println("Object Confirmed");
                    buzzer.playFromProgramSpace(melody);
                    lastPersonFoundCount = 0;
                }
                // back out and continue on route
                objectFound = false;
                foundCount = 0;
                motors.setSpeeds(-100, -100);
                delay(200);
                motors.setSpeeds(200, -200);
                delay(400);
                motors.setSpeeds(100, 100);
                delay(1000);
                return;
            }
        }
    }
    else if (leftValue == 6 && rightValue == 5)
    {
        motors.setSpeeds(0, 100);
        delay(50);
    }
    else if (rightValue == 6 && leftValue == 5)
    {
        motors.setSpeeds(100, -100);
        delay(50);
    }
    else
    {
        return;
    }
}

void printSensorValues()
{
    Serial.print("Left: ");
    Serial.println(leftSensor);
    Serial.print("Middle: ");
    Serial.println(middleSensor);
    Serial.print("Right: ");
    Serial.println(rightSensor);
    Serial.println("======================");
}

void followLines()
{
    ReadProxSensors();
    if (objectFound == true)
        return;
    delay(25);
    if (rightSensor > blackLineTargetValue || middleSensor > blackLineTargetValue)
    {
        if (SelectedMode == Mode::Automated)
        {
            motors.setSpeeds(-100, -100);
            delay(200);
            motors.setSpeeds(200, -200);
            delay(600);
        }
        else if (SelectedMode == Mode::SemiAuto)
        {
            Serial.println("Reached corner or end, handing over to manual input");
            SelectedMode = Mode::ModeSelect;
            motors.setSpeeds(0, 0);
            return;
        }
    }
    else if (leftSensor < blackLineMaxValue && leftSensor > blackLineMinValue)
    {
        motors.setSpeeds(100, 100);
    }
    else if (leftSensor > blackLineMaxValue)
    {
        motors.setSpeeds(130, -130);
    }
    else if (leftSensor < blackLineMinValue)
    {
        motors.setSpeeds(100, 100);
        delay(50);
        motors.setSpeeds(-130, 130);
        delay(50);
    }
}