using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Project_FormBasics
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());
            MessageBox.Show("Продолжаем изучать C#", "Window", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            // Передаем до 4-х аргументов в show
            // Первый аргумент - содержимое 
            // Второй аргумент - название окна
            // Третий аргумент - Наличие кнопок 
            // Четвертый аргумент - значение окна (в данном случае это предупреждение, а именно восклицательный знак в желтом треугольнике)
        }
    }
}
