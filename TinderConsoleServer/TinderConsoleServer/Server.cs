using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace TinderConsoleServer
{
    class Server
    {
        // スレッド待機用
        private ManualResetEvent AllDone = new ManualResetEvent(false);

        // サーバーのエンドポイント
        public IPEndPoint IPEndPoint { get; }

        // 接続中のクライアント(スレッドセーフコレクション)
        public ConcurrentQueue<Socket> ClientSockets { get; } = new ConcurrentQueue<Socket>();

        public Server(int port)
        {
            this.IPEndPoint = new IPEndPoint(IPAddress.Loopback, port);
        }

        // サーバー起動
        public void Run()
        {
            using (var listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                // Ctrl+Cが押された場合はソケットを閉じる
                Console.CancelKeyPress += (sender, args) =>
                {
                    foreach (var clientSocket in this.ClientSockets) clientSocket?.Close();
                };

                // ソケットをアドレスにバインドする
                listenerSocket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                listenerSocket.Bind(this.IPEndPoint);

                // 接続待機開始
                listenerSocket.Listen(10);
                Console.WriteLine($"サーバーを起動しました ... [{listenerSocket.LocalEndPoint}]");
                Console.WriteLine($"Ctrl + C で中止します ...");

                // 接続待機のループ
                while (true)
                {
                    AllDone.Reset();
                    listenerSocket.BeginAccept(new AsyncCallback(AcceptCallback), listenerSocket);
                    AllDone.WaitOne();
                }
            }
        }

        // 接続受付時のコールバック処理
        private void AcceptCallback(IAsyncResult asyncResult)
        {
            // 待機スレッドが進行するようにシグナルをセット
            AllDone.Set();

            // ソケットを取得
            var listenerSocket = asyncResult.AsyncState as Socket;
            var clientSocket = listenerSocket.EndAccept(asyncResult);

            // 接続中のクライアントを追加
            ClientSockets.Enqueue(clientSocket);
            Console.WriteLine($"接続: {clientSocket.RemoteEndPoint}");

            // StateObjectを作成
            var state = new StateObject();
            state.ClientSocket = clientSocket;

            // 受信時のコードバック処理を設定
            clientSocket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
        }

        private void ReceiveCallback(IAsyncResult asyncResult)
        {
            // StateObjectとクライアントソケットを取得
            var state = asyncResult.AsyncState as StateObject;
            var clientSocket = state.ClientSocket;

            int bytes;
            // クライアントソケットから受信データを取得終了
            try {
                bytes = clientSocket.EndReceive(asyncResult);
            }
            catch {
                bytes = 0;
            }


            if (bytes > 0)
            {
                // 受信した文字列を表示
                var content = Encoding.UTF8.GetString(state.Buffer, 0, bytes); // 受信した<type>Person 
                Console.WriteLine($"受信データ: {content} [{state.ClientSocket.RemoteEndPoint}]");


                // 受け取った情報に対してそれぞれに異なる返信を用意する
                string Translatedjson = JudegeSignal(content);

                // 受信文字列を接続中全クライアントに送信。
                Console.WriteLine($"送信データ: {Translatedjson} ");
                SendAllClient(Translatedjson);


                // 受信時のコードバック処理を再設定
                clientSocket.BeginReceive(state.Buffer, 0, StateObject.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
            }
            else
            {
                // 0バイトデータの受信時は、切断されたとき
                clientSocket.Close();
                this.ClientSockets.TryDequeue(out clientSocket);
            }
        }

        // クライアントへのメッセージ送信処理
        private void Send(Socket clientSocket, String data)
        {
            // 受信データをUTF8文字列に変換し送信
            try {
             
                    var bytes = Encoding.UTF8.GetBytes(data);
                    clientSocket.BeginSend(bytes, 0, bytes.Length, 0, new AsyncCallback(SendCallback), clientSocket);
               
            }catch {
                Console.WriteLine("Null Exception");
            }
            
        }

        // 送信時のコールバック処理
        private static void SendCallback(IAsyncResult asyncResult)
        {
            try
            {
                // クライアントソケットへのデータ送信処理を完了する
                var clientSocket = asyncResult.AsyncState as Socket;
                var byteSize = clientSocket.EndSend(asyncResult);
                Console.WriteLine($"送信結果: {byteSize}バイト [{clientSocket.RemoteEndPoint}]");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // 全クライアントへの送信処理
        private void SendAllClient(string data)
        {
            foreach (var clientSocket in this.ClientSockets)
            {
                Send(clientSocket, data);
            }
        }

        private string JudegeSignal(string content) 
        {
            // 初期化
            Bottom JsonToPerson = new Bottom();
            string inisialization = "{\"tinderuserinfo\":[{\"id\":\"2020/05/01\",\"username\":\"JudegeSignal\",\"age\":0,\"sex\":true,\"whoami\":\"JudegeSignal\",\"liked\":0}]}";
            JsonToPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(inisialization);
            
            // 受信情報をBottomへ変換
            JsonToPerson = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(content);

            string json = "{\"tinderuserinfo\":[{\"id\":\"2020/01/01\",\"username\":\"JudegeSignal\",\"age\":0,\"sex\":true,\"whoami\":\"JudegeSignal\",\"liked\":0}]}";


            string flag = "other";
            try
            {
                flag = JsonToPerson.tinderuserinfo[0].Signal.ToString();
            }
            catch 
            {
                Console.WriteLine("NULL");
            }
            

            //hoge.Seter(DateTime.Now, "taa",23, true, "gagag", 3);
            if (flag == "RenewDisplayname")
            {
                Bottom hoge = SQL_oparations.SELECT_user(DateTime.Now);
                hoge.tinderuserinfo[0].Signal = "SelectOneuser";
                json = JsonSerializer.Serialize(hoge);
                //content = JsonSerializer.Serialize(hoge);
            }
            else if (flag == "OneUPLike")
            {
                Bottom temp = new Bottom();
                temp = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(json);
                temp.tinderuserinfo[0].Signal = "OneUPLike";
                json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
                SQL_oparations.INSERT_THUMBS(JsonToPerson.tinderuserinfo[0].id);

            }
            else if (flag == "Ranking")
            {
                Bottom temp = new Bottom();
                
                json = SQL_oparations.SELECT_Ranking();
                temp = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(json);
                temp.tinderuserinfo[0].Signal = "Ranking";
                json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);

            }
            else if (flag == "AddUser")
            {
                Bottom temp = new Bottom();
                temp = Newtonsoft.Json.JsonConvert.DeserializeObject<Bottom>(json);
                temp.tinderuserinfo[0].Signal = "AddUser";
                json = Newtonsoft.Json.JsonConvert.SerializeObject(temp);
                SQL_oparations.INSERT_DATA(JsonToPerson);
            }
                

            return json;
        }
    }

}
