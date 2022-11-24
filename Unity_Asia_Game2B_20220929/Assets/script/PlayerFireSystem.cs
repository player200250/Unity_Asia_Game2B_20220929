using UnityEngine;

namespace MyNamespace
{
    public class PlayerFireSystem : FireSystemBase
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SpwanBullet();
            }
        }
    }
}
