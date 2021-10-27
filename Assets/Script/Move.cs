using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using NUnit.Framework.Constraints;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Transform First;
    public Transform end;
    public int i = 0;
    public Buycoin buyCoin;
    public GameObject prefab;
    public List<GameObject> qians = new List<GameObject>();
    public void Kaishi()
    {
        i++;
        if (i > 3) i = 3;
        for (int j = 0; j < i * 5; j++)
        {
            qians.Add(GameObject.Instantiate(prefab,First));
            qians[qians.Count - 1].GetComponent<Image>().enabled = true;
            qians[qians.Count - 1].transform.localPosition = Vector3.zero;
        }

        float time = 0.2f;
        Sequence k = DOTween.Sequence();
        for (int j = 0; j < i * 5; j++)
        {
            if (j != i * 5 - 1)
            {
                k.Insert(time * j, qians[j].transform.DOMove(end.position, 0.5f));
            }
            else
            {
                k.Insert(time * j, qians[j].transform.DOMove(end.position, 0.5f)).OnComplete(delegate
                {
                    if (qians.Count != 0)
                    {
                        buyCoin.Hit_test(qians.Count);
                        
                        for (int l = 0; l < qians.Count; l++)
                        {
                            Destroy((qians[l]));
                        }

                        qians.Clear();
                    }
                });
            }
        }

        k.Play();
        //canmove = true;

    }
}

