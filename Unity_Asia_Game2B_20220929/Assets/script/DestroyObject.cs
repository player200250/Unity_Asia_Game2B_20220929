using UnityEngine;


namespace MyNamespace
{
    /// <summary>
    /// 刪除物件
    /// </summary>
    public class DestroyObject : MonoBehaviour
    {
        [SerializeField, Header("刪除時間"), Range(0, 3)]
        private float destroytime = 0.5f;

        private void Awake()
        {
            //刪除(物體, 刪除時間)
            Destroy(gameObject, destroytime);
        }


        //可見事件 : 當渲染元件 (Render) 出現在 Scence 或 Game 時執行一次
        private void OnBecameVisible()
        {
            
        }
        //不可見事件 : 當渲染元件 (Render) 出現在 Scence 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }
    }
}
