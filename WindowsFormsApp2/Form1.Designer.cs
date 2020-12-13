
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.score_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dog_pictureBox = new System.Windows.Forms.PictureBox();
            this.gameover_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dog_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.BackColor = System.Drawing.SystemColors.InfoText;
            this.score_label.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.score_label.Location = new System.Drawing.Point(659, 531);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(27, 25);
            this.score_label.TabIndex = 0;
            this.score_label.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::WindowsFormsApp2.Resource1.button;
            this.button1.Location = new System.Drawing.Point(71, 528);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 57);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dog_pictureBox
            // 
            this.dog_pictureBox.Image = global::WindowsFormsApp2.Resource1.Dog;
            this.dog_pictureBox.Location = new System.Drawing.Point(351, 297);
            this.dog_pictureBox.Name = "dog_pictureBox";
            this.dog_pictureBox.Size = new System.Drawing.Size(87, 125);
            this.dog_pictureBox.TabIndex = 2;
            this.dog_pictureBox.TabStop = false;
            this.dog_pictureBox.Visible = false;
            // 
            // gameover_label
            // 
            this.gameover_label.AutoSize = true;
            this.gameover_label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(165)))), ((int)(((byte)(254)))));
            this.gameover_label.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameover_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gameover_label.Location = new System.Drawing.Point(221, 158);
            this.gameover_label.Name = "gameover_label";
            this.gameover_label.Size = new System.Drawing.Size(388, 66);
            this.gameover_label.TabIndex = 3;
            this.gameover_label.Text = "GAME OVER";
            this.gameover_label.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Resource1.Background1;
            this.ClientSize = new System.Drawing.Size(793, 602);
            this.Controls.Add(this.gameover_label);
            this.Controls.Add(this.dog_pictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.score_label);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Duck Hunt";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.dog_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox dog_pictureBox;
        private System.Windows.Forms.Label gameover_label;
    }
}

