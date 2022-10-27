using UnityEngine;

namespace MyNamespace
{
    ///<summery>
    ///移動系統
    ///</summery>
    public class movesystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(-10, 0)]
        private float speed = -3.5f;

        private void Update()
        {
            transform.Translate(speed*Time.deltaTime, 0, 0);
        }
    }

}