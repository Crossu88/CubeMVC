using UnityEngine;

namespace MVC
{
    public class CubeController : MonoBehaviour
    {
        [SerializeField] private CubeModel cubeModel;
        [SerializeField] private CubeView cubeView;

        public void SetWidth(float newWidth)
        {
            cubeModel.SetWidth(newWidth);
            UpdateView();
        }

        public void SetLength(float newLength)
        {
            cubeModel.SetLength(newLength);
            UpdateView();
        }

        public void SetHeight(float newHeight)
        {
            cubeModel.SetHeight(newHeight);
            UpdateView();
        }

        public void SetDimensions(Vector3 newDimensions)
        {
            cubeModel.SetDimensions(newDimensions);
            UpdateView();
        }

        public void SetRedValue(float newRed)
        {
            cubeModel.SetRedValue(newRed);
            UpdateView();
        }

        public void SetGreenValue(float newGreen)
        {
            cubeModel.SetGreenValue(newGreen);
            UpdateView();
        }

        public void SetBlueValue(float newBlue)
        {
            cubeModel.SetBlueValue(newBlue);
            UpdateView();
        }

        public void SetColor(Color newColor)
        {
            cubeModel.SetColor(newColor);
            UpdateView();
        }

        public Vector3 GetDimensions()
        {
            return cubeModel.GetDimensions();
        }

        public Color GetColor()
        {
            return cubeModel.GetColor();
        }

        public void UpdateView()
        {
            cubeView.UpdateView(GetDimensions(), GetColor());
        }
    }
}
