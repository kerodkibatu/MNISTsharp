using System.Collections;
using System.Drawing.Drawing2D;
using TorchSharp;

namespace KNET_Inference
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        private Graphics p;
        KNet net;

        public Form1()
        {
            InitializeComponent();
            net = new KNet();
            net.load("KNET.dat");

            bitmap = new Bitmap(Canvas.Width, Canvas.Height);
            p = Graphics.FromImage(bitmap);
            p.Clear(Color.Black);
        }

        private void Drawing(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.None)
                return;
            int size = BrushSize.Value;
            var brush = Brushes.Black;
            if (e.Button == MouseButtons.Left)
            {
                brush = Brushes.White;
            }
            else if (e.Button == MouseButtons.Right)
            {
                brush = Brushes.Black;
            }
            p.FillEllipse(brush, e.X - size, e.Y - size, size*2, size*2);
            InvalidateCanvas();
        }
        void InvalidateCanvas()
        {
            var pG = Canvas.CreateGraphics();
            pG.InterpolationMode = InterpolationMode.NearestNeighbor;
            var inputImg = bitmap.GetThumbnailImage(28, 28, null, IntPtr.Zero);
            pG.DrawImage(bitmap, 0, 0, Canvas.Size.Width, Canvas.Size.Height);

            var rescaled = new Bitmap(inputImg);
            float[,] data = new float[28,28];
            for (int i = 0; i < 28; i++)
                for (int j = 0; j < 28; j++)
                    data[j, i] = rescaled.GetPixel(i, j).R / 255.0f;

            var input = torch.tensor(data).reshape(1,1, 28, 28);
            //input = torchvision.transforms.Normalize(means: [0.1307], stdevs: [0.3081]).call(input);
            var output = net.forward(input,false);

            var rawScores = (ArrayList)output.squeeze().softmax(0).tolist();
            
            var scores = rawScores.ToArray().Select((x) => ((Scalar)x).ToSingle()).ToArray();
            ConfidenceValues.Text =
                $"""
                0: {scores[0]:P2}
                1: {scores[1]:P2}
                2: {scores[2]:P2}
                3: {scores[3]:P2}
                4: {scores[4]:P2}
                5: {scores[5]:P2}
                6: {scores[6]:P2}
                7: {scores[7]:P2}
                8: {scores[8]:P2}
                9: {scores[9]:P2}
                """;
            (_, var predicted) = torch.max(output, 1);
            PredictedLabel.Text = predicted.item<long>().ToString();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            p.Clear(Color.Black);
            InvalidateCanvas();
        }
    }
}
