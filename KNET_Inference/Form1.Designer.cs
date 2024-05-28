namespace KNET_Inference
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Canvas = new Panel();
            PredictedLabel = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ConfidenceValues = new Label();
            ClearBtn = new Button();
            BrushSize = new TrackBar();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrushSize).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // Canvas
            // 
            Canvas.BackColor = Color.Black;
            Canvas.Location = new Point(12, 12);
            Canvas.Name = "Canvas";
            Canvas.Size = new Size(426, 426);
            Canvas.TabIndex = 0;
            Canvas.MouseMove += Drawing;
            // 
            // PredictedLabel
            // 
            PredictedLabel.AutoSize = true;
            PredictedLabel.BorderStyle = BorderStyle.Fixed3D;
            PredictedLabel.Font = new Font("Impact", 36F);
            PredictedLabel.Location = new Point(50, 23);
            PredictedLabel.Name = "PredictedLabel";
            PredictedLabel.Size = new Size(66, 77);
            PredictedLabel.TabIndex = 1;
            PredictedLabel.Text = "0";
            PredictedLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(PredictedLabel);
            groupBox1.Location = new Point(456, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 114);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Predicted Label";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ConfidenceValues);
            groupBox2.Location = new Point(450, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(100, 262);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Confidence";
            // 
            // ConfidenceValues
            // 
            ConfidenceValues.AutoSize = true;
            ConfidenceValues.Font = new Font("Segoe UI", 10F);
            ConfidenceValues.Location = new Point(6, 23);
            ConfidenceValues.Name = "ConfidenceValues";
            ConfidenceValues.Size = new Size(55, 230);
            ConfidenceValues.TabIndex = 0;
            ConfidenceValues.Text = "0: 100\r\n1: 100\r\n2: 100\r\n3: 100\r\n4: 100\r\n5: 100\r\n6: 100\r\n7: 100\r\n8: 100\r\n9: 100";
            // 
            // ClearBtn
            // 
            ClearBtn.Location = new Point(456, 400);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(173, 38);
            ClearBtn.TabIndex = 5;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // BrushSize
            // 
            BrushSize.LargeChange = 10;
            BrushSize.Location = new Point(11, 23);
            BrushSize.Maximum = 60;
            BrushSize.Minimum = 10;
            BrushSize.Name = "BrushSize";
            BrushSize.Orientation = Orientation.Vertical;
            BrushSize.Size = new Size(56, 227);
            BrushSize.SmallChange = 5;
            BrushSize.TabIndex = 6;
            BrushSize.TickFrequency = 10;
            BrushSize.TickStyle = TickStyle.Both;
            BrushSize.Value = 10;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BrushSize);
            groupBox3.Location = new Point(556, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(73, 262);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "Size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(groupBox3);
            Controls.Add(ClearBtn);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Canvas);
            MaximizeBox = false;
            MaximumSize = new Size(654, 497);
            MinimumSize = new Size(654, 497);
            Name = "Form1";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MNIST";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BrushSize).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Canvas;
        private Label PredictedLabel;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label ConfidenceValues;
        private Button ClearBtn;
        private TrackBar BrushSize;
        private GroupBox groupBox3;
    }
}
