using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal interface ISportsStudent
    {
        void SayHello();
        void ShowDescription();
        void DisplayResult(int attendance, float graceMark);
    }    
    internal interface INormalStudent
    {
        void SayHello();
        void ShowDescription();

        void DisplayResult(int attendance);
    }
}
