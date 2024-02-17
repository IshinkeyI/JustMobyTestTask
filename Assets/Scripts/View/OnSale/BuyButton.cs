using Model;
using Controller;
using UnityEngine;
using UnityEngine.UI;
using Controller.GameManager;

namespace View.OnSale
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private Text realPriceText;
        [SerializeField] private GameObject crossedOutLine;
        [SerializeField] private Text discountPriceText;
        [SerializeField] private Text percentageText;
        [SerializeField] private GameObject percentageIcon;

        public void SetPrice(SoOnSaleOffer offer)
        {
            realPriceText.text = $"{offer.RealPrice}";
            if(GameManager.Controllers.Get<DiscountController>().IsThisOfferDiscounted(offer))
            {
                discountPriceText.gameObject.SetActive(true);
                percentageIcon.SetActive(true);
                crossedOutLine.SetActive(true);
                
                discountPriceText.text = $"{offer.PriceWithDiscount}";
                percentageText.text = $"-{offer.DiscountPercentage}%";
            }
            else
            {
                crossedOutLine.SetActive(false);
                discountPriceText.gameObject.SetActive(false);
                percentageIcon.SetActive(false);
            }
        }
    }
}