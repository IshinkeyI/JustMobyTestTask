using System;
using UnityEngine;
using Controller.GameManager;

namespace View
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance { get; set; }
        public static ComponentsGroup<AView> UiViews => Instance.uiViews;

        [SerializeField] private ComponentsGroup<AView> uiViews;

        [NonSerialized] public AView OpenedView; 

        public void OpenView<T>() where T : AView
        {
            if (OpenedView != null)
            {
                OpenedView.Close();
            }
            
            OpenedView = UiViews.Get<T>();
            OpenedView.Open();
        }
    }
}