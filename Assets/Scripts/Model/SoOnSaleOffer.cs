using UnityEngine;
using System.Collections.Generic;

namespace Model
{
    [CreateAssetMenu(fileName = "OnSaleOffer", menuName = "Offers/OnSaleOffer", order = 0)]
    public class SoOnSaleOffer : ScriptableObject
    {
        [SerializeField] private string offerName;
        [SerializeField] private string offerDescription;
        [SerializeField] private string offerImageName;
        [SerializeField] private List<OfferItem> offerItems;
        [SerializeField] private float realPrice;
        [SerializeField] private float priceWithDiscount;

        public string OfferName => offerName;

        public string OfferDescription => offerDescription;

        public string OfferImageName => offerImageName;

        public List<OfferItem> OfferItems => offerItems;

        public float RealPrice => realPrice;

        public float PriceWithDiscount => priceWithDiscount;

        public int DiscountPercentage => (int)(100 - (priceWithDiscount * 100 / realPrice));
    }
}
