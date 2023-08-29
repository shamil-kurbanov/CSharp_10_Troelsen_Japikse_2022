using System;
using static System.Console;

namespace OopExamples

public class Car{
    //Car has-a radio
    private Radio myRadio = new Radio();
    public void TurnOnRadion(bool onOff){
        //Delegate call to inner object
        myRadio.Power(onOff);
    }
}