
namespace RohimToolBox {
  partial class frmMain {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.pnlSide = new System.Windows.Forms.Panel();
      this.btnTWSBatHelper = new System.Windows.Forms.Button();
      this.btnCheckDuplicates = new System.Windows.Forms.Button();
      this.btnDiffSets = new System.Windows.Forms.Button();
      this.pnlMain = new System.Windows.Forms.Panel();
      this.pnlSide.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlSide
      // 
      this.pnlSide.Controls.Add(this.btnTWSBatHelper);
      this.pnlSide.Controls.Add(this.btnCheckDuplicates);
      this.pnlSide.Controls.Add(this.btnDiffSets);
      this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnlSide.Location = new System.Drawing.Point(0, 0);
      this.pnlSide.Name = "pnlSide";
      this.pnlSide.Size = new System.Drawing.Size(135, 476);
      this.pnlSide.TabIndex = 1;
      // 
      // btnTWSBatHelper
      // 
      this.btnTWSBatHelper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btnTWSBatHelper.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTWSBatHelper.FlatAppearance.BorderSize = 0;
      this.btnTWSBatHelper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTWSBatHelper.Location = new System.Drawing.Point(0, 65);
      this.btnTWSBatHelper.Name = "btnTWSBatHelper";
      this.btnTWSBatHelper.Size = new System.Drawing.Size(135, 25);
      this.btnTWSBatHelper.TabIndex = 0;
      this.btnTWSBatHelper.Text = "TWSBatHelper";
      this.btnTWSBatHelper.UseVisualStyleBackColor = false;
      this.btnTWSBatHelper.Click += new System.EventHandler(this.btnTWSBatHelper_Click);
      // 
      // btnCheckDuplicates
      // 
      this.btnCheckDuplicates.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btnCheckDuplicates.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCheckDuplicates.FlatAppearance.BorderSize = 0;
      this.btnCheckDuplicates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCheckDuplicates.Location = new System.Drawing.Point(0, 34);
      this.btnCheckDuplicates.Name = "btnCheckDuplicates";
      this.btnCheckDuplicates.Size = new System.Drawing.Size(135, 25);
      this.btnCheckDuplicates.TabIndex = 0;
      this.btnCheckDuplicates.Text = "CheckDuplicates";
      this.btnCheckDuplicates.UseVisualStyleBackColor = false;
      this.btnCheckDuplicates.Click += new System.EventHandler(this.btnCheckDuplicates_Click);
      // 
      // btnDiffSets
      // 
      this.btnDiffSets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.btnDiffSets.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnDiffSets.FlatAppearance.BorderSize = 0;
      this.btnDiffSets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnDiffSets.Location = new System.Drawing.Point(0, 3);
      this.btnDiffSets.Name = "btnDiffSets";
      this.btnDiffSets.Size = new System.Drawing.Size(135, 25);
      this.btnDiffSets.TabIndex = 0;
      this.btnDiffSets.Text = "DiffSets";
      this.btnDiffSets.UseVisualStyleBackColor = false;
      this.btnDiffSets.Click += new System.EventHandler(this.btnDiffSets_Click);
      // 
      // pnlMain
      // 
      this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlMain.Location = new System.Drawing.Point(135, 0);
      this.pnlMain.Name = "pnlMain";
      this.pnlMain.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
      this.pnlMain.Size = new System.Drawing.Size(849, 476);
      this.pnlMain.TabIndex = 2;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(984, 476);
      this.Controls.Add(this.pnlMain);
      this.Controls.Add(this.pnlSide);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
      this.Name = "frmMain";
      this.Text = "RohimToolBox";
      this.pnlSide.ResumeLayout(false);
      this.ResumeLayout(false);

    }

        #endregion
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDiffSets;
        private System.Windows.Forms.Button btnCheckDuplicates;
        private System.Windows.Forms.Button btnTWSBatHelper;
    }
}

