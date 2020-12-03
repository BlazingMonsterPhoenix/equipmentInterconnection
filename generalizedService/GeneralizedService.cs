using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace generalizedService
{
    public partial class generalizedService : ServiceBase
    {
        private Timer timer = new Timer();

        public generalizedService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ConfigFileReader.read();
            FilesCheker.checkFiles();
            startTimeJob(timer);
        }

        protected override void OnStop()
        {

        }

        /**
         * 执行定时任务
         * */
        private void startTimeJob(Timer timer)
        {
            //执行时间间隔
            timer.Interval = GlobleParams.getFrequency() * 1000;
            timer.Elapsed += new ElapsedEventHandler(Worker.work);
            timer.Start();
        }
    }
}
