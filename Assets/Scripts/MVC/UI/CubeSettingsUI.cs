using UnityEngine;
using UnityEngine.UIElements;

namespace MVC.UI
{
    public class CubeSettingsUI : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private UIDocument uiDocument;
        [SerializeField] private CubeController cubeController;

        // UI Element References
        private VisualElement _rootElement;

        private void OnEnable()
        {
            _rootElement = uiDocument.rootVisualElement;

            CreateCallbacks();
        }

        private void CreateCallbacks()
        {
            if (_rootElement == null) return;

            var widthSlider = _rootElement.Q<Slider>("WidthSlider");
            var lengthSlider = _rootElement.Q<Slider>("LengthSlider");
            var heightSlider = _rootElement.Q<Slider>("HeightSlider");

            var redSlider = _rootElement.Q<Slider>("RedSlider");
            var greenSlider = _rootElement.Q<Slider>("GreenSlider");
            var blueSlider = _rootElement.Q<Slider>("BlueSlider");

            widthSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetWidth(valueEvent.newValue)));
            lengthSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetLength(valueEvent.newValue)));
            heightSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetHeight(valueEvent.newValue)));

            redSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetRedValue(valueEvent.newValue)));
            greenSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetGreenValue(valueEvent.newValue)));
            blueSlider.RegisterValueChangedCallback((valueEvent => cubeController.SetBlueValue(valueEvent.newValue)));
        }
    }
}
