namespace BallGamesWindowsFormsApp
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
			this.components = new System.ComponentModel.Container();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.startButton = new System.Windows.Forms.Button();
			this.clearButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// timer
			// 
			this.timer.Interval = 15;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// startButton
			// 
			this.startButton.BackColor = System.Drawing.Color.Lime;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.startButton.ForeColor = System.Drawing.Color.Black;
			this.startButton.Location = new System.Drawing.Point(689, 12);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(99, 35);
			this.startButton.TabIndex = 2;
			this.startButton.Text = "Создать";
			this.startButton.UseVisualStyleBackColor = false;
			this.startButton.Click += new System.EventHandler(this.button3_Click);
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.SystemColors.Info;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.clearButton.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.clearButton.Location = new System.Drawing.Point(689, 94);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(99, 35);
			this.clearButton.TabIndex = 3;
			this.clearButton.Text = "Очистить";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// stopButton
			// 
			this.stopButton.BackColor = System.Drawing.Color.Yellow;
			this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.stopButton.ForeColor = System.Drawing.Color.Maroon;
			this.stopButton.Location = new System.Drawing.Point(689, 53);
			this.stopButton.Name = "stopButton";
			this.stopButton.Size = new System.Drawing.Size(99, 35);
			this.stopButton.TabIndex = 4;
			this.stopButton.Text = "Остановить";
			this.stopButton.UseVisualStyleBackColor = false;
			this.stopButton.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button4.ForeColor = System.Drawing.Color.Black;
			this.button4.Location = new System.Drawing.Point(689, 135);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(99, 35);
			this.button4.TabIndex = 5;
			this.button4.Text = "Выход";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.startButton);
			this.Name = "MainForm";
			this.Text = "Мячики";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button stopButton;
		private System.Windows.Forms.Button button4;
	}
}

