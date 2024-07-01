using Task_1;


namespace Lesson_2_Интерфейсы_и_обобщения
{
    class Devices
    {      
        public List<IControlable> DevicesList { get; init; }

        public Devices()
        {
            DevicesList =
            [
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
                new Device(),
            ];
        }

        public void TurnOnOff(Bits bits)
        {
            for (byte i = 0; i < 8; i++)
            {
                if (bits[i])
                {
                    if (DevicesList[i].IsOn && !bits[i])
                    {
                        DevicesList[i].Off();
                    }
                    else if (!DevicesList[i].IsOn && bits[i])
                    {
                        DevicesList[i].On();
                    }
                }
                
            }
        }

        public override string ToString()
        {
            return string.Join("", DevicesList.Select(s => s.IsOn ? "1" : "0"));
        }

    }


}
