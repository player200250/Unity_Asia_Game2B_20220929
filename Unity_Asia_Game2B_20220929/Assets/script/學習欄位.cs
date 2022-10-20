
using UnityEngine;

namespace MyNamespace
{
    ///<summery>
    ///學習欄位 Field
    ///</summery>>
    public class 學習欄位 : MonoBehaviour
    {
        //欄位Field : 儲存資料
        //語法:
        //修飾詞 資料名稱 欄位名稱;

        //定義一筆資料，名稱是level，類型是整數
        //私人:private，僅在此類別內能夠存取，不顯示

        private int lv;

        // = ，等於 指定符號 : 將等號右邊的結果指定給左邊，顯示
        //整數 int 
        public int enemy = 5;

        //浮點數 float
        public float speed = 10.5f;
        public float jump = 4.5F;

        //字串 string
        public string nameplayer = "小騎士";

        //布林值 bool
        public bool save = true;
        public bool load = false;
        public bool isPass = false;
        public bool hasweapon = true;

        //標題
        [Header("血量")]
        public int hp = 999;

        //提示
        [Tooltip("顯示角色生命值")]
        public float count = 10.5f;

        //範圍
        //數值專用範圍(最小值，最大值)
        [Range(1, 999)]
        public int level = 100;
        [Range(2f, 10.5f)]
        public float walkspeed = 3.5f;
        //不支援 int 與 float 以外的資料模型

        //序列化欄位: 顯示私人欄位
        [SerializeField]
        private int life = 7;

        //總和使用例子
        [Header("數字")]
        [Range(0, 100)]
        [SerializeField]
        private int number = 77;

        [SerializeField, Header("是否開門")]
        private bool isOpen = false;
    }

}
