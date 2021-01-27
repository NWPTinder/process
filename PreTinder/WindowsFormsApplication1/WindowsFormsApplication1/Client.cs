using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using WindowsFormsApplication1;
using System.Data;
using Newtonsoft.Json.Linq;

public class Client
{
    public IPEndPoint ServerIPEndPoint { get; set; }
    private Socket Socket { get; set; }
    public const int BufferSize = 1024;
    public byte[] Buffer { get; } = new byte[BufferSize];

    public string ReveveMsg { get; set; }


    public Client()
    {
        this.ServerIPEndPoint = new IPEndPoint(IPAddress.Loopback, 59072);
    }

    // ソケット通信の接続
    public void Connect()
    {
        this.Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        this.Socket.Connect(this.ServerIPEndPoint);

        // 非同期で受信を待機
        this.Socket.BeginReceive(this.Buffer, 0, BufferSize, SocketFlags.None, new AsyncCallback(ReceiveCallback), this.Socket);
    }

    // ソケット通信接続の切断
    public void DisConnect()
    {
        this.Socket?.Disconnect(false);
        this.Socket?.Dispose();
    }

    // メッセージの送信(同期処理)
    public void Send(string message)
    {
        var sendBytes = new UTF8Encoding().GetBytes(message);
        this.Socket.Send(sendBytes);
        System.Threading.Thread.Sleep(9000);
    }

    // 非同期受信のコールバックメソッド(別スレッドで実行される)
    private void ReceiveCallback(IAsyncResult asyncResult)
    {
        var socket = asyncResult.AsyncState as Socket;
        var byteSize = -1;
        try
        {
            // 受信を待機
            byteSize = this.Socket.EndReceive(asyncResult);
        }
        catch (Exception)
        { 
            //Console.WriteLine(ex.Message);
        }

        // 受信したデータがある場合、その内容を表示する
        // 再度非同期での受信を開始する
        
        if (byteSize > 0)
        {
            //Json型でデータを受け取る。
            //受け取ったデータは別の関数で処理。
            ReveveMsg = (Encoding.UTF8.GetString(this.Buffer, 0, byteSize));
        }
    }

}