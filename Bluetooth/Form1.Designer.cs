﻿namespace Bluetooth
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.AirPods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AirPods
            // 
            this.AirPods.Location = new System.Drawing.Point(53, 25);
            this.AirPods.Name = "AirPods";
            this.AirPods.Size = new System.Drawing.Size(120, 25);
            this.AirPods.TabIndex = 0;
            this.AirPods.Text = "AirPodsにどーん";
            this.AirPods.UseVisualStyleBackColor = true;
            this.AirPods.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 115);
            this.Controls.Add(this.AirPods);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AirPods;
    }
}

