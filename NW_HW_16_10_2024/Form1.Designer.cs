namespace NW_HW_16_10_2024
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            OpenPathButton = new Button();
            SaveImgButton = new Button();
            ImgURLTextBox = new TextBox();
            LocalPathTextBox = new TextBox();
            ImgNameTextBox = new TextBox();
            ClearURLButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 26);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Img URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 104);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Folder path to Save:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 107);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Img name:";
            // 
            // OpenPathButton
            // 
            OpenPathButton.Location = new Point(455, 136);
            OpenPathButton.Name = "OpenPathButton";
            OpenPathButton.Size = new Size(49, 27);
            OpenPathButton.TabIndex = 3;
            OpenPathButton.Text = "...";
            OpenPathButton.UseVisualStyleBackColor = true;
            OpenPathButton.Click += OpenPathButton_Click;
            // 
            // SaveImgButton
            // 
            SaveImgButton.Location = new Point(672, 97);
            SaveImgButton.Name = "SaveImgButton";
            SaveImgButton.Size = new Size(101, 66);
            SaveImgButton.TabIndex = 4;
            SaveImgButton.Text = "Save";
            SaveImgButton.UseVisualStyleBackColor = true;
            SaveImgButton.Click += SaveImgButton_Click;
            // 
            // ImgURLTextBox
            // 
            ImgURLTextBox.Location = new Point(27, 57);
            ImgURLTextBox.Name = "ImgURLTextBox";
            ImgURLTextBox.Size = new Size(619, 27);
            ImgURLTextBox.TabIndex = 5;
            // 
            // LocalPathTextBox
            // 
            LocalPathTextBox.Location = new Point(27, 136);
            LocalPathTextBox.Name = "LocalPathTextBox";
            LocalPathTextBox.Size = new Size(422, 27);
            LocalPathTextBox.TabIndex = 6;
            // 
            // ImgNameTextBox
            // 
            ImgNameTextBox.Location = new Point(510, 136);
            ImgNameTextBox.Name = "ImgNameTextBox";
            ImgNameTextBox.Size = new Size(136, 27);
            ImgNameTextBox.TabIndex = 7;
            // 
            // ClearURLButton
            // 
            ClearURLButton.Location = new Point(672, 57);
            ClearURLButton.Name = "ClearURLButton";
            ClearURLButton.Size = new Size(101, 31);
            ClearURLButton.TabIndex = 8;
            ClearURLButton.Text = "Clear";
            ClearURLButton.UseVisualStyleBackColor = true;
            ClearURLButton.Click += ClearURLButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 217);
            Controls.Add(ClearURLButton);
            Controls.Add(ImgNameTextBox);
            Controls.Add(LocalPathTextBox);
            Controls.Add(ImgURLTextBox);
            Controls.Add(SaveImgButton);
            Controls.Add(OpenPathButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button OpenPathButton;
        private Button SaveImgButton;
        private TextBox ImgURLTextBox;
        private TextBox LocalPathTextBox;
        private TextBox ImgNameTextBox;
        private Button ClearURLButton;
    }
}
