using UnityEngine;



namespace MyNamespace
{
    /// <summary>
    /// ���a�����޲z:���`�ιL��
    /// </summary>

    public class PlayerFinal : MonoBehaviour
    {
        private void OnDestroy()
        {
            //���`
            FinalManager.instance.GameOver("�D�ԥ���!");

        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            //�L��
            FinalManager.instance.GameOver("�C���q�L");
        }
    }
}
    
