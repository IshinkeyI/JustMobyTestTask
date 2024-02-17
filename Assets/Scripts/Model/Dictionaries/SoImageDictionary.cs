using UnityEngine;

namespace Model.Dictionaries
{
    [CreateAssetMenu(fileName = "ImagesDictionary", menuName = "Dictionary/Image", order = 0)]
    public class SoImageDictionary : ScriptableObject
    {
        [SerializeField] private ImageDictionary images;

        public ImageDictionary Images => images;
    }
}