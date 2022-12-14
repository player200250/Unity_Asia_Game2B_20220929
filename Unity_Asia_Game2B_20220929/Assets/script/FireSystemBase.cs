using UnityEngine;

namespace MyNamespace
{
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("子彈預置物")]
        private GameObject prefabBullet;
        [SerializeField, Header("子彈生成點")]
        private Transform pointSpawn;
        [SerializeField, Header("發射音效")]
        private AudioClip soundFire;

        //自訂方法
        //生成子彈
        //保存級別:允許子類別存取
        protected void SpwanBullet()
        {
            //實力化(生成角度,座標,角度)
            //生成 子彈預製物 座標與角度跟生成點相同

            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);

            SoundManager.instance.PlaySound(soundFire, new Vector2(0.7f, 1.2f));
        }
    }
}

