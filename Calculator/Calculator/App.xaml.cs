using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Autofac;
using System.Reflection;

namespace Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var builder = new ContainerBuilder();

            
            var dataAccess = Assembly.GetExecutingAssembly();
            // Scan an assembly for components
            builder.RegisterAssemblyTypes(dataAccess)
                   .AsImplementedInterfaces()
                   .AsSelf();

            var container = builder.Build();

            MainPage = container.Resolve<CalculatorView>();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
