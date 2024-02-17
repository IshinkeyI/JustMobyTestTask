using UnityEngine;
using Model.Dictionaries;

namespace Controller
{
    public class ImagesDictionaryController : AController
    {
        [SerializeField] private SoImageDictionary imageDictionary;

        public Sprite GetImage(string imageKey)
        {
            imageDictionary.Images.TryGetValue(imageKey, out var result);
            if (result == null)
                Debug.LogError($"Image with {imageKey} not set!");
            
            return result;
        }
    }
}