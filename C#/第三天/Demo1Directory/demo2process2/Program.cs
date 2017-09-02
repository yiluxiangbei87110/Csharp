using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2process2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入您想进入的磁盘");
            string path = Console.ReadLine();
            Console.WriteLine("请输入您想打开的文件");
            string fileName = Console.ReadLine();
            FileFather ff = GetFile(fileName,path+fileName);
            ff.OpenFile();
            Console.ReadKey();
        }
        public static FileFather GetFile(string fileT,string fullpath)
        {
            FileFather f = null;
            string extention = Path.GetExtension(fullpath);
            switch (extention)
            {
                case ".txt": f = new TextClass(fullpath);
                    break;
                case ".jpg": f = new JpgClass(fullpath);
                    break;
            }
    
            return f;
        }
    }
    public abstract class FileFather
    {
        //属性可以传递
        public string fileName
        {
            get;
            set;
        }

        public FileFather(string fileName)
        {
            this.fileName = fileName;
        }
  
        public abstract void OpenFile();
    }

    public class TextClass : FileFather
    {
        public TextClass(string fileName):base(fileName)
        {

        }
        public override  void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }
    public class JpgClass : FileFather
    {
        public JpgClass(string fileName):base(fileName)
        {

        }
        public override void OpenFile()
        {
            ProcessStartInfo psi = new ProcessStartInfo(this.fileName);
            Process p = new Process();
            p.StartInfo = psi;
            p.Start();
        }
    }

}
