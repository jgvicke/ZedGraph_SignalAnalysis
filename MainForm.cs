using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;
using AForge.Math;
using System.Collections;
using System.Collections.Generic;

namespace SignalAnalysis
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private GraphPane _inputPane;
        private GraphPane _outputPane;
        private RollingPointPairList _inputPoints;
        private RollingPointPairList _outputPoints;
        private readonly ArrayList _frequencies = new ArrayList();

        private double _sinPart, _secPart;
        private int _sampleNum;

        private const int SampleRate = 50000;
        private const int SampleSize = 20000;
        private readonly int _ffTsize = (int)Math.Pow(2, 14); // must be of size 2^n where n = 1..14


        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGraphs();
        }

        private void InitializeGraphs()
        {
            _sinPart = 2 * Math.PI / SampleRate;
            _secPart = 1.0 / SampleRate;
            _sampleNum = 0;

            FindGcd();

            _inputPane = FrequencySample.GraphPane;
            _inputPane.Title.Text = " ";
            _inputPane.Legend.IsVisible = false;
            _inputPane.YAxis.Title.Text = "Amplitude";
            _inputPane.XAxis.Title.Text = "Seconds";

            _inputPane.YAxis.Scale.MajorStep = 1;
            _inputPane.YAxis.Scale.MinorStep = 1;

            _inputPoints = new RollingPointPairList(SampleSize);
            _inputPane.AddCurve("Test Curve1", _inputPoints, Color.Blue, SymbolType.None);


            _outputPane = FFToutput.GraphPane;
            _outputPane.Title.Text = " ";
            _outputPane.Legend.IsVisible = false;
            _outputPane.YAxis.Title.Text = "Amplitude";
            _outputPane.XAxis.Title.Text = "Frequency";

            _outputPane.YAxis.Scale.Min = 0;
            _outputPane.YAxis.Scale.MajorStep = 0.1;
            _outputPane.YAxis.Scale.MinorStep = 0.1;

            _outputPane.XAxis.Scale.Format = "#";
            _outputPane.XAxis.Scale.Mag = 0;
            _outputPane.XAxis.Scale.Min = 0;
            _outputPane.XAxis.Scale.Max = 2500;

            _outputPoints = new RollingPointPairList(_ffTsize + 1);
            _outputPane.AddCurve("Frequencies", _outputPoints, Color.Blue, SymbolType.None);
        }

        // this function generates the data of the signal, in a real application, this would be replaced by whatever gathers the real data
        private void generateData_Tick(object sender, EventArgs e)
        {
            for (var j = 0; j < SampleRate * 0.01; j++)
            {
                _sampleNum++;
                double value = 0;
                if (checkBox1.Checked) { value += (double)ampUpDown1.Value * Math.Sin(_sinPart * (double)numericUpDown1.Value * _sampleNum); }
                if (checkBox2.Checked) { value += (double)ampUpDown2.Value * Math.Sin(_sinPart * (double)numericUpDown2.Value * _sampleNum); }
                if (checkBox3.Checked) { value += (double)ampUpDown3.Value * Math.Sin(_sinPart * (double)numericUpDown3.Value * _sampleNum); }
                if (checkBox4.Checked) { value += (double)ampUpDown4.Value * Math.Sin(_sinPart * (double)numericUpDown4.Value * _sampleNum); }
                if (checkBox5.Checked) { value += (double)ampUpDown5.Value * Math.Sin(_sinPart * (double)numericUpDown5.Value * _sampleNum); }
                if (checkBox6.Checked) { value += (double)ampUpDown6.Value * Math.Sin(_sinPart * (double)numericUpDown6.Value * _sampleNum); }
                if (checkBox7.Checked) { value += (double)ampUpDown7.Value * Math.Sin(_sinPart * (double)numericUpDown7.Value * _sampleNum); }
                if (checkBox8.Checked) { value += (double)ampUpDown8.Value * Math.Sin(_sinPart * (double)numericUpDown8.Value * _sampleNum); }
                _inputPoints.Add(_sampleNum * _secPart, value);
            }

        }

        // this timer tick updates the graphs, and shows the last complete waveform of the signal
        private void graphUpdate_Tick(object sender, EventArgs e)
        {
            var displayLength = 2 / (double)displayFrequency.Value;
            var divisor = (int)(displayLength * SampleRate);

            if (divisor <= 0)
                return;

            var index = _inputPoints.Count - 1 - _sampleNum % divisor;

            if (index >= 0)
            {
                _inputPane.XAxis.Scale.Max = _inputPoints[index].X;
                _inputPane.XAxis.Scale.Min = _inputPane.XAxis.Scale.Max - displayLength;

                FrequencySample.AxisChange();
                FrequencySample.Invalidate();
            }


            // generate the FFT
            if (index >= _ffTsize)
            {
                _outputPoints.Clear();
                var ffTdata = new Complex[_ffTsize];

                for (var i = 0; i < _ffTsize; i++)
                {
                    ffTdata[i] = new Complex(_inputPoints[index - _ffTsize + i].Y, 0);
                }

                FourierTransform.FFT(ffTdata, FourierTransform.Direction.Forward);

                var range = _ffTsize >> 1;
                for (var i = 0; i <= range; i++)
                {
                    var frequency = i * SampleRate / (double)_ffTsize;
                    _outputPoints.Add(frequency, Math.Abs(ffTdata[i].Re));
                }
            }

            FFToutput.AxisChange();
            FFToutput.Invalidate();
        }
        
        private void InputChanged(object sender, EventArgs e)
        {
            FindGcd();
        }

        private void FindGcd()
        {
            _frequencies.Clear();
            if (checkBox1.Checked) { _frequencies.Add((int)numericUpDown1.Value); }
            if (checkBox2.Checked) { _frequencies.Add((int)numericUpDown2.Value); }
            if (checkBox3.Checked) { _frequencies.Add((int)numericUpDown3.Value); }
            if (checkBox4.Checked) { _frequencies.Add((int)numericUpDown4.Value); }
            if (checkBox5.Checked) { _frequencies.Add((int)numericUpDown5.Value); }
            if (checkBox6.Checked) { _frequencies.Add((int)numericUpDown6.Value); }
            if (checkBox7.Checked) { _frequencies.Add((int)numericUpDown7.Value); }
            if (checkBox8.Checked) { _frequencies.Add((int)numericUpDown8.Value); }

            if (_frequencies.Count < 1)
                return;

            var values = _frequencies.ToArray(typeof(int)) as int[];
            displayFrequency.Value = GreatestCommonDivisor(values);
        }

        private static int GreatestCommonDivisor(int a, int b)
        {
            while (true)
            {
                if (b == 0) return a;
                var a1 = a;
                a = b;
                b = a1%b;
            }
        }

        private static int GreatestCommonDivisor(IEnumerable<int> integerSet)
        {
            return integerSet.Aggregate(GreatestCommonDivisor);
        }
        
        private void FFToutput_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index;
                CurveItem curve;
                var pointFound = FFToutput.GraphPane.FindNearestPoint(new Point(e.X, e.Y), out curve, out index);
                _outputPane.Title.Text = pointFound ? $"Frequency = {curve.Points[index].X}Hz" : " ";
            }
            catch
            {
                // ignored
            }
        }

    }
}
