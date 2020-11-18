using System;
using System.Collections.Generic;
using System.Reflection;
using OmniXaml.Attributes;
using OmniXaml.Services;
using OmniXaml;
using Tizen.NUI.BaseComponents;
using Tizen.NUI;

namespace Sample
{
    class Program : NUIApplication
    {
        protected override void OnCreate()
        {
            base.OnCreate();
            StyleManager.Get().ApplyTheme("C:/work/dali-env/share/com.samsung.dali-demo/res/style/demo-theme.json");
            IList<Assembly> assemblies = new List<Assembly> { Assembly.GetEntryAssembly() };
            var text = (TextLabel) new Nui.Vsix.Xaml.Loader(assemblies).Load(@"<TextLabel  xmlns=""http://tizen.org/Tizen.NUI/2018/XAML""
                Text=""Hello World"" PointSize=""12.0"" HorizontalAlignment=""Center"" VerticalAlignment=""Center"" TextColor=""Blue""/>");
            //text.TextColor = Color.Blue;
            //text.ParentOrigin = ParentOrigin.CenterLeft;
            //text.PivotPoint = PivotPoint.Center;
            //text.HorizontalAlignment = HorizontalAlignment.Center;
            //text.PointSize = 12.0f;
            //text.HeightResizePolicy = ResizePolicyType.FillToParent;
            //text.WidthResizePolicy = ResizePolicyType.FillToParent;
            //NUIApplication.GetDefaultWindow().GetDefaultLayer().Add(text);*/
            Window.Instance.GetDefaultLayer().Add(text);
        }

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
