using Newtonsoft.Json;
using OptionProcessingService.Requests;
using System;
using System.Windows.Forms;
using OptionProcessingService.Types;
using OptionProcessingService.Responses;
using OptionProcessingService.Enums;
using System.Linq;
using System.Collections.Generic;

namespace TestWebSocketClient
{
    public partial class MainForm : Form, IDisposable
    {
        #region Private Fields
        //private DataFeed[] _DataFeeds;
        private WebSocket4Net.WebSocket _socket;
        private IList<Asset> assets;
        delegate void NewAssetMsgHandler(IList<Asset> assets);
        delegate void AccountMsgHandler(Account assets);
        #endregion
        void AssetsRecieved(IList<Asset> assets)
        {
            this.assets = assets;
            
            var list1 = new List<Symbol>();
            foreach (var item in assets)
            {
                list1.Add(item.Symbol);
            }

            //comboBox1.DataSource = list;
            cmbSymbol.DataSource = list1;
            cmbSymbol.DisplayMember = "Name";
            cmbSymbol.ValueMember = "Name";
        }
        public List<Account> AccountList;// = new List<Account>();
        void AccountDataRecieved(Account account)
        {
            AccountList = new List<Account>();
            AccountList.Add(account);
            cmbAccount.DataSource = AccountList;
            cmbAccount.DisplayMember = "ID";
            cmbAccount.ValueMember = "ID";
        }
        #region Constructors
        public MainForm()
        {
            InitializeComponent();
            cmbHPeriodicity.Items.AddRange(new string[] { "Minutely", "Hourly", "Daily", "Weekly" });
            cmbHPeriodicity.SelectedIndex = 0;
            EnabledControls(false);
        }
        #endregion

        #region Event Handlers
        private void btnLogin_Click(object sender, EventArgs e)
        {
            InitWebSocket();
        }
       
        private void _socket_MessageReceived(object sender, WebSocket4Net.MessageReceivedEventArgs e)
        {
            var msgTypeName = GetMessageTypeName(e.Message);

            // deserialize
            switch (msgTypeName)
            {
                case "LoginResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var loginRespinse = JsonConvert.DeserializeObject<LoginResponse>(e.Message);
                    if (string.IsNullOrEmpty(loginRespinse.Error))
                    {
                        
                        AppendToLog("Connected");
                        
                    }
                    else
                        AppendToLog(loginRespinse.Error);
                    break;
                //case "Execution":
                case "OrderPlaceResponse":
                    var ordRes = JsonConvert.DeserializeObject<OrderPlaceResponse>(e.Message);
                    if (ordRes.Expiry != null)
                    {
                        AppendToLog(ordRes.Expiry.ToString());
                        AppendToLog(((DateTime)ordRes.Expiry).ToUniversalTime().ToString());
                    }
                    if (String.IsNullOrEmpty(ordRes.Error))
                        AppendToLog(ordRes.SrvOrdID);
                    else
                        AppendToLog(ordRes.Error);
                    break;
                case "OrderExecutionResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var execution = JsonConvert.DeserializeObject<OrderExecutionResponse>(e.Message);
                    if (execution.Status==OrderState.Executed)
                        AppendToLog(execution.OrderID + execution.Status+ execution.MsgType);
                    else
                        AppendToLog(execution.Status.ToString()+"Message = " + execution.Message);
                    break;
                    
                case "AssetsGetResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var assets = JsonConvert.DeserializeObject<AssetsGetResponse>(e.Message);
                    if (assets.Assets.Count > 0)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new NewAssetMsgHandler(AssetsRecieved), assets.Assets );
   
                        }
                        

                        AppendToLog(assets.Assets.Count.ToString());
                    }
                    else
                        AppendToLog("0");
                    break;
                case "AccountInfoGetResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var acount = JsonConvert.DeserializeObject<AccountInfoGetResponse>(e.Message);
                    if (acount.AccountData!=null)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new AccountMsgHandler(AccountDataRecieved), acount.AccountData);

                        }


                        AppendToLog("Account ID : " +acount.AccountData.ID.ToString() +" Balance: "+ acount.AccountData.Balance.ToString());
                    }
                    
                    break;

                case "OpenOrdersSubscribeResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var openOrder = JsonConvert.DeserializeObject<OpenOrdersSubscribeResponse>(e.Message);
                    //if (acount.AccountData != null)
                    //{
                    //    if (this.InvokeRequired)
                    //    {
                    //        this.Invoke(new AccountMsgHandler(AccountDataRecieved), acount.AccountData);

                    //    }


                    //    AppendToLog("Account ID : " + acount.AccountData.ID.ToString() + " Balance: " + acount.AccountData.Balance.ToString());
                    //}
                    break;
                case "AccountInfoSubscribeResponse":
                    // send DataFeedListRequest
                    //Send(new DataFeedListRequest());
                    var account = JsonConvert.DeserializeObject<AccountInfoSubscribeResponse>(e.Message);
                    if (account.AccountData != null)
                    {
                        if (this.InvokeRequired)
                        {
                            this.Invoke(new AccountMsgHandler(AccountDataRecieved), account.AccountData);

                        }
                        AppendToLog("Account ID : " + account.AccountData.ID.ToString() + " Balance: " + account.AccountData.Balance.ToString());
                    }
                    break;

                //case "DataFeedListResponse":
                //    ProcessDataFeedListResponse(DeserializeResponse<DataFeedListResponse>(e.Message));
                //    break;

                ////case "NewTickResponse":
                ////    ProcessNewTickResponse(DeserializeResponse<NewTickResponse>(e.Message));
                ////    break;

                //case "HistoryResponse":
                //    ProcessHistoryResponse(DeserializeResponse<HistoryResponse>(e.Message));
                //    break;
                case "ErrorResponse":
                    var errorRes= JsonConvert.DeserializeObject<ErrorResponse>(e.Message);
                    AppendToLog(errorRes.Error);
                    break;
            }
        }

        private void _socket_Error(object sender, SuperSocket.ClientEngine.ErrorEventArgs e)
        {
            AppendToLog("Error: " + e.Exception.Message);
        }

        private void _socket_Closed(object sender, EventArgs e)
        {
            AppendToLog("Socket has been Closed!");
        }

        private void _socket_Opened(object sender, EventArgs e)
        {
            // we successfully conected
            // send LoginRequest to server
            Send(new LoginRequest() { Login = txtLogin.Text, Password = txtPassword.Text});

            
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            // send SubscribeRequest
            //Send(new SubscribeRequest(new SymbolItem() { DataFeed = cmbL1DataFeeds.Text, Symbol = txtL1Symbol.Text, Type = Instrument.Equity }));
        }

        private void btnUnsubscribe_Click(object sender, EventArgs e)
        {
            // send UnsubscribeRequest
            //Send(new UnsubscribeRequest(new SymbolItem() { DataFeed = cmbL1DataFeeds.Text, Symbol = txtL1Symbol.Text, Type = Instrument.Equity }));
        }

        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            //int interval = 1;
            //Periodicity period = Periodicity.Minute;
            //switch (cmbHPeriodicity.SelectedIndex)
            //{
            //    case 0://minute
            //        //use default
            //        break;
            //    case 1:
            //        interval = 60;
            //        break;
            //    case 2:
            //        period = Periodicity.Day;
            //        break;
            //    case 3:
            //        interval = 7;
            //        period = Periodicity.Day;
            //        break;
            //    default:
            //        System.Diagnostics.Debug.Assert(false);
            //        break;
            //}

            ////send HistoryRequest
            //Send(new HistoryRequest(new HistoryParameters()
            //{
            //    Symbol = new SymbolItem() { DataFeed = cmbL1DataFeeds.Text, Symbol = txtL1Symbol.Text, Type = Instrument.Equity },
            //    Id = Guid.NewGuid().ToString(),
            //    Periodicity = period,
            //    Interval = interval,
            //    BarsCount = (int)numHBarCount.Value
            //}));
        }
        #endregion

        #region Private members
        private void InitWebSocket()
        {
            try
            {
                var uri = string.Format("ws://{0}:{1}/DataServer_Service", txtHost.Text, numPort.Value);
                _socket = new WebSocket4Net.WebSocket(uri);
                _socket.Opened += _socket_Opened;
                _socket.Closed += _socket_Closed;
                _socket.Error += _socket_Error;
                _socket.MessageReceived += _socket_MessageReceived;

                AppendToLog("Connecting...");
                _socket.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //private void ProcessHistoryResponse(HistoryResponse histMessage)
        //{
        //    AppendToLog("History Message");
        //    foreach (var bar in histMessage.Bars)
        //    {
        //        AppendToLog(string.Format("{0} O:{1} H:{2} L:{3} C:{4} V:{5}", bar.Date.ToString(), bar.Open, bar.High, bar.Low, bar.Close, bar.Volume));
        //    }
        //}

        //private void ProcessNewTickResponse(NewTickResponse tickMessage)
        //{
        //    foreach (var tick in tickMessage.Tick)
        //    {
        //        AppendToLog(string.Format("{0}:{1} - Price:{2}  Volume:{3}", tick.Symbol.DataFeed, tick.Symbol.Symbol, tick.Price, tick.Volume));
        //    }
        //}

        //private void ProcessDataFeedListResponse(DataFeedListResponse response)
        //{
        //    _DataFeeds = response.DataFeeds.ToArray();

        //    InvokeIfRequired(cmbL1DataFeeds, InitDataFeedControl);

        //    EnabledControls(true);
        //}

        /// <summary>
        /// Send provided Request to Server through socket
        /// </summary>
        /// <param name="request"></param>
        private void Send(OptionProcessingService.Types.Message request)
        {
            var serializedMsg = SerializeRequest(request);
            _socket.Send(serializedMsg);
        }

        private void AppendToLog(string msg)
        {
            var action = new Action(() =>
            {
                txtLog.AppendText(msg + Environment.NewLine);
                ScrollToEnd();
            });

            InvokeIfRequired(txtLog, action);
        }

        private void ScrollToEnd()
        {
            txtLog.SelectionStart = txtLog.TextLength;
            txtLog.ScrollToCaret();
        }

        private void EnabledControls(bool logined)
        {
            var action = new Action(() =>
            {
                pnlLogin.Enabled = !logined;
                gbLevel1.Enabled = gbHistory.Enabled = logined;
            });

            InvokeIfRequired(pnlLogin, action);
        }

        private void InvokeIfRequired(Control ctl, Action action)
        {
            if (ctl.InvokeRequired)
            {
                ctl.Invoke(action);
            }
            else
            {
                action();
            }
        }

        private void InitDataFeedControl()
        {
            //cmbL1DataFeeds.Items.Clear();
            //cmbHDataFeeds.Items.Clear();
            //foreach (var feed in _DataFeeds)
            //{
            //    cmbL1DataFeeds.Items.Add(feed.Name);
            //    cmbHDataFeeds.Items.Add(feed.Name);
            //}
            //if (_DataFeeds.Length > 0)
            //{
            //    cmbL1DataFeeds.SelectedIndex = 0;
            //    cmbHDataFeeds.SelectedIndex = 0;
            //}
        } 
        #endregion

        #region Dispose

        public void Dispose()
        {

        }

        #endregion

        #region Serialization 
        private string SerializeRequest(OptionProcessingService.Types.Message request)
        {
            return JsonConvert.SerializeObject(request);
        }

        private T DeserializeResponse<T>(string rsp) where T : class 
        {
            return JsonConvert.DeserializeObject<T>(rsp);
        }

        private string GetMessageTypeName(string message)
        {
            var msgObj = JsonConvert.DeserializeObject<OptionProcessingService.Types.Message>(message);

            return msgObj.MsgType;
        }
        #endregion
        
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            try
            {
                OptionType optType;
                Enum.TryParse<OptionType>(cmbOptionType.SelectedValue.ToString(), out optType);
                OrderType ordType;
                Enum.TryParse<OrderType>(cmbOrderType.SelectedValue.ToString(), out ordType);
                Symbol option = cmbSymbol.SelectedItem as Symbol;

                ExpiryTime expTime = cmbExpiry.SelectedItem as ExpiryTime;

                var orderRequest = new OrderPlaceRequest();
                orderRequest.Investment = Convert.ToInt32(txtAmount.Text);

                orderRequest.Symbol = option;
                orderRequest.OptionID = assets.Where(x => x.Symbol.Name == option.Name).FirstOrDefault<Asset>().ID;
                orderRequest.OptionType = optType;
                orderRequest.OrderType = ordType;
                long timestamp = expTime.ExpiryTimestamps;

                if (optType == OptionType.Express)
                {
                    orderRequest.OptionType = OptionType.Express;
                    short expirationTerm = 0;
                    Int16.TryParse(cmbShortTermExpiry.SelectedItem.ToString(), out expirationTerm);
                    orderRequest.ExpressExpiryInSeconds = expirationTerm;
                }
                else
                {
                    orderRequest.ExpiryTimestamp = timestamp;
                    AppendToLog(TimestampToDateTime(orderRequest.ExpiryTimestamp).ToString());
                    AppendToLog(TimestampToDateTime(orderRequest.ExpiryTimestamp).ToUniversalTime().ToString());
                }
                orderRequest.CurrentMarketPrice = Convert.ToDouble(txtCurPrice.Text);
                //AppendToLog(TimestampToDateTime(orderRequest.ExpiryTimestamp).ToString());
                //AppendToLog(TimestampToDateTime(orderRequest.ExpiryTimestamp).ToUniversalTime().ToString());
                //AppendToLog(GetCurrentTimestamp().ToString());
                //AppendToLog(GetCurrentDateTime(GetCurrentTimestamp()).ToString());
                Send(orderRequest);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        private static readonly DateTime UnixTime = new DateTime(1970, 1, 1);
        private static readonly DateTime Epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        private static long DateTimeToTimestamp(DateTime value)
        {
            TimeSpan elapsedTime = value.ToUniversalTime() - Epoch;
            return (long)elapsedTime.TotalMilliseconds;
        }

        private static DateTime TimestampToDateTime(double value)
        {
            var epochLocal= new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            var x = epochLocal.AddMilliseconds(value).ToLocalTime();
            return x;
        }
        public static long GetCurrentTimestamp()
        {
            return (long)(DateTime.UtcNow - UnixTime).TotalMilliseconds;
        }
        private static DateTime GetCurrentDateTime(double value)
        {
            var unixTime = new DateTime(1970, 1, 1);
            var x = unixTime.AddMilliseconds(value).ToLocalTime();
            return x;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSymbol.SelectedItem != null && !string.IsNullOrEmpty((cmbSymbol.SelectedItem as Symbol).Name))
            {
                cmbExpiry.DataSource = assets.Where(x => x.Symbol.Name == (cmbSymbol.SelectedItem as Symbol).Name).FirstOrDefault<Asset>().ExpiryTimeList;
                cmbExpiry.DisplayMember = "ExpiryDatetime";
                cmbExpiry.ValueMember = "ExpiryTimestamps";

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbOptionType.DataSource = Enum.GetValues(typeof(OptionType));
            cmbOrderType.DataSource = Enum.GetValues(typeof(OrderType));
        }

        private void btnAssets_Click(object sender, EventArgs e)
        {
            var assetRequest = new AssetsGetRequest();
            assetRequest.OptionType = OptionType.Classic;
            assetRequest.ReqID = new Guid().ToString();
            Send(assetRequest);
            var accountRequest = new AccountInfoGetRequest();
            accountRequest.ReqID = new Guid().ToString();
            Send(accountRequest);
            var accountInfoSub = new AccountInfoSubscribeRequest();
            //accountInfoSub. = new Guid().ToString();
            Send(accountInfoSub);
            var openOpderSub = new OpenOrdersSubscribeRequest();
            Send(openOpderSub);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
