using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;



namespace MyNamespace 
{


    /// <summary>
    /// 結束管理器
    /// </summary>
    public class FinalManager : MonoBehaviour
    {

        public static FinalManager instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI texttitle;

        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("結束畫面").GetComponent<CanvasGroup>();
            texttitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }


        /// <summary>
        /// 遊戲結束
        /// </summary>
        /// <param name="title"></param>
        public void GameOver(string title) 
        {
            texttitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// 淡入
        /// </summary>
        private IEnumerator FadeIn() 
        {
            for (int i =0; i<10;i++)
            {
                groupFinal.alpha += 0.1f;

                yield return new WaitForSeconds(0.02f);

            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;

        }

        private void Replay() 
        {
            SceneManager.LoadScene("遊戲開頭");
        }
    }
}
