namespace CatchMe2WindowsFormsApp
{
	partial class MainForm
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
			this.startButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.countBallsLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(12, 12);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(96, 23);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Создать";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(12, 41);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(96, 26);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "Очистить";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// countBallsLabel
			// 
			this.countBallsLabel.AutoSize = true;
			this.countBallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.countBallsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.countBallsLabel.Location = new System.Drawing.Point(762, 9);
			this.countBallsLabel.Name = "countBallsLabel";
			this.countBallsLabel.Size = new System.Drawing.Size(26, 29);
			this.countBallsLabel.TabIndex = 3;
			this.countBallsLabel.Text = "0";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.countBallsLabel);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.startButton);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Label countBallsLabel;
	}
}

