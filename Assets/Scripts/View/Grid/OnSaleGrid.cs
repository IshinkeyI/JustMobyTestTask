using Model;
using Controller;
using Controller.GameManager;
using View.GridElements;

namespace View.Grid
{
    public class OnSaleGrid : AGrid
    {
        private SoOnSaleOffer _activeOffer;
        private ImagesDictionaryController _imagesDictionaryController;

        public void Fill(SoOnSaleOffer offer)
        {
            _activeOffer = offer;
            Fill();
        }

        public override void Fill()
        {
            _imagesDictionaryController ??= GameManager.Controllers.Get<ImagesDictionaryController>();
            Clear();
            foreach (var item in _activeOffer.OfferItems)
            {
                var go = InstantiateElement();
                var elem = go.GetComponent<OnSaleElement>();
                elem.Image.sprite = _imagesDictionaryController.GetImage(item.ItemName);
                elem.CountText.text = $"{item.ItemCount}";
            }
        }
    }
}