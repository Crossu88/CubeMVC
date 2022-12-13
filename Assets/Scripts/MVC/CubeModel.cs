using UnityEngine;

namespace MVC
{
    public class CubeModel : MonoBehaviour
    {
        private Vector3 _cubeDimensions = Vector3.one;
        private Color _cubeColor = Color.white;

        public void SetWidth(float newWidth)
        {
            _cubeDimensions.x = newWidth;
        }

        public void SetLength(float newLength)
        {
            _cubeDimensions.z = newLength;
        }

        public void SetHeight(float newHeight)
        {
            _cubeDimensions.y = newHeight;
        }

        public void SetRedValue(float newRed)
        {
            _cubeColor.r = newRed;
        }

        public void SetGreenValue(float newGreen)
        {
            _cubeColor.g = newGreen;
        }

        public void SetBlueValue(float newBlue)
        {
            _cubeColor.b = newBlue;
        }

        public void SetColor(Color newColor)
        {
            _cubeColor = newColor;
        }

        public void SetDimensions(Vector3 newDimensions)
        {
            _cubeDimensions = newDimensions;
        }

        public Vector3 GetDimensions()
        {
            return _cubeDimensions;
        }

        public Color GetColor()
        {
            return _cubeColor;
        }
    }
}
