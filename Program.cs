using System;
using System.Reflection;
using System.Windows.Forms;

namespace WordToPDF
{
    class Program
    {
        [STAThreadAttribute]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 初始化時添加以下程式
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                // 注意此為主程式的命名空間
                string resourceName = "WordToPDF.dll." + new AssemblyName(args.Name).Name + ".dll";
                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            Application.Run(new Word2PDF());
        }
    }
}