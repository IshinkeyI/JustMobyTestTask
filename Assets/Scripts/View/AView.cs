using UnityEngine;

namespace View
{
    public abstract class AView : MonoBehaviour
    {
        public virtual GameObject ViewObject => gameObject;

        public virtual void Open()
        {
            ViewObject.SetActive(true);
        }

        public virtual void Close()
        {
            ViewObject.SetActive(false);
        }
    }
}