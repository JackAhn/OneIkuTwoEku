using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using UnityEngine.SceneManagement;

public class DBControl : MonoBehaviour {

    [Header("SignupForm")]
    public InputField id;
    public InputField name;

    MySqlConnection sqlconn = null;
    private string dbip = "192.168.1.162";
    private string dbname = "taekkyon_data";
    private string dbid = "root";
    private string dbpw = "1234";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SignBtn()
    {
        sqlConnect();
    }

    private void sqlConnect()
    {
        string sqlDatabase = "Server=" + dbip + ";Database=" + dbname + ";UserId=" + dbid + ";Password=" + dbpw + "";
        try
        {
            sqlconn = new MySqlConnection(sqlDatabase);
            sqlconn.Open();
            Debug.Log("SQL 접속 상태 : " + sqlconn.State);
            MySqlCommand dbcmd = new MySqlCommand("insert into userdata values('"+id.text+"', '"+name.text+"', '0', '0', '0');", sqlconn); //명령어를 커맨드에 입력
            dbcmd.ExecuteNonQuery();
            SceneManager.LoadScene("login");
            sqlconn.Close();
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

}
