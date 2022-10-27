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
        [SerializeField, Header("圖片渲染元件")] 
        private SpriteRenderer spr;

        private void Update()
        {
            float v = Input.GetAxis("Vertical");

            float h = Input.GetAxis("Horizontal");

            transform.Translate(speedHorizontal * Time.deltaTime* h,
                                speedVertical * Time.deltaTime* v,
                                0);

            if(v > 0)
            {
                spr.sprite = pictureup;
            }

            if (v < 0)
            {
                spr.sprite = picturedown;
            }

            if (v == 0)
            {
                spr.sprite = picturemiddle;
            }
        }
    }
}
