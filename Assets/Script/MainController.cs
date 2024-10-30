using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using TMPro;
using UnityEditor;
using System;

public class MainController : MonoBehaviour
{
    List<string> Main_List = new List<string>();
    List<string> Side_List = new List<string>();
    List<string> Soup_List = new List<string>();

    List<string> Main_List_Master = new List<string>();
    List<string> Side_List_Master = new List<string>();

    public TextMeshProUGUI Main_TMPro;
    public TextMeshProUGUI Side_TMPro;
    public TextMeshProUGUI Soup_TMPro;

    DateTime Date = DateTime.Now;

    // Start is called before the first frame update
    void Start()
    {
        Init();

        //if (Date.Day.ToString() == "1")
        //{
        //    Init();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        DateTime TodayNow = DateTime.Now;
    }

    public void Button()
    {
        Debug.Log("Clicked!");
        Main_TMPro.text = Main_List[UnityEngine.Random.Range(0, Main_List.Count)];
        Main_List_Master.Add(Main_TMPro.text);
        Main_List.Remove(Main_TMPro.text);
        //Debug.Log(Main_List_M[Main_List_M.Count - 1]);

        Side_TMPro.text = Side_List[UnityEngine.Random.Range(0, Side_List.Count)];
        Side_List_Master.Add(Side_TMPro.text);
        Side_List.Remove(Side_TMPro.text);

        Soup_TMPro.text = Soup_List[UnityEngine.Random.Range(0, Soup_List.Count)];
    }
    
    
    public void Init()
    {
        string[] Main = { "チャーハン", "しらす丼", "天津飯", "カレー", "親子丼", "オムライス", "三色丼",
            "オムレツ", "ドライカレー", "ドリア", "和風パスタ", "鶏の塩レモン焼き", "鶏の照り焼き", "唐揚げ",
            "ハンバーグ", "チンジャオロース", "トンテキ", "とんかつ", "豚の生姜焼き", "長芋の豚肉巻き","鱈のムニエル",
            "鯖の塩焼き", "サンマの塩焼き", "ぶり大根", "ぶりの照り焼き", "野菜炒め", "八宝菜","お好み焼き",
            "ポークビーンズ", "シチュー", "麻婆豆腐", "たこ焼き", "炊き込みご飯", "魚の塩焼き" ,};
        Main_List.AddRange(Main);

        string[] Side = { "冷奴" , "卵豆腐", "ほうれん草の胡麻和え", "ひじきの煮物", "春雨サラダ","おくらの胡麻和え", "長芋ステーキ",
            "にんじんしりしり", "ちくわの磯辺焼き", "マカロニサラダ","ポテトサラダ", "ほうれん草のおひたし", "じゃがいもガレット", "さつまいもの甘辛煮",
            "揚げ出し豆腐", "まいたけのからあげ", "こふきいも", "トマトとオクラの冷や汁", "おでん", "餃子", "ロールキャベツ",
            "だし巻き卵", "刺し身", "チーズちくわの磯辺揚げ", "塩ダレキャベツ", "にんじんのツナ胡麻和え", "もやしの卵とじ",
            "おくらのうま塩漬け", "明太ポテトサラダ", "ほうれん草の水煮" };
        Side_List.AddRange(Side);

        string[] Soup = { "豚汁","わかめスープ","味噌汁",
            "ごまスープ","カニカマスープ","中華スープ",
            "たまごスープ" };
        Soup_List.AddRange(Soup);
       
    }
}

