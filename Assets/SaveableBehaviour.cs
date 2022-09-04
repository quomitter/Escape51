using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO; 
using System.Linq; 
using UnityEngine.SceneManagement; 

public abstract class SaveableBehaviour : MonoBehaviour, ISaveable, ISerializationCallbackReceiver
{

    public abstract JsonData SavedData {get; }
    public abstract void LoadFromData(JsonData data);
    public string SaveID{
        get{
            return _saveID;
        }
        set{
            _saveID = value;
        }
    }
    [HideInInspector]
    [SerializeField] private string _saveID;

    public void OnBeforeSerialize(){
        if(_saveID == null){
            _saveID = System.Guid.NewGuid().ToString(); 
        }
    }
    public void OnAfterDeserialize(){

    }
}
