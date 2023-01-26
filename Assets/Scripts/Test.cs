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

            //myRigid.velocity = Vector3.forward;        // velocity �ӵ� ==> z��������� �̵�   new Vector3(0, 0, 1); == Vector3.forward;

            //myRigid.angularVelocity = Vector3.right; ;     // angularVelocity ȸ���ӵ�  ==> ���������� ȸ�� new Vector3(1, 0, 1); == Vector3.right;

            //myRigid.mass = 2f;              // ���� ����

            //myRigid.drag = 2f;              // ���� ����

            //myRigid.angularDrag = 2f;       // ȸ�� ���� ����

            //myRigid.maxAngularVelocity = 100;
            //myRigid.angularVelocity = Vector3.right * 100;

            //myRigid.isKinematic = true;     // ��� ���� �Ӽ��� ���� �Ǵ� ����
            //myRigid.useGravity = true;         // �߷� ����, ����


            // �ż���

            // MovePosition, MoveRotation ==> ����, ����, ������ ���� ���� �ʰ� ������ ������
            //myRigid.MovePosition(transform.forward * Time.deltaTime);        // ������

            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myRigid.MoveRotation(Quaternion.Euler(rotation));

            //AddForce ==> ����, ����, ������ ������ �ް� ������ drag = 1�̸� ������ �����ϴ� õõ�� ����, mass = 0.1 �� �پ��� �ξ� ������ ������
            //myRigid.AddForce(Vector3.forward);

            //AddTorque�� MoveRotation�� �ݴ� �������� ����, ����, ������ ������ �ް� ������ 
            //myRigid.AddTorque(Vector3.up);  // up Y�� ����

            // AddExplosionForce ���߰��� �� �����Ҷ� �����ϰ� ���
            //myRigid.AddExplosionForce(���߷¼���, ������ ��ġ, ���߹ݰ�) , ���Կ� ���׵� ������ ������ ����  
            myRigid.AddExplosionForce(10, this.transform.right, 10);    // �������� ���ư��Բ�   mass=0.5 drag = 1, AngularDrag = 1 
        }
        
    }
}
