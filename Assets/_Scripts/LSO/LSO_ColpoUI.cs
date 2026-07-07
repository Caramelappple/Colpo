using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class LSO_ColpoUI : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
      private Button _button;
      private bool _isHolding;
      [SerializeField] private GameObject door;
      private float _colpoLimit;
      private float _colpoLimitMax;
      private float _colpoLimitMin;
      private float _current;

      private void Awake()
      {
         _button = GetComponent<Button>();
      }

      private void Start()
      {
         _colpoLimit = Random.Range(_colpoLimitMin, _colpoLimitMax+1);
      }

      void Update()
      {
         // 버튼을 누르는 동안 계속 실행할 동작
         if (_isHolding)
         {
            Debug.Log("버튼 누르는 중...");
            OnHold();
         }
      }

      // 버튼을 처음 눌렀을 때
      public void OnPointerDown(PointerEventData eventData)
      {
         _isHolding = true;
      }

      // 버튼에서 손을 떼었을 때
      public void OnPointerUp(PointerEventData eventData)
      {
         _isHolding = false;
      }  

      private void OnHold()
      {
        
            door.transform.Rotate(new Vector3(0, door.transform.rotation.y+1, 0));
         
      }
}
