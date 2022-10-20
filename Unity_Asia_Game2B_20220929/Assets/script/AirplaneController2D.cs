using UnityEngine;
namespace MyNamespace
    ///<summery>
    ///2D飛機控制器
    ///</summery>
{
    public class AirplaneController2D : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField] private Sprite pictureup;
        [SerializeField] private Sprite picturemiddle;
        [SerializeField] private Sprite picturedown;
    }
}
