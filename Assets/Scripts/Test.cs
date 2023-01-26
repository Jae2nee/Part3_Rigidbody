using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //[SerializeField]
    private Rigidbody myRigid;
    private Vector3 rotation;

    // Start is called before the first frame update
    void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            //myRigid.velocity = Vector3.forward;        // velocity 속도 ==> z축방향으로 이동   new Vector3(0, 0, 1); == Vector3.forward;

            //myRigid.angularVelocity = Vector3.right; ;     // angularVelocity 회전속도  ==> 오른쪽으로 회전 new Vector3(1, 0, 1); == Vector3.right;

            //myRigid.mass = 2f;              // 질량 변경

            //myRigid.drag = 2f;              // 저항 변경

            //myRigid.angularDrag = 2f;       // 회전 저항 변경

            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;

            //myRigid.isKinematic = true;     // 모든 물리 속성을 설정 또늦 해제
            //myRigid.useGravity = true;         // 중력 적용, 해제


            // 매서드

            // MovePosition, MoveRotation ==> 관성, 저항, 물리에 영향 받지 않고 강제로 움직임
            //myRigid.MovePosition(transform.forward * Time.deltaTime);        // 앞으로

            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));

            //AddForce ==> 관성, 저항, 물리에 영향을 받고 움직임 drag = 1이면 앞으로 전진하다 천천히 멈춤, mass = 0.1 로 줄어들면 훨씬 빠르게 움직임
            //myRigid.AddForce(Vector3.forward);

            //AddTorque는 MoveRotation의 반대 개념으로 관성, 저항, 물리에 영향을 받고 움직임 
            //myRigid.AddTorque(Vector3.up);  // up Y축 기준

            // AddExplosionForce 폭발같은 걸 구현할때 유용하게 사용
            //myRigid.AddExplosionForce(폭발력세기, 폭발의 위치, 폭발반경) , 무게와 저항등 물리에 영향을 받음  
            myRigid.AddExplosionForce(10, this.transform.right, 10);    // 왼쪽으로 날아가게끔   mass=0.5 drag = 1, AngularDrag = 1 
        }
        
    }
}
