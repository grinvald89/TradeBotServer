﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Server
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBase.DataBase.open();
            Config.lPairs = DataBase.DataBase.getPairs();

            // DataBase.TXTtoDB.Candlesticks();
            // DataBase.TXTtoDB.Ticks();

            Simulation.Simulation.StartHistoryAnalysis(
                new DateTime(2018, 03, 23),
                new DateTime(2018, 04, 09)
            );

            // ThreadPool.QueueUserWorkItem(StateInfo => new WebServer.Server(8080));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}