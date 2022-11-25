using UnityEngine;

namespace MyNamespace
{
    ///<summery>
    ///傷害系統
    ///</summery>>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("碰到會爆炸的名稱")]
        private string nameTarget;
        [SerializeField, Header("爆炸預置物")]
        private GameObject prefabexplosion;
        [Header("受傷與爆炸音效")]
        [SerializeField]
        private AudioClip soundHit;
        [SerializeField]
        private AudioClip soundExplosion;
        //碰撞開始時執行一次
        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print(collision.gameObject.name);
            //如果 碰到物件名稱 包含 敵機 就爆炸
            if (collision.gameObject.name.Contains(nameTarget)) 
            {
                Instantiate(prefabexplosion, transform.position, transform.rotation);

                SoundManager.instance.PlaySound(soundHit, new Vector2(0.7f, 1.2f));
                SoundManager.instance.PlaySound(soundExplosion, new Vector2(1.2f, 1.5f));

                Destroy(gameObject);
            }


        }
        //碰撞離開時執行一次
        private void OnCollisionExit2D(Collision2D collision)
        {

        }
        //碰撞時持續執行
        private void OnCollisionStay2D(Collision2D collision)
        {

        }
    }
}
