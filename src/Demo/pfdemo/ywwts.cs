using Aspose.Words;
using IflySdk;
using IflySdk.Enum;
using IflySdk.Model.Common;
using NAudio.Wave;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace pfdemo
{
    public partial class ywwts : UIEditForm
    {
  
        /// <summary>
        /// 是否录音中
        /// </summary>
        private bool bLR;
        /// <summary>
        /// 是否已经有其他的按钮开始了录音
        /// </summary>
        private bool bBusy;
        private WaveInEvent wave;
        private ASRApi iat;
        public ywwts()
        {
            InitializeComponent();
 
            btnfkqc.Click += UiButton1_Click;
            btnfkzh.Click += UiButton1_Click;
            btnje.Click += UiButton1_Click;
            btnyt.Click += UiButton1_Click;

            btnfkyh.Click += UiButton1_Click;
            btnskqc.Click += UiButton1_Click;
            btnskzh.Click += UiButton1_Click;
            btnskyh.Click += UiButton1_Click;


            lblmsg.Visible = false;
            bBusy = false;
            bLR = false;
            lblmsg.ForeColor = Color.Red;
            this.ButtonOkClick += Form1_ButtonOkClick;

        }

        private void Form1_ButtonOkClick(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrEmpty(je.Text))
                    throw new Exception("金额不能为空");
                string path = System.Environment.CurrentDirectory;

                Document doc = new Document(path + @"\templete\xjzp.doc");
                string[] field = new string[] { "年", "月","日", "付款人全称"
                ,"付款人账号","付款人开户行","收款人全称","收款人账号","收款人开户行"
                ,"大写金额","用途" };
                List<object> value = new List<object>();
                NumFormat num2 = new NumFormat();
                MoneyConvertChinese mc = new MoneyConvertChinese();
                value.Add(sqrq.Value.ToString("yyyy"));
                value.Add(sqrq.Value.ToString("MM"));
                value.Add(sqrq.Value.ToString("dd"));

   
                value.Add(fkqc.Text);
                value.Add(fkzh.Text);
                value.Add(fkyh.Text);

                value.Add(skqc.Text);
                value.Add(skzh.Text);
                value.Add(skyh.Text);

                value.Add(mc.MoneyToChinese(je.Text));
                value.Add(yt.Text);

                object[] fv = value.ToArray();
                doc.MailMerge.Execute(field, fv);

                string path2 = path + @"\target\" + Guid.NewGuid().ToString("N") + "xjzp.doc";

                doc.Save(path2);

                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.UseShellExecute = true;

                proc.StartInfo.FileName = path2;
                proc.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void UiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (bBusy == false)
                {
                    Sunny.UI.UIButton bt = (Sunny.UI.UIButton)sender;
                    Sunny.UI.UITextBox txt = (Sunny.UI.UITextBox)Controls.Find(bt.Name.Substring(3), false).FirstOrDefault();
                    if (bt.Tag != null)
                    {
                        bt.Text = "语音输入";
                        lblmsg.Visible = false;
                        //关闭录音
                        wave.StopRecording();
                        bBusy = false;
                        bt.Tag = null;
                    }
                    else
                    {
                        bt.Tag = "true";
                        bBusy = true;
                        bt.Text = "停止";
                        lblmsg.Visible = true;
                        //启动录音
                        iat = new ApiBuilder()
                       .WithAppSettings(new AppSettings()
                       {
                           ApiKey = "7b845bf729c3eeb97be6de4d29e0b446",
                           ApiSecret = "50c591a9cde3b1ce14d201db9d793b01",
                           AppID = "5c56f257"
                       })
                       .WithVadEos(5000)  //将静默检测超时设置为5s
                       .UseError((sender, e) =>
                       {
                           if (e.Code == ResultCode.Disconnect)
                           {
                               lblmsg.Text = $"[{DateTime.Now.ToString()}]->开启新的识别回话。";
                           }
                           else
                           {
                               lblmsg.Text = "错误：" + e.Message;
                           }
                       })
                       .UseMessage((sender, e) =>
                       {
                           this.Invoke(new EventHandler(delegate
                           {
                               txt.Text = e;
                           }));

                       })
                       .BuildASR();


                        wave = new WaveInEvent();
                        wave.WaveFormat = new WaveFormat(16000, 1);
                        wave.BufferMilliseconds = 50;
                        wave.DataAvailable += (s, a) =>
                        {
                            byte[] buffer = SubArray(a.Buffer, 0, a.BytesRecorded);
                            iat.Convert(buffer);
                        };
                        wave.RecordingStopped += (s, a) =>
                        {
                            //iat.Stop();
                            //iat = null;
                            wave.Dispose();
                        };
                        wave.StartRecording();

                    }

                }
                else
                {
                    throw new Exception("请先结束其他的语音录入");
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



 



        private byte[] SubArray(byte[] source, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex > source.Length || length < 0)
            {
                return null;
            }
            byte[] Destination;
            if (startIndex + length <= source.Length)
            {
                Destination = new byte[length];
                Array.Copy(source, startIndex, Destination, 0, length);
            }
            else
            {
                Destination = new byte[(source.Length - startIndex)];
                Array.Copy(source, startIndex, Destination, 0, source.Length - startIndex);
            }
            return Destination;
        }

        private void ywwts_Load(object sender, EventArgs e)
        {
            sqrq.Value = DateTime.Now;
        }
    }
}
