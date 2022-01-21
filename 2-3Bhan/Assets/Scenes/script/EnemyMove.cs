﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//NavMeshAgent使うときに必要
using UnityEngine.AI;

//オブジェクトにNavMeshAgentコンポーネントを設置
[RequireComponent(typeof(NavMeshAgent))]

public class EnemyMove : MonoBehaviour
{

    public Transform[] points;
    [SerializeField] int destPoint = 0;
    private NavMeshAgent agent;

    Vector3 playerPos;
    GameObject player;
    float distance;
    [SerializeField] float trackingRange = 3f;
    [SerializeField] float quitRange = 5f;
    [SerializeField] bool tracking = false;

    public AudioClip sound1;
    AudioSource audioSource;
    public bool volumeUp;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // autoBraking を無効にすると、目標地点の間を継続的に移動します
        //(つまり、エージェントは目標地点に近づいても
        // 速度をおとしません)
        agent.autoBraking = false;

        GotoNextPoint();

        //追跡したいオブジェクトの名前を入れる
        player = GameObject.Find("Player");

        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0.1f;
        volumeUp = false;
    }


    void GotoNextPoint()
    {
        // 地点がなにも設定されていないときに返します
        if (points.Length == 0)
            return;

        // エージェントが現在設定された目標地点に行くように設定します
        agent.destination = points[destPoint].position;

        // 配列内の次の位置を目標地点に設定し、
        // 必要ならば出発地点にもどります
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        //Playerとこのオブジェクトの距離を測る
        playerPos = player.transform.position;
        distance = Vector3.Distance(this.transform.position, playerPos);


        if (tracking)
        {
            //追跡の時、quitRangeより距離が離れたら中止
            if (distance > quitRange)
            {
                tracking = false;

                StartCoroutine("VolumeDown");
            }

            //Playerを目標とする
            agent.destination = playerPos;
        }
        else
        {
            //PlayerがtrackingRangeより近づいたら追跡開始
            if (distance < trackingRange)
            {
                tracking = true;

                //音(sound1)を鳴らす
                audioSource.PlayOneShot(sound1);
                StartCoroutine("VolumeUp");
            }


            // エージェントが現目標地点に近づいてきたら、
            // 次の目標地点を選択します
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
                GotoNextPoint();
        }
    }

    void OnDrawGizmosSelected()
    {
        //trackingRangeの範囲を赤いワイヤーフレームで示す
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, trackingRange);

        //quitRangeの範囲を青いワイヤーフレームで示す
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, quitRange);
    }

    IEnumerator VolumeUp()
    {
        if (!volumeUp)
            while (audioSource.volume < 0.1)
            {
                audioSource.volume += 0.01f;
                yield return new WaitForSeconds(0.1f);
            }
        volumeUp = true;
    }

    IEnumerator VolumeDown()
    {
        while (audioSource.volume > 0)
        {
            audioSource.volume -= 0.01f;
            yield return new WaitForSeconds(0.1f);
            if (audioSource.volume == 0)
            {
                audioSource.Stop();
            }
        }
        volumeUp = false;
    }
}