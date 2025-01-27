using UnityEngine;
using UnityEngine.UI;
using ZXing;

public class HololensEasyReaderSample : MonoBehaviour {

    [SerializeField]
    private Image resultImage;
    [SerializeField]
    private Sprite loadingSprite;
    [SerializeField]
    private string lastResult = "";
    private float lastScanTime = -30f; 
    private float cooldownTime = 30f;

    private WebCamTexture camTexture;
    private Color32[] cameraColorData;
    private int width, height;

    private IBarcodeReader barcodeReader = new BarcodeReader {
        AutoRotate = false,
        Options = new ZXing.Common.DecodingOptions {
            TryHarder = false
        }
    };

    private Result result;

    private void Start() {
        SetupWebcamTexture();
        PlayWebcamTexture();
        cameraColorData = new Color32[width * height];
    }

    private void OnEnable() {
        PlayWebcamTexture();
    }

    private void OnDisable() {
        if (camTexture != null) {
            camTexture.Pause();
        }
    }

    private void Update() {
        if (Time.time - lastScanTime < cooldownTime) {
            return;  
        }
        camTexture.GetPixels32(cameraColorData); 
        result = barcodeReader.Decode(cameraColorData, width, height); 
        if (result != null) {
            lastScanTime = Time.time;   
            resultImage.sprite = loadingSprite;
            print(result.Text);
            Application.OpenURL(result.Text);
        }
    }

    private void OnDestroy() {
        camTexture.Stop();
    }

    private void SetupWebcamTexture() {
        camTexture = new WebCamTexture(1920, 1080, 30);
    }

    private void PlayWebcamTexture() {
        if (camTexture != null) {
            camTexture.Play();
            width = camTexture.width;
            height = camTexture.height;
        }
    }
}
