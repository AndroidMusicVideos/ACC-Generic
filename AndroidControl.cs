using System;
using System.IO.Ports;

class RobotArmControl {
    static void Main(string[] args) {
        // Set up serial port to communicate with robot
        SerialPort port = new SerialPort("COM3", 9600);
        port.Open();

        // Move robot arm to position 1
        port.Write("1");
        Console.WriteLine("Arm moved to position 1");

        // Move robot arm to position 2
        port.Write("2");
        Console.WriteLine("Arm moved to position 2");

        // Close serial port
        port.Close();
    }
}
