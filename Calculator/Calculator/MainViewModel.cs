using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Windows.Input;
using System.Threading.Tasks;

namespace Calculator
{
    internal class MainViewModel
    {
        private DialogueMessage _dialogueMessage;

        public MainViewModel(DialogueMessage dialogueMessage)
        {
            _dialogueMessage = dialogueMessage;
        }

        public ICommand DisplayAlertCommand => new Command(async () => { await ShowAlert(); });

        private async Task ShowAlert()
        {
            await _dialogueMessage.DisplayAlert("Hello", "Hello There..!", "Ok");
        }
    }
}
