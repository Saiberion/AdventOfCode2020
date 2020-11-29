﻿
namespace Solver_UI
{
    partial class SolverUI
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.labelCaptionSolutionPart1 = new System.Windows.Forms.Label();
            this.labelCaptionSolutionPart2 = new System.Windows.Forms.Label();
            this.labelCaptionRuntime = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelMain.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelMain.ColumnCount = 4;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanelMain.Controls.Add(this.labelCaptionSolutionPart1, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelCaptionSolutionPart2, 2, 0);
            this.tableLayoutPanelMain.Controls.Add(this.labelCaptionRuntime, 3, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(460, 220);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // labelCaptionSolutionPart1
            // 
            this.labelCaptionSolutionPart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaptionSolutionPart1.AutoSize = true;
            this.labelCaptionSolutionPart1.Location = new System.Drawing.Point(119, 103);
            this.labelCaptionSolutionPart1.Name = "labelCaptionSolutionPart1";
            this.labelCaptionSolutionPart1.Size = new System.Drawing.Size(76, 13);
            this.labelCaptionSolutionPart1.TabIndex = 0;
            this.labelCaptionSolutionPart1.Text = "Solution Part 1";
            // 
            // labelCaptionSolutionPart2
            // 
            this.labelCaptionSolutionPart2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaptionSolutionPart2.AutoSize = true;
            this.labelCaptionSolutionPart2.Location = new System.Drawing.Point(220, 103);
            this.labelCaptionSolutionPart2.Name = "labelCaptionSolutionPart2";
            this.labelCaptionSolutionPart2.Size = new System.Drawing.Size(76, 13);
            this.labelCaptionSolutionPart2.TabIndex = 1;
            this.labelCaptionSolutionPart2.Text = "Solution Part 2";
            // 
            // labelCaptionRuntime
            // 
            this.labelCaptionRuntime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelCaptionRuntime.AutoSize = true;
            this.labelCaptionRuntime.Location = new System.Drawing.Point(348, 103);
            this.labelCaptionRuntime.Name = "labelCaptionRuntime";
            this.labelCaptionRuntime.Size = new System.Drawing.Size(69, 13);
            this.labelCaptionRuntime.TabIndex = 2;
            this.labelCaptionRuntime.Text = "Durchlaufzeit";
            // 
            // SolverUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(460, 220);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "SolverUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advent of Code Solver UI 2020";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Label labelCaptionSolutionPart1;
        private System.Windows.Forms.Label labelCaptionSolutionPart2;
        private System.Windows.Forms.Label labelCaptionRuntime;
    }
}

