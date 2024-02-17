using Model;
using View.Grid;
using Controller;
using UnityEngine;
using UnityEngine.UI;
using Controller.GameManager;

namespace View.OnSale
{
    public class OnSaleView : AView
    {
        [SerializeField] private OnSaleGrid grid;
        [Space]
        [SerializeField] private Image offerMainImage;
        [SerializeField] private Text offerName;
        [SerializeField] private Text offerDescription;
        [Space]
        [SerializeField] private BuyButton buyButton;
        [SerializeField] private Button closeButton;
        

        public override void Open()
        {
            base.Open();
            closeButton.onClick.AddListener(Close);
            Fill(GameManager.Controllers.Get<OffersController>().GetOffer());
        }

        public override void Close()
        {
            base.Close();
            closeButton.onClick.RemoveAllListeners();
        }

        private void Fill(SoOnSaleOffer obj)
        {
            offerDescription.text = $"{obj.OfferDescription}";
            offerName.text = $"{obj.OfferName}";
            offerMainImage.sprite = GameManager.Controllers.
                    Get<ImagesDictionaryController>().GetImage(obj.OfferImageName);
            buyButton.SetPrice(obj);
            grid.Fill(obj);
        }
    }
}