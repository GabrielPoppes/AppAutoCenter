
namespace AppAutoCenter.View.Loading
{
    partial class FrmLoadingApp
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
            this.components = new System.ComponentModel.Container();
            this.PanelConectando = new System.Windows.Forms.Panel();
            this.PanelAutoCenter = new System.Windows.Forms.Panel();
            this.LblAbrirApp = new System.Windows.Forms.Label();
            this.LblConectando = new System.Windows.Forms.Label();
            this.PicCar = new System.Windows.Forms.PictureBox();
            this.LblAutoCenter = new System.Windows.Forms.Label();
            this.PicAutoCenter = new System.Windows.Forms.PictureBox();
            this.TimerLoading = new System.Windows.Forms.Timer(this.components);
            this.PanelConectando.SuspendLayout();
            this.PanelAutoCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAutoCenter)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelConectando
            // 
            this.PanelConectando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.PanelConectando.Controls.Add(this.LblAbrirApp);
            this.PanelConectando.Controls.Add(this.LblConectando);
            this.PanelConectando.Controls.Add(this.PicCar);
            this.PanelConectando.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelConectando.Location = new System.Drawing.Point(0, 186);
            this.PanelConectando.Name = "PanelConectando";
            this.PanelConectando.Size = new System.Drawing.Size(784, 225);
            this.PanelConectando.TabIndex = 0;
            // 
            // PanelAutoCenter
            // 
            this.PanelAutoCenter.Controls.Add(this.LblAutoCenter);
            this.PanelAutoCenter.Controls.Add(this.PicAutoCenter);
            this.PanelAutoCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelAutoCenter.Location = new System.Drawing.Point(0, 0);
            this.PanelAutoCenter.Name = "PanelAutoCenter";
            this.PanelAutoCenter.Size = new System.Drawing.Size(784, 186);
            this.PanelAutoCenter.TabIndex = 1;
            // 
            // LblAbrirApp
            // 
            this.LblAbrirApp.AutoSize = true;
            this.LblAbrirApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LblAbrirApp.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAbrirApp.ForeColor = System.Drawing.Color.White;
            this.LblAbrirApp.Location = new System.Drawing.Point(347, 209);
            this.LblAbrirApp.Name = "LblAbrirApp";
            this.LblAbrirApp.Size = new System.Drawing.Size(101, 19);
            this.LblAbrirApp.TabIndex = 5;
            this.LblAbrirApp.Text = "Abrir aplicativo";
            // 
            // LblConectando
            // 
            this.LblConectando.AutoSize = true;
            this.LblConectando.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConectando.ForeColor = System.Drawing.Color.White;
            this.LblConectando.Location = new System.Drawing.Point(343, 4);
            this.LblConectando.Name = "LblConectando";
            this.LblConectando.Size = new System.Drawing.Size(93, 19);
            this.LblConectando.TabIndex = 3;
            this.LblConectando.Text = "Conectando...";
            // 
            // PicCar
            // 
            this.PicCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCar.Image = global::AppAutoCenter.Properties.Resources._1988884_car_front_vehicle_icon;
            this.PicCar.Location = new System.Drawing.Point(274, 26);
            this.PicCar.Name = "PicCar";
            this.PicCar.Size = new System.Drawing.Size(256, 256);
            this.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicCar.TabIndex = 4;
            this.PicCar.TabStop = false;
            // 
            // LblAutoCenter
            // 
            this.LblAutoCenter.AutoSize = true;
            this.LblAutoCenter.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAutoCenter.ForeColor = System.Drawing.Color.Black;
            this.LblAutoCenter.Location = new System.Drawing.Point(359, 143);
            this.LblAutoCenter.Name = "LblAutoCenter";
            this.LblAutoCenter.Size = new System.Drawing.Size(84, 19);
            this.LblAutoCenter.TabIndex = 7;
            this.LblAutoCenter.Text = "Auto Center";
            // 
            // PicAutoCenter
            // 
            this.PicAutoCenter.Image = global::AppAutoCenter.Properties.Resources._4118381_car_controller_part_steering_wheel_icon;
            this.PicAutoCenter.Location = new System.Drawing.Point(334, 12);
            this.PicAutoCenter.Name = "PicAutoCenter";
            this.PicAutoCenter.Size = new System.Drawing.Size(128, 128);
            this.PicAutoCenter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicAutoCenter.TabIndex = 6;
            this.PicAutoCenter.TabStop = false;
            // 
            // TimerLoading
            // 
            this.TimerLoading.Enabled = true;
            this.TimerLoading.Interval = 10;
            this.TimerLoading.Tick += new System.EventHandler(this.TimerLoading_Tick);
            // 
            // FrmLoadingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.PanelAutoCenter);
            this.Controls.Add(this.PanelConectando);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoadingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLoadingApp";
            this.Load += new System.EventHandler(this.FrmLoadingApp_Load);
            this.PanelConectando.ResumeLayout(false);
            this.PanelConectando.PerformLayout();
            this.PanelAutoCenter.ResumeLayout(false);
            this.PanelAutoCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicAutoCenter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelConectando;
        private System.Windows.Forms.Panel PanelAutoCenter;
        private System.Windows.Forms.Label LblAbrirApp;
        private System.Windows.Forms.Label LblConectando;
        private System.Windows.Forms.PictureBox PicCar;
        private System.Windows.Forms.Label LblAutoCenter;
        private System.Windows.Forms.PictureBox PicAutoCenter;
        private System.Windows.Forms.Timer TimerLoading;
    }
}