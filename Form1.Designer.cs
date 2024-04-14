namespace Parallel_Image_Processing
{
    partial class Form1
    {
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxGray;
        private System.Windows.Forms.PictureBox pictureBoxNegative;
        private System.Windows.Forms.PictureBox pictureBoxThreshold;
        private System.Windows.Forms.PictureBox pictureBoxMirror;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonProcessThreads;


        private void InitializeComponent()
        {
            buttonLoad = new Button();
            buttonProcess = new Button();
            pictureBoxOriginal = new PictureBox();
            pictureBoxGray = new PictureBox();
            pictureBoxNegative = new PictureBox();
            pictureBoxThreshold = new PictureBox();
            pictureBoxMirror = new PictureBox();
            openFileDialog = new OpenFileDialog();
            buttonProcessThreads = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).BeginInit();
            SuspendLayout();
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(12, 12);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(112, 38);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Load Image";
            buttonLoad.Click += ButtonLoad_Click;
            // 
            // buttonProcess
            // 
            buttonProcess.Location = new Point(130, 12);
            buttonProcess.Name = "buttonProcess";
            buttonProcess.Size = new Size(126, 38);
            buttonProcess.TabIndex = 1;
            buttonProcess.Text = "Parallel process";
            buttonProcess.Click += ButtonProcess_Click;
            // 
            // pictureBoxOriginal
            // 
            pictureBoxOriginal.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxOriginal.Location = new Point(12, 56);
            pictureBoxOriginal.Name = "pictureBoxOriginal";
            pictureBoxOriginal.Size = new Size(466, 460);
            pictureBoxOriginal.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxOriginal.TabIndex = 2;
            pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxGray
            // 
            pictureBoxGray.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxGray.Location = new Point(543, 56);
            pictureBoxGray.Name = "pictureBoxGray";
            pictureBoxGray.Size = new Size(220, 220);
            pictureBoxGray.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxGray.TabIndex = 3;
            pictureBoxGray.TabStop = false;
            // 
            // pictureBoxNegative
            // 
            pictureBoxNegative.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxNegative.Location = new Point(783, 56);
            pictureBoxNegative.Name = "pictureBoxNegative";
            pictureBoxNegative.Size = new Size(220, 220);
            pictureBoxNegative.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxNegative.TabIndex = 4;
            pictureBoxNegative.TabStop = false;
            // 
            // pictureBoxThreshold
            // 
            pictureBoxThreshold.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxThreshold.Location = new Point(543, 296);
            pictureBoxThreshold.Name = "pictureBoxThreshold";
            pictureBoxThreshold.Size = new Size(220, 220);
            pictureBoxThreshold.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxThreshold.TabIndex = 5;
            pictureBoxThreshold.TabStop = false;
            // 
            // pictureBoxMirror
            // 
            pictureBoxMirror.BorderStyle = BorderStyle.Fixed3D;
            pictureBoxMirror.Location = new Point(783, 296);
            pictureBoxMirror.Name = "pictureBoxMirror";
            pictureBoxMirror.Size = new Size(220, 220);
            pictureBoxMirror.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMirror.TabIndex = 6;
            pictureBoxMirror.TabStop = false;
            // 
            // openFileDialog
            // 
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            // 
            // buttonProcessThreads
            // 
            buttonProcessThreads.Location = new Point(262, 12);
            buttonProcessThreads.Name = "buttonProcessThreads";
            buttonProcessThreads.Size = new Size(216, 38);
            buttonProcessThreads.TabIndex = 7;
            buttonProcessThreads.Text = "Process Images with Threads";
            buttonProcessThreads.Click += ButtonProcessThreads_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(1054, 553);
            Controls.Add(buttonLoad);
            Controls.Add(buttonProcess);
            Controls.Add(pictureBoxOriginal);
            Controls.Add(pictureBoxGray);
            Controls.Add(pictureBoxNegative);
            Controls.Add(pictureBoxThreshold);
            Controls.Add(pictureBoxMirror);
            Controls.Add(buttonProcessThreads);
            Name = "Form1";
            Text = "Parallel Image Processing";
            ((System.ComponentModel.ISupportInitialize)pictureBoxOriginal).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGray).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxNegative).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxThreshold).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMirror).EndInit();
            ResumeLayout(false);
        }
    }
}
