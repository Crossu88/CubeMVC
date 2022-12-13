using UnityEngine;

namespace Utils
{
    public class CameraRigController : MonoBehaviour
    {
        [Header("Settings")]
        public float rotationRate = 72.0f;

        private void Update()
        {
            transform.localRotation *= Quaternion.Euler(0, rotationRate * Time.deltaTime, 0);
        }
    }
}
