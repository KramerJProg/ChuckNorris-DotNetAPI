
namespace ChuckNorrisForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.jokeBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jokeCatCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // jokeBtn
            // 
            this.jokeBtn.Location = new System.Drawing.Point(25, 63);
            this.jokeBtn.Name = "jokeBtn";
            this.jokeBtn.Size = new System.Drawing.Size(227, 39);
            this.jokeBtn.TabIndex = 0;
            this.jokeBtn.Text = "Generate Joke!";
            this.jokeBtn.UseVisualStyleBackColor = true;
            this.jokeBtn.Click += new System.EventHandler(this.JokeBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Joke Categories";
            // 
            // jokeCatCmbBox
            // 
            this.jokeCatCmbBox.FormattingEnabled = true;
            this.jokeCatCmbBox.Location = new System.Drawing.Point(111, 17);
            this.jokeCatCmbBox.Name = "jokeCatCmbBox";
            this.jokeCatCmbBox.Size = new System.Drawing.Size(141, 21);
            this.jokeCatCmbBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 128);
            this.Controls.Add(this.jokeCatCmbBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jokeBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button jokeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox jokeCatCmbBox;
    }
}

