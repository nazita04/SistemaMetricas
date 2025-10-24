﻿using Abm.Builder.Handlers;
using SistemaMetricas.Services.Handlers;
using System;
using System.Windows.Forms;

namespace SistemaMetricas
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            SqliteHandler.ConnectionString = "Data Source=" + Application.StartupPath + "\\Database\\SistemaMetricas.db";
            SqlBuilderHandler.ConnectionString = SqliteHandler.ConnectionString;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
