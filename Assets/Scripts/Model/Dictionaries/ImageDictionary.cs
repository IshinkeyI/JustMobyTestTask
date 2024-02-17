using System;
using RotaryHeart.Lib.SerializableDictionary;
using UnityEngine;
using UnityEngine.UI;

namespace Model.Dictionaries
{
    [Serializable]
    public class ImageDictionary : SerializableDictionaryBase<string, Sprite> { }
}