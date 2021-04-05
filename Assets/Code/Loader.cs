using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System;
 
public class Loader : MonoBehaviour
{
    public string bundleUrl = "https://drive.google.com/uc?export=download&id=138VQA2LYXg7SL_zBuRK7cLcm8NDNMHiU";
    public string assetName = "demo";
     
    // Start is called before the first frame update
    IEnumerator Start()
    {

 WWW bundleWWW = WWW.LoadFromCacheOrDownload(bundleUrl, 1);
 yield return bundleWWW;
 AssetBundle assetBundle = bundleWWW.assetBundle;
  
 if (assetBundle.isStreamedSceneAssetBundle) {
     string[] scenePaths = assetBundle.GetAllScenePaths();
     string sceneName = System.IO.Path.GetFileNameWithoutExtension(scenePaths[0]);
     UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
 }
 
 
}
}