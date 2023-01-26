import serial

ser = serial.Serial("COM8", 9600, ) #Change your port name COM... and your baudrate

def retrieveData():
    ser.write(b'1')
    data = ser.readline().decode('ascii')
    return data

while(True):
    uInput = '1'
    if uInput == '1':
        print(retrieveData())
    else:
        ser.write(b'0')








        