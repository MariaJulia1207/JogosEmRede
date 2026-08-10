using UnityEngine;
using System.Net.Sockets;
using System.Text;
using UnityEngine.InputSystem;

public class UdpClientUnity : MonoBehaviour {

    UdpClient client;

    void Start() {
        client = new UdpClient();
        client.Connect("127.0.0.1", 5000);
        Debug.Log("Cliente conectado ao servidor");
    }

    void Update() 
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame) 
        {
            string msg = "Olá do cliente Unity!";
            byte[] data = Encoding.UTF8.GetBytes(msg);
            client.Send(data, data.Length);
            Debug.Log("Mensagem enviada: " + msg);
        }
    }
}