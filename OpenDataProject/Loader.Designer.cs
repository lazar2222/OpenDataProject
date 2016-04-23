﻿namespace OpenDataProject
{
    partial class OpenDataProject_Loader
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Filter = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Ptable = new System.Windows.Forms.Button();
            this.Pchart = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(259, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 0;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(13, 43);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(259, 23);
            this.Filter.TabIndex = 1;
            this.Filter.Text = "Filter";
            this.Filter.UseVisualStyleBackColor = true;
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(12, 72);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(260, 23);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "Sort";
            this.Sort.UseVisualStyleBackColor = true;
            // 
            // Ptable
            // 
            this.Ptable.Location = new System.Drawing.Point(12, 102);
            this.Ptable.Name = "Ptable";
            this.Ptable.Size = new System.Drawing.Size(260, 23);
            this.Ptable.TabIndex = 3;
            this.Ptable.Text = "Pivot Table";
            this.Ptable.UseVisualStyleBackColor = true;
            // 
            // Pchart
            // 
            this.Pchart.Location = new System.Drawing.Point(12, 132);
            this.Pchart.Name = "Pchart";
            this.Pchart.Size = new System.Drawing.Size(260, 23);
            this.Pchart.TabIndex = 4;
            this.Pchart.Text = "Pivot Chart";
            this.Pchart.UseVisualStyleBackColor = true;
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(12, 162);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(260, 23);
            this.Map.TabIndex = 5;
            this.Map.Text = "Map";
            this.Map.UseVisualStyleBackColor = true;
            // 
            // OpenDataProject_Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 196);
            this.Controls.Add(this.Map);
            this.Controls.Add(this.Pchart);
            this.Controls.Add(this.Ptable);
            this.Controls.Add(this.Sort);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.progressBar1);
            this.Name = "OpenDataProject_Loader";
            this.Text = "OpenDataProject";
            this.Load += new System.EventHandler(this.OpenDataProject_Load);
            this.Shown += new System.EventHandler(this.OpenDataProject_Loader_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Ptable;
        private System.Windows.Forms.Button Pchart;
        private System.Windows.Forms.Button Map;
    }
}

