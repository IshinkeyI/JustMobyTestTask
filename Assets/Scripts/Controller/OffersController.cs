using View;
using Model;
using System.Linq;
using UnityEngine;
using View.OnSale;
using System.Collections.Generic;
using Random = UnityEngine.Random;

namespace Controller
{
    public class OffersController : AController
    {
        [SerializeField] private List<SoOnSaleOffer> offers;

        [Space] 
        [SerializeField] private bool isGetRandomOffer;

        private int _offerElementsCount;
        
        public List<SoOnSaleOffer> Offers => offers;

        public void OpenOffer(int offerElemsCount)
        {
            _offerElementsCount = offerElemsCount;
            //Some open logic
            //...

            UIManager.Instance.OpenView<OnSaleView>();
        }
        
        public SoOnSaleOffer GetOffer()
        {
            //Some get logic
            //...
            
            if (isGetRandomOffer)
                return offers[Random.Range(0, offers.Count)];
            
            return offers.FirstOrDefault(o => o.OfferItems.Count == _offerElementsCount);
        }
    }
}