using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MyNamespace
{
    public class EnemyFireSystem : FireSystemBase
    {
        [SerializeField, Header("生成子彈間隔"), Range(0, 3)]
        private float interval = 1.5f;
        private void Awake()
        {
            //呼叫方法
            //SpwanBullet();

        }


        //可見事件 : 當渲染元件 (Render) 出現在 Scence 或 Game 時執行一次
        private void OnBecameVisible()
        {
            InvokeRepeating("SpwanBullet", 0, interval);
        }
        //不可見事件 : 當渲染元件 (Render) 出現在 Scence 或 Game 時執行一次
        private void OnBecameInvisible()
        {
            Destroy(gameObject);

        }
    }
}
