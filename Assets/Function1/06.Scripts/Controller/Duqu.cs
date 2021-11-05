using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class Duqu : MonoBehaviour
{
    //声明存储数据的列表
    public List<Read> item;
    //num存储数据个数
    private int num;
    
    
    //初始化对象
    void Awake()
    {
        //读取json数据
        TextAsset txt = Resources.Load<TextAsset>("data") as TextAsset;
        JSONNode jsonObject = JSON.Parse(txt.text);
        //创建对象
        for (int i = 0; i < jsonObject[0].Count; i++)
        {
            Read fieldRead = new Read();
            fieldRead.type = jsonObject[0][i]["type"];
            fieldRead.num = jsonObject[0][i]["num"];
            fieldRead.subType = jsonObject[0][i]["subType"];
            fieldRead.productId = jsonObject[0][i]["productId"];
            fieldRead.costGold = jsonObject[0][i]["costGold"];
            fieldRead.costDiamond = jsonObject[0][i]["costDiamond"];
            fieldRead.isPurchased = jsonObject[0][i]["isPurchased"];
            item.Add(fieldRead);
            num = jsonObject[0].Count;
        }
        
    }

}