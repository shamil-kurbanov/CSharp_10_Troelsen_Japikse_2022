using System;
using static System.Console;

namespace OopExamples;

public class Car{
    //Car has-a radio
    public Radio myRadio = new Radio();
    public void TurnOnRadio(bool onOff){
        //Delegate call to inner object
        myRadio.Power(onOff);
        
    }
}