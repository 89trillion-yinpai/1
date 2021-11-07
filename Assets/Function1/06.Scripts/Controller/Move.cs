using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;


//移动方法
namespace Assets.Function1._06.Scripts.Controller
{
    public class Move : Duqu
    {
        [SerializeField] public Text Wallet;
        //金币起点坐标
        [SerializeField] public Transform begin;
        //飞行终点坐标
        public Transform end;
        private int _i = 0;
        public Buycoin buyCoin;
        //金币预制物
        public GameObject prefab;
        //列表获取金币
        private List<GameObject> qians = new List<GameObject>();
        public void Kaishi()
        {
            _i++;
            if (_i > 3)
            {
                _i = 3;
            }
            for (int j = 0; j < _i * 5; j++)
            {
                //生成金币
                qians.Add(GameObject.Instantiate(prefab,begin));
                //金币显示
                qians[qians.Count - 1].GetComponent<Image>().enabled = true;
                //金币坐标
                qians[qians.Count - 1].transform.localPosition = Vector3.zero;
            }

            float time = 0.2f;
            Sequence k = DOTween.Sequence();
            for (int j = 0; j < _i * 5; j++)
            {
                k.Insert(0.1f * j, qians[j].transform.DOScaleX(1, 0).OnComplete(delegate
                {
                    //调用金币数增加方法
                    buyCoin.Hit_test(1);
                }));
                if (j != _i * 5 - 1)
                {
                    //每一个金币移动到指定位置
                    k.Insert(time * j, qians[j].transform.DOMove(end.position, 0.5f));
                }
                else
                {
                    //所有金币都移动完成后
                    k.Insert(time * j, qians[j].transform.DOMove(end.position, 0.5f).OnComplete(delegate
                    {
                        //购买完成后销毁生成的金币实例
                        if (qians.Count != 0)
                        {
                            for (int l = 0; l < qians.Count; l++)
                            {
                                Destroy((qians[l]));
                            }
                            //储存金币的列表清空
                            qians.Clear();
                        }
                    }));
                }
            }
            k.Play();
        }
    }
}

