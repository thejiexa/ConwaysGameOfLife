namespace ConwaysGameOfLife
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            gameBoardPb = new PictureBox();
            densityTb = new TrackBar();
            resolutionTb = new TrackBar();
            oneStepPb = new PictureBox();
            pausePb = new PictureBox();
            startPb = new PictureBox();
            densityPb = new PictureBox();
            resolutionPb = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gameBoardPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityTb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resolutionTb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oneStepPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pausePb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)startPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)densityPb).BeginInit();
            ((System.ComponentModel.ISupportInitialize)resolutionPb).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel2;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(gameBoardPb);
            splitContainer1.Panel1MinSize = 200;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(densityTb);
            splitContainer1.Panel2.Controls.Add(resolutionTb);
            splitContainer1.Panel2.Controls.Add(oneStepPb);
            splitContainer1.Panel2.Controls.Add(pausePb);
            splitContainer1.Panel2.Controls.Add(startPb);
            splitContainer1.Panel2.Controls.Add(densityPb);
            splitContainer1.Panel2.Controls.Add(resolutionPb);
            splitContainer1.Panel2MinSize = 100;
            splitContainer1.Size = new Size(1116, 545);
            splitContainer1.SplitterDistance = 1000;
            splitContainer1.TabIndex = 0;
            // 
            // gameBoardPb
            // 
            gameBoardPb.BorderStyle = BorderStyle.Fixed3D;
            gameBoardPb.Dock = DockStyle.Fill;
            gameBoardPb.Location = new Point(0, 0);
            gameBoardPb.Name = "gameBoardPb";
            gameBoardPb.Size = new Size(1000, 545);
            gameBoardPb.TabIndex = 0;
            gameBoardPb.TabStop = false;
            gameBoardPb.MouseMove += GameBoardPb_MouseMove;
            // 
            // densityTb
            // 
            densityTb.Cursor = Cursors.Hand;
            densityTb.Location = new Point(5, 202);
            densityTb.Maximum = 25;
            densityTb.Minimum = 2;
            densityTb.Name = "densityTb";
            densityTb.RightToLeft = RightToLeft.No;
            densityTb.Size = new Size(99, 45);
            densityTb.TabIndex = 15;
            densityTb.TickStyle = TickStyle.None;
            densityTb.Value = 24;
            // 
            // resolutionTb
            // 
            resolutionTb.Cursor = Cursors.Hand;
            resolutionTb.Location = new Point(5, 82);
            resolutionTb.Maximum = 25;
            resolutionTb.Minimum = 2;
            resolutionTb.Name = "resolutionTb";
            resolutionTb.RightToLeft = RightToLeft.Yes;
            resolutionTb.Size = new Size(100, 45);
            resolutionTb.TabIndex = 14;
            resolutionTb.TickStyle = TickStyle.None;
            resolutionTb.Value = 3;
            // 
            // oneStepPb
            // 
            oneStepPb.BackgroundImageLayout = ImageLayout.Zoom;
            oneStepPb.Cursor = Cursors.Hand;
            oneStepPb.Location = new Point(20, 436);
            oneStepPb.Name = "oneStepPb";
            oneStepPb.Size = new Size(70, 70);
            oneStepPb.SizeMode = PictureBoxSizeMode.StretchImage;
            oneStepPb.TabIndex = 12;
            oneStepPb.TabStop = false;
            oneStepPb.Click += OneStepPb_Click;
            // 
            // pausePb
            // 
            pausePb.BackgroundImageLayout = ImageLayout.Zoom;
            pausePb.Cursor = Cursors.Hand;
            pausePb.Location = new Point(20, 347);
            pausePb.Name = "pausePb";
            pausePb.Size = new Size(70, 70);
            pausePb.SizeMode = PictureBoxSizeMode.StretchImage;
            pausePb.TabIndex = 11;
            pausePb.TabStop = false;
            pausePb.Click += PausePb_Click;
            // 
            // startPb
            // 
            startPb.BackgroundImageLayout = ImageLayout.Zoom;
            startPb.Cursor = Cursors.Hand;
            startPb.Location = new Point(20, 258);
            startPb.Name = "startPb";
            startPb.Size = new Size(70, 70);
            startPb.SizeMode = PictureBoxSizeMode.StretchImage;
            startPb.TabIndex = 10;
            startPb.TabStop = false;
            startPb.Click += StartPb_Click;
            // 
            // densityPb
            // 
            densityPb.BackgroundImageLayout = ImageLayout.Zoom;
            densityPb.Location = new Point(20, 129);
            densityPb.Name = "densityPb";
            densityPb.Size = new Size(70, 70);
            densityPb.SizeMode = PictureBoxSizeMode.StretchImage;
            densityPb.TabIndex = 9;
            densityPb.TabStop = false;
            // 
            // resolutionPb
            // 
            resolutionPb.BackgroundImageLayout = ImageLayout.Zoom;
            resolutionPb.Location = new Point(20, 9);
            resolutionPb.Name = "resolutionPb";
            resolutionPb.Size = new Size(70, 70);
            resolutionPb.SizeMode = PictureBoxSizeMode.StretchImage;
            resolutionPb.TabIndex = 8;
            resolutionPb.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 50;
            timer.Tick += Timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(1116, 545);
            Controls.Add(splitContainer1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Game of Life";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gameBoardPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityTb).EndInit();
            ((System.ComponentModel.ISupportInitialize)resolutionTb).EndInit();
            ((System.ComponentModel.ISupportInitialize)oneStepPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)pausePb).EndInit();
            ((System.ComponentModel.ISupportInitialize)startPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)densityPb).EndInit();
            ((System.ComponentModel.ISupportInitialize)resolutionPb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox gameBoardPb;
        private System.Windows.Forms.Timer timer;
        private PictureBox pausePb;
        private PictureBox startPb;
        private PictureBox densityPb;
        private PictureBox resolutionPb;
        private PictureBox oneStepPb;
        private TrackBar resolutionTb;
        private TrackBar densityTb;
    }
}
