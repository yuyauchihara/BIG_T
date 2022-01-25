using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;
using UnityStandardAssets.Cameras;

public class GameManager : MonoBehaviour
{
	[System.NonSerialized]
	[SerializeField]
	GameObject GameOverCanvasPrefab;

	GameObject GameOverCanvasClone;
	FirstPersonController controller;
	FreeLookCam freeLookCam;
	Rigidbody playerRigidbody;
	Button[] buttons;

	//最初の処理
	void Start()
	{
		//シーンを切り替えてもこのゲームオブジェクトを削除しないようにする
		DontDestroyOnLoad(gameObject);

		SceneManager.sceneLoaded += OnSceneLoaded;
		//ユーザーコントロールとカメラコントロールを取得
		controller = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
		playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
		freeLookCam = GameObject.Find("FreeLookCameraRig").GetComponent<FreeLookCam>();
	}
	//シーンのロード時に実行（最初は実行されない）
	void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
		//改めて取得
		controller = GameObject.FindGameObjectWithTag("Player").GetComponent<FirstPersonController>();
		playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
		freeLookCam = GameObject.Find("FreeLookCameraRig").GetComponent<FreeLookCam>();
	}
	void Update()
	{

	}

	//ゲームオーバー処理
	public void GameOver()
	{
		//キャラやカメラの移動を停止させる
		controller.enabled = false;
		playerRigidbody.isKinematic = true;
		freeLookCam.enabled = false;

		//ゲームオーバー画面表示
		GameOverCanvasClone = Instantiate(GameOverCanvasPrefab);

		//ボタンを取得
		buttons = GameOverCanvasClone.GetComponentsInChildren<Button>();

		//ボタンにイベント設定
		buttons[0].onClick.AddListener(Retry2);

	}

	//リトライ
	public void Retry2()
	{
		Destroy(GameOverCanvasClone);

	}
	public void Retry()
    {
        Time.timeScale = 1f;//時間再稼働
        StartCoroutine(RetryScene());
    }

    IEnumerator RetryScene()
    {
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
