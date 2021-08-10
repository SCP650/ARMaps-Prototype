using System;
using UnityEngine;

namespace Assets._Scripts.Tools
{
    public class CameraBackgroundFade : MonoBehaviour
    {
        public Camera Camera;
        public float FadeTimeSeconds = 1.0f;

        private Color _source;
        private Color _target;
        private DateTime _animationStartTime;
        private bool _animationEnabled;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        public void StartAnimation(Color target)
        {
            _source = Camera.backgroundColor;
            _target = target;

            _animationStartTime = DateTime.Now;

            _animationEnabled = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (_animationEnabled)
            {
                var elapsed = (DateTime.Now - _animationStartTime).Seconds / FadeTimeSeconds;

                if (elapsed > 1.0f)
                {
                    _animationEnabled = false;
                    Camera.backgroundColor = _target;
                }

                Camera.backgroundColor = Color.Lerp(_source, _target, elapsed);
            }
        }
    }
}
