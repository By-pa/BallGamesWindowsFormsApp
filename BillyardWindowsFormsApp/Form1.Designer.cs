namespace BillyardWindowsFormsApp
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
			this.startButton = new System.Windows.Forms.Button();
			this.leftLabelScore = new System.Windows.Forms.Label();
			this.rightLabelScore = new System.Windows.Forms.Label();
			this.topLabelScore = new System.Windows.Forms.Label();
			this.bottomLabelScore = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// startButton
			// 
			this.startButton.Location = new System.Drawing.Point(691, 12);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(97, 43);
			this.startButton.TabIndex = 0;
			this.startButton.Text = "Запустить";
			this.startButton.UseVisualStyleBackColor = true;
			// 
			// leftLabelScore
			// 
			this.leftLabelScore.AutoSize = true;
			this.leftLabelScore.Location = new System.Drawing.Point(12, 201);
			this.leftLabelScore.Name = "leftLabelScore";
			this.leftLabelScore.Size = new System.Drawing.Size(14, 16);
			this.leftLabelScore.TabIndex = 1;
			this.leftLabelScore.Text = "0";
			// 
			// rightLabelScore
			// 
			this.rightLabelScore.AutoSize = true;
			this.rightLabelScore.Location = new System.Drawing.Point(774, 201);
			this.rightLabelScore.Name = "rightLabelScore";
			this.rightLabelScore.Size = new System.Drawing.Size(14, 16);
			this.rightLabelScore.TabIndex = 2;
			this.rightLabelScore.Text = "0";
			// 
			// topLabelScore
			// 
			this.topLabelScore.AutoSize = true;
			this.topLabelScore.Location = new System.Drawing.Point(401, 9);
			this.topLabelScore.Name = "topLabelScore";
			this.topLabelScore.Size = new System.Drawing.Size(14, 16);
			this.topLabelScore.TabIndex = 3;
			this.topLabelScore.Text = "0";
			// 
			// bottomLabelScore
			// 
			this.bottomLabelScore.AutoSize = true;
			this.bottomLabelScore.Location = new System.Drawing.Point(401, 437);
			this.bottomLabelScore.Name = "bottomLabelScore";
			this.bottomLabelScore.Size = new System.Drawing.Size(14, 16);
			this.bottomLabelScore.TabIndex = 4;
			this.bottomLabelScore.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bottomLabelScore);
			this.Controls.Add(this.topLabelScore);
			this.Controls.Add(this.rightLabelScore);
			this.Controls.Add(this.leftLabelScore);
			this.Controls.Add(this.startButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label leftLabelScore;
		private System.Windows.Forms.Label rightLabelScore;
		private System.Windows.Forms.Label topLabelScore;
		private System.Windows.Forms.Label bottomLabelScore;
	}
}

