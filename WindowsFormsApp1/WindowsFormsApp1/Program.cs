using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using NAudio.Wave;
using MathNet.Numerics;
using OxyPlot.Series;
using OxyPlot;
using System.Collections.Generic;
using NAudio.Gui;
using NAudio.Wave.SampleProviders;
using System.Linq;
using OxyPlot.WindowsForms;
using MathNet.Numerics.IntegralTransforms;
using System.Numerics;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Main());
        }
    }
}
