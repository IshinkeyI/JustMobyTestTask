using Model;
using UnityEngine;

namespace Controller
{
    public class DiscountController : AController
    {
        public bool IsThisOfferDiscounted(SoOnSaleOffer offer)
        {
            // Some discount logic 
            // ...
            
            return Random.Range(0, 2) == 0;
        }
    }
}