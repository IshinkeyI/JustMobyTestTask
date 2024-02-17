using Controller;
using UnityEngine;
using UnityEngine.UI;
using Controller.GameManager;

namespace View.OnSale
{
    public class InputView : AView
    {
        [SerializeField] private Button countPrintedButton;
        [SerializeField] private InputField inputField;

        public override void Open()
        {
            base.Open();
            inputField.onValueChanged.AddListener(OnValueChange);
            countPrintedButton.onClick.AddListener(ConfirmCount);
        }

        public override void Close()
        {
            base.Close();
            inputField.onValueChanged.RemoveAllListeners();
            countPrintedButton.onClick.RemoveAllListeners();
        }
        
        private void OnValueChange(string arg0)
        {
            if (arg0.Length == 0)
                return;
            
            if (arg0.Length >= 2)
            {
                inputField.text = arg0.Substring(arg0.Length - 1);
            }
            
            if (!char.IsDigit(arg0[0]))
            {
                inputField.text = string.Empty;
            }
            else
            {
                int arg = int.Parse(arg0[0].ToString());
                if (arg < 3 || arg > 6)
                {
                    inputField.text = string.Empty;
                }   
            }
        }
        
        private void ConfirmCount()
        {
            int inputArg = int.Parse(inputField.text);
         
            GameManager.Controllers.Get<OffersController>().OpenOffer(inputArg);
        }

    }
}
