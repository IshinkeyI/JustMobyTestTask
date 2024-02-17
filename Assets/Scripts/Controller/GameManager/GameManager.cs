using View;
using UnityEngine;

namespace Controller.GameManager
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private ComponentsGroup<AController> controllers;

        public static GameManager Instance { get; set; }

        public static ComponentsGroup<AController> Controllers => Instance.controllers;

        private void Awake()
        {
            Instance = this;
            UIManager.Instance = FindObjectOfType<UIManager>();
        }

        /// <summary>Init game with entry point. Extensibility xD </summary>
        public static void InitGame()
        {
            foreach (var controller in Controllers)
            {
                controller.Init();
            }

            foreach (var controller in Controllers)
            {
                controller.StartGame();
            }
        }
    }
}