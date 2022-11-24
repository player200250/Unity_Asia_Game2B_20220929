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
            SpwanBullet();
        }
        private void OnBecameVisible()
        {
            //延遲重複呼叫("方法名稱", 延遲時間 ,重複頻率)
            InvokeRepeating("SpwanShoot", 5, interval);
        }
        private void OnBecameInvisible()
        {
            Destroy(gameObject);
        }

    }
}
