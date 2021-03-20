/*
 * Criado por SharpDevelop.
 * Usuário: User
 * Data: 17/03/2021
 * Hora: 15:23
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace QuasarCare
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.MainProgressBar = new System.Windows.Forms.ProgressBar();
			this.DEFRAG = new System.Windows.Forms.CheckBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.FLUSHDNS = new System.Windows.Forms.CheckBox();
			this.CLEARTEMP = new System.Windows.Forms.CheckBox();
			this.EXEC_BTN = new System.Windows.Forms.Button();
			this.Main_Timer = new System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainProgressBar
			// 
			this.MainProgressBar.Location = new System.Drawing.Point(105, 134);
			this.MainProgressBar.Name = "MainProgressBar";
			this.MainProgressBar.Size = new System.Drawing.Size(298, 23);
			this.MainProgressBar.TabIndex = 1;
			this.MainProgressBar.Click += new System.EventHandler(this.MainProgressBarClick);
			// 
			// DEFRAG
			// 
			this.DEFRAG.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DEFRAG.Location = new System.Drawing.Point(27, 19);
			this.DEFRAG.Name = "DEFRAG";
			this.DEFRAG.Size = new System.Drawing.Size(229, 24);
			this.DEFRAG.TabIndex = 2;
			this.DEFRAG.Text = "Desfragmentação de Disco";
			this.DEFRAG.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.FLUSHDNS);
			this.groupBox1.Controls.Add(this.CLEARTEMP);
			this.groupBox1.Controls.Add(this.DEFRAG);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(391, 116);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "OPÇÕES DE MANUTENÇÃO";
			// 
			// FLUSHDNS
			// 
			this.FLUSHDNS.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FLUSHDNS.Location = new System.Drawing.Point(27, 79);
			this.FLUSHDNS.Name = "FLUSHDNS";
			this.FLUSHDNS.Size = new System.Drawing.Size(229, 24);
			this.FLUSHDNS.TabIndex = 4;
			this.FLUSHDNS.Text = "Liberação do cache DNS";
			this.FLUSHDNS.UseVisualStyleBackColor = true;
			// 
			// CLEARTEMP
			// 
			this.CLEARTEMP.Font = new System.Drawing.Font("Bahnschrift", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CLEARTEMP.Location = new System.Drawing.Point(27, 49);
			this.CLEARTEMP.Name = "CLEARTEMP";
			this.CLEARTEMP.Size = new System.Drawing.Size(229, 24);
			this.CLEARTEMP.TabIndex = 3;
			this.CLEARTEMP.Text = "Limpeza de arquivos temporários";
			this.CLEARTEMP.UseVisualStyleBackColor = true;
			// 
			// EXEC_BTN
			// 
			this.EXEC_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EXEC_BTN.Location = new System.Drawing.Point(12, 134);
			this.EXEC_BTN.Name = "EXEC_BTN";
			this.EXEC_BTN.Size = new System.Drawing.Size(87, 23);
			this.EXEC_BTN.TabIndex = 4;
			this.EXEC_BTN.Text = "EXECUTAR";
			this.EXEC_BTN.UseVisualStyleBackColor = true;
			this.EXEC_BTN.Click += new System.EventHandler(this.EXEC_BTNClick);
			// 
			// Main_Timer
			// 
			this.Main_Timer.Enabled = true;
			this.Main_Timer.Interval = 500;
			this.Main_Timer.Tick += new System.EventHandler(this.Main_TimerTick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 168);
			this.Controls.Add(this.EXEC_BTN);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.MainProgressBar);
			this.Name = "MainForm";
			this.Text = "QuasarCare - Automação de Manutenção preventiva";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer Main_Timer;
		private System.Windows.Forms.Button EXEC_BTN;
		private System.Windows.Forms.CheckBox CLEARTEMP;
		private System.Windows.Forms.CheckBox FLUSHDNS;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox DEFRAG;
		private System.Windows.Forms.ProgressBar MainProgressBar;
	}
}
