using System;
using System.Collections.Generic;
using System.Text;

namespace ZqCSharpDesignPattern.StructuralPattern.B0101_FacadePattern
{
    class ControlCenter
    {
        private SystemTV systemTV;
        private SystemAirConditioner systemAirConditioner;
        private SystemLight systemLight;

        public ControlCenter()
        {
            systemTV = new SystemTV();
            systemAirConditioner = new SystemAirConditioner();
            systemLight = new SystemLight();
        }


        public void OnwerEnter()
        {
            systemTV.Open();
            systemLight.LightOn();
            systemAirConditioner.Open();
        }

        public void OnwerLeave()
        {
            systemTV.Close();
            systemLight.LightOff();
            systemAirConditioner.Close();
        }

    }
}
