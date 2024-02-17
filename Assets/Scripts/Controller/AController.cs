using UnityEngine;

namespace Controller
{
    public abstract class AController : MonoBehaviour
    {
        //Some controllers logic
        public virtual void Init() { }
        
        public virtual void StartGame() { }
        public virtual void GamePause() { }
        public virtual void GameEnd() { }
    }
}