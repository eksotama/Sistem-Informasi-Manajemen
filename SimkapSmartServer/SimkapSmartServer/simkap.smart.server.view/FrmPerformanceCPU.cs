using System;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace SimkapSmartServer.simkap.smart.server.view
{
    public partial class FrmPerformanceCPU : DevComponents.DotNetBar.Metro.MetroForm
    {
        public FrmPerformanceCPU()
        {
            InitializeComponent();
            InitializeFunction();
        }

        #region All Function

        private void InitializeFunction()
        {
            getPerformanceCounter();
            getAvailableRAM();
        }

        #region Setting

        private void setPerformanceCounter()
        {
            cpuPermCounter = new PerformanceCounter();

            cpuPermCounter.CategoryName = "Processor";
            cpuPermCounter.CounterName = "% Processor Time";
            cpuPermCounter.InstanceName = "_Total";

            while (true)
            {
                cpuArray[cpuArray.Length - 1] = Math.Round(cpuPermCounter.NextValue(), 0);
                Array.Copy(cpuArray, 1, cpuArray, 0, cpuArray.Length - 1);

                if (cpuChart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { updateChart(); });
                }
                else
                {
                    //.............
                }

                Thread.Sleep(1000);
            }
        }

        private void updateChart()
        {
            cpuChart.Series["Penggunaan CPU"].Points.Clear();

            for (int i = 0; i < cpuArray.Length - 1; ++i)
            {
                cpuChart.Series["Penggunaan CPU"].Points.AddY(cpuArray[i]);
            }
        }

        private void getPerformanceCounter()
        {
            cpuThread = new Thread(new ThreadStart(this.setPerformanceCounter));
            cpuThread.IsBackground = true;
            cpuThread.Start();
        }

        private void getAvailableRAM()
        {
            ramPermCounter = new PerformanceCounter("Memory", "Available MBytes");

            lblRAM.Text = "Memori RAM : " + ramPermCounter.NextValue() + "%";
        }

        #endregion

        #endregion

        private void cpuChart_MouseMove(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
