using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPanel
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesktop_Click(object sender, EventArgs e)
        {
            Process.Start("Desk.cpl");
        }
        /// <summary>
        /// 防火墙
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFirewall_Click(object sender, EventArgs e)
        {
            Process.Start(@"wf.msc");
        }
        /// <summary>
        /// 程序和功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAppwiz_Click(object sender, EventArgs e)
        {
            Process.Start("appwiz.cpl");
        }
        /// <summary>
        /// 电源选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPowercfg_Click(object sender, EventArgs e)
        {
            Process.Start("Powercfg.cpl");
        }
        /// <summary>
        /// 鼠标设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMouse_Click(object sender, EventArgs e)
        {
            Process.Start("main.cpl");
        }
        /// <summary>
        /// 设备管理器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDevice_Click(object sender, EventArgs e)
        {
            Process.Start("hdwwiz.cpl");
        }
        /// <summary>
        /// 区域
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIntl_Click(object sender, EventArgs e)
        {
            Process.Start("intl.cpl");
        }
        /// <summary>
        /// 声音
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSound_Click(object sender, EventArgs e)
        {
            Process.Start("mmsys.cpl");
        }
        /// <summary>
        /// 系统属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemAttribute_Click(object sender, EventArgs e)
        {
            Process.Start("sysdm.cpl");
        }
        /// <summary>
        /// 日期和时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDatetime_Click(object sender, EventArgs e)
        {
            Process.Start("timedate.cpl");
        }
        /// <summary>
        /// 网络连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNet_Click(object sender, EventArgs e)
        {
            Process.Start("ncpa.cpl");
        }
        /// <summary>
        /// 磁盘清理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDiskClearn_Click(object sender, EventArgs e)
        {
            Process.Start("cleanmgr");
        }
        /// <summary>
        /// 锁定计算机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLockComputer_Click(object sender, EventArgs e)
        {
            Process.Start("rundll32", "user32.dll,LockWorkStation");
        }
        /// <summary>
        /// 计算机管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComputerManagement_Click(object sender, EventArgs e)
        {
            Process.Start("compmgmt.msc");
        }
        /// <summary>
        /// 本地组策略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroupStrategy_Click_1(object sender, EventArgs e)
        {
            Process.Start("gpedit.msc");
        }
        /// <summary>
        /// 本地安全策略
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSafety_Click(object sender, EventArgs e)
        {
            Process.Start("gpedit.msc");
        }
        /// <summary>
        /// 组件服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGroupService_Click(object sender, EventArgs e)
        {
            Process.Start("comexp.msc");
        }
        /// <summary>
        /// 显示颜色校准
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDccw_Click(object sender, EventArgs e)
        {
            Process.Start("Dccw.exe");
        }
        /// <summary>
        /// DirectX 诊断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDirectX_Click(object sender, EventArgs e)
        {
            Process.Start("dxdiag.exe");
        }
        /// <summary>
        /// 事件查看器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEventvwr_Click(object sender, EventArgs e)
        {
            Process.Start("Eventvwr.exe");
        }
        /// <summary>
        ///  Internet 属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInternetAttribute_Click(object sender, EventArgs e)
        {
            Process.Start("inetcpl.cpl");
        }
        /// <summary>
        /// 本地用户和组
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUserGroup_Click(object sender, EventArgs e)
        {
            Process.Start("lusrmgr.msc");
        }
        /// <summary>
        /// 系统信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSystemInfo_Click(object sender, EventArgs e)
        {
            Process.Start("msinfo32.exe");
        }
        /// <summary>
        /// 远程桌面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoteDesktop_Click(object sender, EventArgs e)
        {
            Process.Start("mstsc.exe");
        }
        /// <summary>
        /// 系统性能监控
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWindowsFunction_Click(object sender, EventArgs e)
        {
            Process.Start("perfmon.msc");
        }
    }
}
