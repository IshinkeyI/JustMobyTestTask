using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Controller.GameManager
{
    [Serializable]
    public class ComponentsGroup<T> : IEnumerable<T> where T : UnityEngine.Object
    {
        [SerializeReference] private List<T> componentList = new List<T>();

        public List<T> ComponentList => componentList;

        private Dictionary<Type, T> _componentDictionary;

        private bool _isInitialized;

        public T1 Get<T1>() where T1 : T
        {
            if (!_isInitialized || _componentDictionary == null)
                    Init();

            return _componentDictionary[typeof(T1)] as T1;
        }

        public T1 GetDirect<T1>() where T1 : T
        {
            return componentList.FirstOrDefault(component => component.GetType() == typeof(T1)) as T1;
        }

        public T1 GetOther<T1>() where T1 : class
        {
            return componentList.FirstOrDefault(component => component.GetType().IsSubclassOf(typeof(T1))) as T1;
        }

        public List<T1> GetMultiple<T1>() where T1 : T
        {
            return componentList.Where(component => component.GetType() == typeof(T1)).Select(component => component as T1).ToList();
        }

        public void Add<T1>(T1 component) where T1 : T
        {
            componentList.Add(component);
            
            if (_isInitialized)
                _componentDictionary.Add(typeof(T1), component);
        }

        public bool Has<T1>() where T1 : T
        {
            return _componentDictionary.ContainsKey(typeof(T1));
        }

        public void Init()
        {
            _componentDictionary = new Dictionary<Type, T>();
            foreach (var component in ComponentList)
            {
                _componentDictionary.Add(component.GetType(), component);
            }

            _isInitialized = true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)componentList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}