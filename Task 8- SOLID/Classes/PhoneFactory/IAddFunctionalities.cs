using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneFactory
{
    interface IAddFunctionalities
    {
        void ShareFileOverBluetooth(string fileName);
        void ConnectToDeviceViaNFC(string deviceName);
    }
}
