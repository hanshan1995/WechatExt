using System;
using System.IO;
using System.Windows.Forms;
using WeChatExtLib;

namespace WechatExt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string serviceName = "WeChatExtServer";//服务名称
        string serviceFilePath = "WeChatExtServer.exe";//服务程序

        private void button1_Click(object sender, EventArgs e)
        {
            if (LibServer.Run(new string[] { }) == false)
            {
                MessageBox.Show("运行失败，可能已有启动的服务，具体原因请查看日志");
            }
            else
            {
                MessageBox.Show("运行成功");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceManager.IsServiceRunning(serviceName))
                {
                    ServiceManager.ServiceStop(serviceName);
                    UpdateServiceStatus();
                    MessageBox.Show("停止成功");
                }
                else
                {
                    MessageBox.Show("服务未运行");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("若要停止服务请以管理员身份运行！" + ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceManager.ServiceIsExisted(serviceName))
                {
                    ServiceManager.UninstallService(serviceName, serviceFilePath);
                    UpdateServiceStatus();
                    MessageBox.Show("卸载成功");
                }
                else
                {
                    MessageBox.Show("服务未安装");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("WeChatExtServer.exe"))
                {
                    MessageBox.Show("WeChatExtServer.exe 不存在或已被计算机阻止,请在属性中解除锁定后重启");
                    return;
                }
                MessageBox.Show("若要卸载服务请以管理员身份运行！" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceManager.IsServiceRunning(serviceName))
                {
                    MessageBox.Show("服务已经在运行了");
                }
                else
                {
                    if (!ServiceManager.ServiceIsExisted(serviceName))
                    {
                        //未安装，先安装服务
                        ServiceManager.InstallService(serviceName, serviceFilePath);
                    }
                    bool allowNet = File.Exists("allowNet");
                    if (allowNet) ServiceManager.ServiceStart(serviceName, new string[] { "allowNet" });
                    else ServiceManager.ServiceStart(serviceName);
                    MessageBox.Show($"启动成功,外网访问:{(allowNet ? "是" : "否")}");
                }
                UpdateServiceStatus();
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("WeChatExtServer.exe"))
                {
                    MessageBox.Show("WeChatExtServer.exe 不存在或已被计算机阻止,请在属性中解除锁定后重启");
                    return;
                }
                MessageBox.Show("若要启动服务请以管理员身份运行！" + ex.Message);
            }
        }

        void UpdateServiceStatus()
        {
            string version = LibServer.GetVersion();
            if (ServiceManager.IsServiceRunning(serviceName))
            {
                Txt_Status.Text = $"运行中({version})";
            }
            else
            {
                Txt_Status.Text = $"已停止({version})";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (ServiceManager.ServiceIsExisted(serviceName))
                {
                    ServiceManager.ChangeServiceStartType(2, serviceName);
                    MessageBox.Show("开启启动设置成功,如需关闭可卸载服务");
                }
                else
                {
                    MessageBox.Show("服务未安装");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("若要设置开启启动请以管理员身份运行！" + ex.Message);
            }
        }
    }
}
