using COMP123_S2019_A5_300818557.Models;
using COMP123_S2019_A5_300818557.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_300818557
{
    public static class Program
    {
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static StartForm startForm;
        public static ProductInfoForm productInfoForm;
        public static SplashForm splashForm;
        public static AboutForm aboutForm;

        public static Product product;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            orderForm = new OrderForm();
            selectForm = new SelectForm();
            startForm = new StartForm();
            productInfoForm = new ProductInfoForm();
            splashForm = new SplashForm();
            aboutForm = new AboutForm();
            product = new Product();

            Application.Run(selectForm);
        }
    }
}
