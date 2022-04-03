
namespace Maze_Generation_3
{
    partial class MazeGeneration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MazeGeneration));
            this.textboxLength = new System.Windows.Forms.TextBox();
            this.textboxHeight = new System.Windows.Forms.TextBox();
            this.textboxXStart = new System.Windows.Forms.TextBox();
            this.textboxYStart = new System.Windows.Forms.TextBox();
            this.textboxXEnd = new System.Windows.Forms.TextBox();
            this.textboxYEnd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.radioButtonRecursiveBacktracker = new System.Windows.Forms.RadioButton();
            this.radioButtonHuntAndKill = new System.Windows.Forms.RadioButton();
            this.radioButtonPrims = new System.Windows.Forms.RadioButton();
            this.radioButtonBinaryTree = new System.Windows.Forms.RadioButton();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelXStart = new System.Windows.Forms.Label();
            this.labelYStart = new System.Windows.Forms.Label();
            this.labelXEnd = new System.Windows.Forms.Label();
            this.labelYEnd = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.pictureBoxMazeRender = new System.Windows.Forms.PictureBox();
            this.BinaryTreeToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RecursiveToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazeRender)).BeginInit();
            this.SuspendLayout();
            // 
            // textboxLength
            // 
            this.textboxLength.Location = new System.Drawing.Point(18, 37);
            this.textboxLength.Name = "textboxLength";
            this.textboxLength.Size = new System.Drawing.Size(114, 20);
            this.textboxLength.TabIndex = 0;
            this.textboxLength.Text = "10";
            // 
            // textboxHeight
            // 
            this.textboxHeight.Location = new System.Drawing.Point(166, 37);
            this.textboxHeight.Name = "textboxHeight";
            this.textboxHeight.Size = new System.Drawing.Size(114, 20);
            this.textboxHeight.TabIndex = 1;
            this.textboxHeight.Text = "10";
            // 
            // textboxXStart
            // 
            this.textboxXStart.Location = new System.Drawing.Point(18, 82);
            this.textboxXStart.Name = "textboxXStart";
            this.textboxXStart.Size = new System.Drawing.Size(114, 20);
            this.textboxXStart.TabIndex = 2;
            this.textboxXStart.Text = "1";
            // 
            // textboxYStart
            // 
            this.textboxYStart.Location = new System.Drawing.Point(166, 82);
            this.textboxYStart.Name = "textboxYStart";
            this.textboxYStart.Size = new System.Drawing.Size(114, 20);
            this.textboxYStart.TabIndex = 3;
            this.textboxYStart.Text = "1";
            // 
            // textboxXEnd
            // 
            this.textboxXEnd.Location = new System.Drawing.Point(20, 359);
            this.textboxXEnd.Name = "textboxXEnd";
            this.textboxXEnd.Size = new System.Drawing.Size(114, 20);
            this.textboxXEnd.TabIndex = 4;
            this.textboxXEnd.Visible = false;
            // 
            // textboxYEnd
            // 
            this.textboxYEnd.Location = new System.Drawing.Point(148, 359);
            this.textboxYEnd.Name = "textboxYEnd";
            this.textboxYEnd.Size = new System.Drawing.Size(114, 20);
            this.textboxYEnd.TabIndex = 5;
            this.textboxYEnd.Visible = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // radioButtonRecursiveBacktracker
            // 
            this.radioButtonRecursiveBacktracker.AutoSize = true;
            this.radioButtonRecursiveBacktracker.Location = new System.Drawing.Point(18, 187);
            this.radioButtonRecursiveBacktracker.Name = "radioButtonRecursiveBacktracker";
            this.radioButtonRecursiveBacktracker.Size = new System.Drawing.Size(134, 17);
            this.radioButtonRecursiveBacktracker.TabIndex = 7;
            this.radioButtonRecursiveBacktracker.TabStop = true;
            this.radioButtonRecursiveBacktracker.Text = "Recursive Backtracker";
            this.RecursiveToolTip.SetToolTip(this.radioButtonRecursiveBacktracker, resources.GetString("radioButtonRecursiveBacktracker.ToolTip"));
            this.radioButtonRecursiveBacktracker.UseVisualStyleBackColor = true;
            // 
            // radioButtonHuntAndKill
            // 
            this.radioButtonHuntAndKill.AutoSize = true;
            this.radioButtonHuntAndKill.Location = new System.Drawing.Point(148, 395);
            this.radioButtonHuntAndKill.Name = "radioButtonHuntAndKill";
            this.radioButtonHuntAndKill.Size = new System.Drawing.Size(132, 17);
            this.radioButtonHuntAndKill.TabIndex = 8;
            this.radioButtonHuntAndKill.TabStop = true;
            this.radioButtonHuntAndKill.Text = "Hunt And Kill Algorithm";
            this.radioButtonHuntAndKill.UseVisualStyleBackColor = true;
            this.radioButtonHuntAndKill.Visible = false;
            // 
            // radioButtonPrims
            // 
            this.radioButtonPrims.AutoSize = true;
            this.radioButtonPrims.Location = new System.Drawing.Point(18, 395);
            this.radioButtonPrims.Name = "radioButtonPrims";
            this.radioButtonPrims.Size = new System.Drawing.Size(98, 17);
            this.radioButtonPrims.TabIndex = 9;
            this.radioButtonPrims.TabStop = true;
            this.radioButtonPrims.Text = "Prim\'s Algorithm";
            this.radioButtonPrims.UseVisualStyleBackColor = true;
            this.radioButtonPrims.Visible = false;
            // 
            // radioButtonBinaryTree
            // 
            this.radioButtonBinaryTree.AutoSize = true;
            this.radioButtonBinaryTree.Location = new System.Drawing.Point(20, 154);
            this.radioButtonBinaryTree.Name = "radioButtonBinaryTree";
            this.radioButtonBinaryTree.Size = new System.Drawing.Size(125, 17);
            this.radioButtonBinaryTree.TabIndex = 10;
            this.radioButtonBinaryTree.TabStop = true;
            this.radioButtonBinaryTree.Text = "Binary Tree Algorithm";
            this.BinaryTreeToolTip.SetToolTip(this.radioButtonBinaryTree, resources.GetString("radioButtonBinaryTree.ToolTip"));
            this.radioButtonBinaryTree.UseVisualStyleBackColor = true;
            // 
            // labelLength
            // 
            this.labelLength.AutoSize = true;
            this.labelLength.Location = new System.Drawing.Point(15, 21);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(43, 13);
            this.labelLength.TabIndex = 11;
            this.labelLength.Text = "Length:";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(163, 21);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(41, 13);
            this.labelHeight.TabIndex = 12;
            this.labelHeight.Text = "Height:";
            // 
            // labelXStart
            // 
            this.labelXStart.AutoSize = true;
            this.labelXStart.Location = new System.Drawing.Point(15, 66);
            this.labelXStart.Name = "labelXStart";
            this.labelXStart.Size = new System.Drawing.Size(79, 13);
            this.labelXStart.TabIndex = 13;
            this.labelXStart.Text = "X start position:";
            // 
            // labelYStart
            // 
            this.labelYStart.AutoSize = true;
            this.labelYStart.Location = new System.Drawing.Point(163, 66);
            this.labelYStart.Name = "labelYStart";
            this.labelYStart.Size = new System.Drawing.Size(79, 13);
            this.labelYStart.TabIndex = 14;
            this.labelYStart.Text = "Y start position:";
            // 
            // labelXEnd
            // 
            this.labelXEnd.AutoSize = true;
            this.labelXEnd.Location = new System.Drawing.Point(17, 343);
            this.labelXEnd.Name = "labelXEnd";
            this.labelXEnd.Size = new System.Drawing.Size(77, 13);
            this.labelXEnd.TabIndex = 15;
            this.labelXEnd.Text = "X end position:";
            this.labelXEnd.Visible = false;
            // 
            // labelYEnd
            // 
            this.labelYEnd.AutoSize = true;
            this.labelYEnd.Location = new System.Drawing.Point(145, 343);
            this.labelYEnd.Name = "labelYEnd";
            this.labelYEnd.Size = new System.Drawing.Size(77, 13);
            this.labelYEnd.TabIndex = 16;
            this.labelYEnd.Text = "Y end position:";
            this.labelYEnd.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Algorithms:";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(92, 227);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(101, 49);
            this.buttonGenerate.TabIndex = 18;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // pictureBoxMazeRender
            // 
            this.pictureBoxMazeRender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMazeRender.Location = new System.Drawing.Point(294, 12);
            this.pictureBoxMazeRender.Name = "pictureBoxMazeRender";
            this.pictureBoxMazeRender.Size = new System.Drawing.Size(400, 400);
            this.pictureBoxMazeRender.TabIndex = 19;
            this.pictureBoxMazeRender.TabStop = false;
            this.pictureBoxMazeRender.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxMazePaint);
            // 
            // MazeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 431);
            this.Controls.Add(this.pictureBoxMazeRender);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelYEnd);
            this.Controls.Add(this.labelXEnd);
            this.Controls.Add(this.labelYStart);
            this.Controls.Add(this.labelXStart);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.radioButtonBinaryTree);
            this.Controls.Add(this.radioButtonPrims);
            this.Controls.Add(this.radioButtonHuntAndKill);
            this.Controls.Add(this.radioButtonRecursiveBacktracker);
            this.Controls.Add(this.textboxYEnd);
            this.Controls.Add(this.textboxXEnd);
            this.Controls.Add(this.textboxYStart);
            this.Controls.Add(this.textboxXStart);
            this.Controls.Add(this.textboxHeight);
            this.Controls.Add(this.textboxLength);
            this.Name = "MazeGeneration";
            this.Text = "Maze Generation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMazeRender)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelXStart;
        private System.Windows.Forms.Label labelYStart;
        private System.Windows.Forms.Label labelXEnd;
        private System.Windows.Forms.Label labelYEnd;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox textboxLength;
        public System.Windows.Forms.TextBox textboxHeight;
        public System.Windows.Forms.TextBox textboxXStart;
        public System.Windows.Forms.TextBox textboxYStart;
        public System.Windows.Forms.TextBox textboxXEnd;
        public System.Windows.Forms.TextBox textboxYEnd;
        public System.Windows.Forms.RadioButton radioButtonRecursiveBacktracker;
        public System.Windows.Forms.RadioButton radioButtonHuntAndKill;
        public System.Windows.Forms.RadioButton radioButtonPrims;
        public System.Windows.Forms.RadioButton radioButtonBinaryTree;
        public System.Windows.Forms.PictureBox pictureBoxMazeRender;
        public System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.ToolTip BinaryTreeToolTip;
        private System.Windows.Forms.ToolTip RecursiveToolTip;
    }
}

