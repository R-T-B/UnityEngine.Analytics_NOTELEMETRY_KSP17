using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    [AddComponentMenu("Analytics/AnalyticsTracker")]
    public class AnalyticsTracker : MonoBehaviour
    {
        private Dictionary<string, object> m_Dict = new Dictionary<string, object>();
        private int m_PrevDictHash = 0;
        [SerializeField]
        private TrackableProperty m_TrackableProperty = new TrackableProperty();
        [SerializeField]
        internal AnalyticsTracker.Trigger m_Trigger = AnalyticsTracker.Trigger.External;
        [SerializeField]
        private string m_EventName;

        public string eventName
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        internal TrackableProperty TP
        {
            get
            {
                return null;
            }
            set
            {
            }
        }

        private void Awake()
        {
            return;
        }

        private void Start()
        {
            return;
        }

        private void OnEnable()
        {
            return;
        }

        private void OnDisable()
        {
            return;
        }

        private void OnApplicationPause()
        {
            return;
        }

        private void OnDestroy()
        {
            return;
        }

        public void TriggerEvent()
        {
            return;
        }

        private void SendEvent()
        {
            return;
        }

        private void BuildParameters()
        {
            return;
        }

        [Serializable]
        internal enum Trigger
        {
            External,
            Awake,
            Start,
            OnEnable,
            OnDisable,
            OnApplicationPause,
            OnDestroy,
        }
    }
}
