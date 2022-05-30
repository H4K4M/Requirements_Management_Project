/*
  Author: Muhammed Suwaneh
  Software Engineer & Student
  Eskişehir Osmangazi University
  May 2022
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReqApp.helpers
{
    public class TimeOut
    {
        /// <summary>
        ///  Sets a timeout 
        /// </summary>
       public static void SwapWindows(Form formToOpen, Form formToClose, int time)
        {
            var timer = new System.Windows.Forms.Timer();

            timer.Interval = time;
            timer.Tick += (s, e) =>
            {
                formToClose.Hide();
                formToOpen.Closed += (ss, args) => formToClose.Close();
                formToOpen.Show();
                timer.Stop();
            };

            timer.Start();
        }
    }
}
