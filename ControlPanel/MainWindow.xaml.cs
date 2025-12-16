using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;

namespace ControlPanel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 安全地启动进程
        /// </summary>
        /// <param name="fileName">文件名或可执行文件路径</param>
        /// <param name="arguments">命令行参数（可选）</param>
        private void StartProcess(string fileName, string? arguments = null)
        {
            try
            {
                var startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    UseShellExecute = true,
                    ErrorDialog = false
                };

                if (!string.IsNullOrEmpty(arguments))
                {
                    startInfo.Arguments = arguments;
                }

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"无法启动 {fileName}：{ex.Message}", "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // 标题栏拖动
        private void TitleBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        // 窗口控制按钮
        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            // 可以在这里添加更多设置选项
        }

        // 按钮事件处理
        private void BtnDesktop_Click(object sender, RoutedEventArgs e) => StartProcess("Desk.cpl");
        private void BtnFirewall_Click(object sender, RoutedEventArgs e) => StartProcess("wf.msc");
        private void BtnAppwiz_Click(object sender, RoutedEventArgs e) => StartProcess("appwiz.cpl");
        private void BtnPowercfg_Click(object sender, RoutedEventArgs e) => StartProcess("Powercfg.cpl");
        private void BtnMouse_Click(object sender, RoutedEventArgs e) => StartProcess("main.cpl");
        private void BtnDevice_Click(object sender, RoutedEventArgs e) => StartProcess("hdwwiz.cpl");
        private void BtnIntl_Click(object sender, RoutedEventArgs e) => StartProcess("intl.cpl");
        private void BtnSound_Click(object sender, RoutedEventArgs e) => StartProcess("mmsys.cpl");
        private void BtnSystemAttribute_Click(object sender, RoutedEventArgs e) => StartProcess("sysdm.cpl");
        private void BtnDatetime_Click(object sender, RoutedEventArgs e) => StartProcess("timedate.cpl");
        private void BtnNet_Click(object sender, RoutedEventArgs e) => StartProcess("ncpa.cpl");
        private void BtnDiskClearn_Click(object sender, RoutedEventArgs e) => StartProcess("cleanmgr");
        private void BtnLockComputer_Click(object sender, RoutedEventArgs e) => StartProcess("rundll32", "user32.dll,LockWorkStation");
        private void BtnComputerManagement_Click(object sender, RoutedEventArgs e) => StartProcess("compmgmt.msc");
        private void BtnGroupStrategy_Click(object sender, RoutedEventArgs e) => StartProcess("gpedit.msc");
        private void BtnSafety_Click(object sender, RoutedEventArgs e) => StartProcess("secpol.msc");
        private void BtnGroupService_Click(object sender, RoutedEventArgs e) => StartProcess("comexp.msc");
        private void BtnDccw_Click(object sender, RoutedEventArgs e) => StartProcess("Dccw.exe");
        private void BtnDirectX_Click(object sender, RoutedEventArgs e) => StartProcess("dxdiag.exe");
        private void BtnEventvwr_Click(object sender, RoutedEventArgs e) => StartProcess("Eventvwr.exe");
        private void BtnInternetAttribute_Click(object sender, RoutedEventArgs e) => StartProcess("inetcpl.cpl");
        private void BtnUserGroup_Click(object sender, RoutedEventArgs e) => StartProcess("lusrmgr.msc");
        private void BtnSystemInfo_Click(object sender, RoutedEventArgs e) => StartProcess("msinfo32.exe");
        private void BtnRemoteDesktop_Click(object sender, RoutedEventArgs e) => StartProcess("mstsc.exe");
        private void BtnWindowsFunction_Click(object sender, RoutedEventArgs e) => StartProcess("perfmon.msc");
    }
}

