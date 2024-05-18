namespace NewProject
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
            picInput = new PictureBox();
            picOutput = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            chooseImage = new Button();
            ofd = new OpenFileDialog();
            btnOut = new Button();
            colorOfImage = new ColorDialog();
            setColor = new Button();
            label3 = new Label();
            label4 = new Label();
            nameOfColor = new Label();
            numOfColor = new Label();
            showImageOut = new Button();
            nameColor = new Label();
            autoColor = new Button();
            blueBtn = new Button();
            greenBtn = new Button();
            redBtn = new Button();
            greyBtn = new Button();
            convertToGray = new Button();
            ((System.ComponentModel.ISupportInitialize)picInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picOutput).BeginInit();
            SuspendLayout();
            // 
            // picInput
            // 
            picInput.BackColor = Color.Transparent;
            picInput.BorderStyle = BorderStyle.FixedSingle;
            picInput.Location = new Point(59, 97);
            picInput.Name = "picInput";
            picInput.Size = new Size(369, 382);
            picInput.SizeMode = PictureBoxSizeMode.StretchImage;
            picInput.TabIndex = 0;
            picInput.TabStop = false;
            picInput.Click += picInput_Click;
            picInput.Paint += picInput_Paint;
            picInput.MouseDown += picInput_MouseDown;
            picInput.MouseMove += picInput_MouseMove;
            picInput.MouseUp += picInput_MouseUp;
            // 
            // picOutput
            // 
            picOutput.BorderStyle = BorderStyle.FixedSingle;
            picOutput.Location = new Point(782, 97);
            picOutput.Name = "picOutput";
            picOutput.Size = new Size(369, 382);
            picOutput.SizeMode = PictureBoxSizeMode.StretchImage;
            picOutput.TabIndex = 1;
            picOutput.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Crimson;
            label1.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(193, 63);
            label1.Name = "label1";
            label1.Size = new Size(101, 18);
            label1.TabIndex = 2;
            label1.Text = "Input X-Ray";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.CadetBlue;
            label2.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(841, 63);
            label2.Name = "label2";
            label2.Size = new Size(117, 18);
            label2.TabIndex = 3;
            label2.Text = "Output X-Ray";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chooseImage
            // 
            chooseImage.BackColor = SystemColors.GradientActiveCaption;
            chooseImage.Font = new Font("Showcard Gothic", 9F);
            chooseImage.Location = new Point(59, 508);
            chooseImage.Name = "chooseImage";
            chooseImage.Size = new Size(374, 41);
            chooseImage.TabIndex = 4;
            chooseImage.Text = "Choose Image";
            chooseImage.UseVisualStyleBackColor = false;
            chooseImage.Click += chooseImage_Click;
            // 
            // btnOut
            // 
            btnOut.BackColor = SystemColors.ControlDark;
            btnOut.Font = new Font("Showcard Gothic", 9F);
            btnOut.Location = new Point(782, 562);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(374, 41);
            btnOut.TabIndex = 5;
            btnOut.Text = "Save Image";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // setColor
            // 
            setColor.Font = new Font("Showcard Gothic", 9F);
            setColor.Location = new Point(1183, 181);
            setColor.Name = "setColor";
            setColor.Size = new Size(253, 72);
            setColor.TabIndex = 6;
            setColor.Text = "Choose Color";
            setColor.UseVisualStyleBackColor = true;
            setColor.Click += setColor_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1183, 97);
            label3.Name = "label3";
            label3.Size = new Size(128, 18);
            label3.TabIndex = 7;
            label3.Text = "your color is : ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1183, 132);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 8;
            label4.Text = "RGB is : ";
            // 
            // nameOfColor
            // 
            nameOfColor.AutoSize = true;
            nameOfColor.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameOfColor.ForeColor = Color.DarkMagenta;
            nameOfColor.Location = new Point(1248, 386);
            nameOfColor.Name = "nameOfColor";
            nameOfColor.Size = new Size(0, 18);
            nameOfColor.TabIndex = 10;
            // 
            // numOfColor
            // 
            numOfColor.AutoSize = true;
            numOfColor.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numOfColor.ForeColor = Color.DarkMagenta;
            numOfColor.Location = new Point(1317, 132);
            numOfColor.Name = "numOfColor";
            numOfColor.Size = new Size(17, 18);
            numOfColor.TabIndex = 11;
            numOfColor.Text = "0";
            // 
            // showImageOut
            // 
            showImageOut.BackColor = SystemColors.ControlDark;
            showImageOut.Font = new Font("Showcard Gothic", 9F);
            showImageOut.Location = new Point(782, 509);
            showImageOut.Name = "showImageOut";
            showImageOut.Size = new Size(374, 41);
            showImageOut.TabIndex = 12;
            showImageOut.Text = "show Image Procces";
            showImageOut.UseVisualStyleBackColor = false;
            showImageOut.Click += showImageOut_Click;
            // 
            // nameColor
            // 
            nameColor.AutoSize = true;
            nameColor.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameColor.ForeColor = Color.DarkMagenta;
            nameColor.Location = new Point(1317, 97);
            nameColor.Name = "nameColor";
            nameColor.Size = new Size(17, 18);
            nameColor.TabIndex = 13;
            nameColor.Text = "0";
            // 
            // autoColor
            // 
            autoColor.Font = new Font("Showcard Gothic", 9F);
            autoColor.Location = new Point(477, 113);
            autoColor.Name = "autoColor";
            autoColor.Size = new Size(253, 72);
            autoColor.TabIndex = 14;
            autoColor.Text = "YOUR COLOR";
            autoColor.UseVisualStyleBackColor = true;
            autoColor.Click += autoColor_Click;
            // 
            // blueBtn
            // 
            blueBtn.BackColor = Color.Blue;
            blueBtn.Font = new Font("Showcard Gothic", 9F);
            blueBtn.Location = new Point(477, 273);
            blueBtn.Name = "blueBtn";
            blueBtn.Size = new Size(253, 72);
            blueBtn.TabIndex = 15;
            blueBtn.Text = "BLUE";
            blueBtn.UseVisualStyleBackColor = false;
            blueBtn.Click += blueBtn_Click;
            // 
            // greenBtn
            // 
            greenBtn.BackColor = Color.Green;
            greenBtn.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            greenBtn.Location = new Point(477, 195);
            greenBtn.Name = "greenBtn";
            greenBtn.Size = new Size(253, 72);
            greenBtn.TabIndex = 16;
            greenBtn.Text = "GREEN";
            greenBtn.UseVisualStyleBackColor = false;
            greenBtn.Click += greenBtn_Click;
            // 
            // redBtn
            // 
            redBtn.BackColor = Color.Red;
            redBtn.Font = new Font("Showcard Gothic", 9F);
            redBtn.Location = new Point(477, 347);
            redBtn.Name = "redBtn";
            redBtn.Size = new Size(253, 72);
            redBtn.TabIndex = 17;
            redBtn.Text = "RED";
            redBtn.UseVisualStyleBackColor = false;
            redBtn.Click += redBtn_Click;
            // 
            // greyBtn
            // 
            greyBtn.BackColor = Color.Gray;
            greyBtn.Font = new Font("Showcard Gothic", 9F);
            greyBtn.Location = new Point(477, 424);
            greyBtn.Name = "greyBtn";
            greyBtn.Size = new Size(253, 72);
            greyBtn.TabIndex = 18;
            greyBtn.Text = "Gray";
            greyBtn.UseVisualStyleBackColor = false;
            greyBtn.Click += greyBtn_Click;
            // 
            // convertToGray
            // 
            convertToGray.BackColor = SystemColors.GradientActiveCaption;
            convertToGray.Font = new Font("Showcard Gothic", 9F);
            convertToGray.Location = new Point(59, 565);
            convertToGray.Name = "convertToGray";
            convertToGray.Size = new Size(374, 41);
            convertToGray.TabIndex = 19;
            convertToGray.Text = "Convert to Gray";
            convertToGray.UseVisualStyleBackColor = false;
            convertToGray.Click += convertToGray_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1458, 684);
            Controls.Add(convertToGray);
            Controls.Add(greyBtn);
            Controls.Add(redBtn);
            Controls.Add(greenBtn);
            Controls.Add(blueBtn);
            Controls.Add(autoColor);
            Controls.Add(nameColor);
            Controls.Add(showImageOut);
            Controls.Add(numOfColor);
            Controls.Add(nameOfColor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(setColor);
            Controls.Add(btnOut);
            Controls.Add(chooseImage);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(picOutput);
            Controls.Add(picInput);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)picOutput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox picOutput;
        private Label label1;
        private Label label2;
        private Button chooseImage;
        private OpenFileDialog ofd;
        private Button btnOut;
        public PictureBox picInput;
        private ColorDialog colorOfImage;
        private Button setColor;
        private Label label3;
        private Label label4;
        private Label nameColor;
        private Label nameOfColor;
        private Label numOfColor;
        private Button showImageOut;
        private Button autoColor;
        private Button blueBtn;
        private Button greenBtn;
        private Button redBtn;
        private Button greyBtn;
        private Button convertToGray;
    }
}
