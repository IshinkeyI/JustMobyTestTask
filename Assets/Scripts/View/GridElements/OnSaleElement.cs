using UnityEngine;
using UnityEngine.UI;

namespace View.GridElements
{
    public class OnSaleElement : MonoBehaviour
    {
        [SerializeField] private Image image;
        [SerializeField] private Text countText;

        public Image Image => image;

        public Text CountText => countText;
    }
}