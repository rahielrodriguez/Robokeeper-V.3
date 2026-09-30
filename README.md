# Robokeeper V.3

Automated Goalkeeper Project V.3 (Idaho State University, Robotics and Communication Systems Engineering Technology).

A web camera tracks the ball, a Python program predicts the goal zone with a Kalman filter and sends one byte over USB-UART to a PIC16F1788, which drives a stepper motor that moves the goalkeeper along a lead screw.

## Contents

| Folder | Description |
|---|---|
| `Robokeeper_V.3_Python/` | PC software. `Main Code.txt` is the final program (OpenCV color detection, Kalman filter, zone prediction, GUI); `Main.py` is an early manual-control prototype; `Color Detection Code.py` and `util.py` are a color-detection test. |
| `Robokeeper_V.3_ASM.X/` | PIC16F1788 firmware in assembly (MPLAB X project) and the compiled `.hex`. |
| `Robokeeper_V.3_Visual_Basic/` | Previous PC interface written in Visual Basic (V.2, Pixy camera). |
| `docs/` | Project report V.3. |
