////////////////////////////////////////////////////////////////////
// 無人機服務 parser 測試

using System;
using System.IO;
using System.Net;
using System.Text;
using Microsoft.Win32;
using MediaToolkit;
using MediaToolkit.Model;
using MediaToolkit.Options;

namespace idtCarCapture
{
    class idtCarCapture
    {
        /////////////////////////////////////////////////////
        // 內用變數定義        
 
        /////////////////////////////////////////////////////
        // 處理程序定義 

        // 主程序
        static void Main(string[] args)
        {
            string rootPath = @"D:\農委會\CaptureRoot\20230926\10\";
            //string rootPath = @"D:\videoStorage\0002D19E2E3B\20230926\10\";
            string subPath = rootPath + @"車牌快照20230926_102224";
            bool exists = System.IO.Directory.Exists(subPath);
            if(!exists)
                System.IO.Directory.CreateDirectory(subPath);

            var inputFile = new MediaFile { Filename = rootPath + @"22.mp4" };

            using (var engine = new Engine())
            {
                engine.GetMetadata(inputFile);

                // Saves the frame located on the 15th second of the video.
                var outputFile1 = new MediaFile { Filename = subPath+@"\1.jpg" };
                var options1 = new ConversionOptions { Seek = TimeSpan.FromSeconds(14) };
                engine.GetThumbnail(inputFile, outputFile1, options1);
                var outputFile2 = new MediaFile { Filename = subPath+@"\2.jpg" };
                var options2 = new ConversionOptions { Seek = TimeSpan.FromSeconds(16) };
                engine.GetThumbnail(inputFile, outputFile2, options2);
                var outputFile3 = new MediaFile { Filename = subPath+@"\3.jpg" };
                var options3 = new ConversionOptions { Seek = TimeSpan.FromSeconds(18) };
                engine.GetThumbnail(inputFile, outputFile3, options3);
                var outputFile4 = new MediaFile { Filename = subPath+@"\4.jpg" };
                var options4 = new ConversionOptions { Seek = TimeSpan.FromSeconds(20) };
                engine.GetThumbnail(inputFile, outputFile4, options4);
                var outputFile5 = new MediaFile { Filename = subPath+@"\5.jpg" };
                var options5 = new ConversionOptions { Seek = TimeSpan.FromSeconds(22) };
                engine.GetThumbnail(inputFile, outputFile5, options5);
            }

            //Console.WriteLine("完成");
            //Console.ReadKey();
        }

    }
}
