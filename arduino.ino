#include <SoftwareSerial.h>

SoftwareSerial bluetoothSerial(2, 3);  // RX, TX

void setup() {
  pinMode(13, OUTPUT);  // Set 13th pin as output
  bluetoothSerial.begin(9600);  // Start serial communication with Bluetooth module
}

void loop() {
  if (bluetoothSerial.available() > 0) {  // Check if there's data available from Bluetooth module
    int value = bluetoothSerial.read();  // Read the value received
    if (value == '0') {
      digitalWrite(13, LOW);  // Set 13th pin LOW if value received is '0'
    } else {
      digitalWrite(13, HIGH);  // Set 13th pin HIGH for any other value received
    }
  }
}
