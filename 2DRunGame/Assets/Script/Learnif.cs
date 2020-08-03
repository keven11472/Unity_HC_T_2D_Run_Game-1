using UnityEngine;

public class Learnif : MonoBehaviour
{
    // 判斷式 if
    // 判斷 布林值 來決定要執行哪種程式
    // 範例：
    // 判斷 玩家是否死亡 顯示遊戲結束

    private void Start()
    {
        // 語法：
        // 如果(布林值) { 程式內容 }
        // 當布林值等於 true 時才會執行 {} 內容
        if (true)
        {
            print("我是判斷式 :P");
        }
    }
}
