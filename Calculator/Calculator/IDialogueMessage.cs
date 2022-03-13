using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface IDialogueMessage
    {
        Task DisplayAlert(string title, string message, string cancel);
    }
}
