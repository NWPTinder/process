using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
        catch (Exception ex)
        {
            
            //Console.WriteLine(ex.Message);
        }

        // 受信したデータがある場合、その内容を表示する
        // 再度非同期での受信を開始する
        
        if (byteSize > 0)
        {
            var ReveveMsg = (Encoding.UTF8.GetString(this.Buffer, 0, byteSize));


            Bottom root = new Bottom();
            root = (Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(ReveveMsg));

            if (root.tinderuserinfo.Count > 1)
            {
                SetRankingData(root);
            }
            else {
                if(root.tinderuserinfo[0].Signal == "SelectOneuser") { 
                SetRenewDisplyaName(ReveveMsg);
                }
            }
        }
        return;
    }

    public void SetRenewDisplyaName(string ReveveMsg)
    {        
        var Info = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(ReveveMsg);
        DisPlayName.id = Info.tinderuserinfo[0].id;
        DisPlayName.username = Info.tinderuserinfo[0].username;
        DisPlayName.age = Info.tinderuserinfo[0].age;
        DisPlayName.sex = Info.tinderuserinfo[0].sex;
        DisPlayName.whoami = Info.tinderuserinfo[0].whoami;
        DisPlayName.liked = Info.tinderuserinfo[0].liked;

    }

    public void SetRankingData(Bottom RankingData)
    {

        Ranking.username1 = RankingData.tinderuserinfo[0].username;
        Ranking.username2 = RankingData.tinderuserinfo[1].username;
        Ranking.username3 = RankingData.tinderuserinfo[2].username;
        Ranking.age1 = RankingData.tinderuserinfo[0].age;
        Ranking.age2 = RankingData.tinderuserinfo[1].age;
        Ranking.age3 = RankingData.tinderuserinfo[2].age;
        Ranking.liked1 = RankingData.tinderuserinfo[0].liked;
        Ranking.liked2 = RankingData.tinderuserinfo[1].liked;
        Ranking.liked3 = RankingData.tinderuserinfo[2].liked;

        //DisPlayName.Seter(Info.id, Info.username, Info.age, Info.sex, Info.whoami, Info.liked);
    }
}