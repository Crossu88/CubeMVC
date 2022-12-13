using UnityEngine;

namespace MVC
{
    public class CubeView : MonoBehaviour
    {
        public Transform visualizationTransform;
        public MeshRenderer visualizationRenderer;

        // Cached lookup for efficiency
        private static readonly int Color1 = Shader.PropertyToID("_Color");

        public void UpdateView(Vector3 dimensions, Color color)
        {
            visualizationTransform.localScale = dimensions;
            visualizationRenderer.material.SetColor(Color1, color);
        }
    }
}
