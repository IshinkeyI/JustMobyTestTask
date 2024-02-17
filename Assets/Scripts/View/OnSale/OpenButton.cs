using UnityEngine;
using UnityEngine.UI;

namespace View.OnSale
{
    public class OpenButton : MonoBehaviour
    {
        [SerializeField] private Button button;

        private void Awake()
        {
            button.onClick.AddListener(ButtonAction);
        }

        private void ButtonAction()
        {
            UIManager.UiViews.Get<InputView>().Open();
        }
    }
}