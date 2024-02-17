using System;
using UnityEngine;

namespace Model
{
    [Serializable]
    public struct OfferItem
    {
        [SerializeField] private string itemName;
        [SerializeField] private int itemCount;

        public string ItemName => itemName;

        public int ItemCount => itemCount;
    }
}