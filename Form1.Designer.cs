namespace FormGraph
{
    partial class frmElViajero
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
            this.pnlGraph = new System.Windows.Forms.Panel();
            this.lbxGraph = new System.Windows.Forms.ListBox();
            this.pbxCity = new System.Windows.Forms.PictureBox();
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.lblDistance = new System.Windows.Forms.Label();
            this.btnGetDistance = new System.Windows.Forms.Button();
            this.lblDistanceIs = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.cbxEnd = new System.Windows.Forms.ComboBox();
            this.cbxStart = new System.Windows.Forms.ComboBox();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDistanceBetweenNodes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cbxSource = new System.Windows.Forms.ComboBox();
            this.cbxDestination = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNodeName = new System.Windows.Forms.TextBox();
            this.lblNodeName = new System.Windows.Forms.Label();
            this.lblNewNode = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlGraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCity)).BeginInit();
            this.pnlToolbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGraph
            // 
            this.pnlGraph.Controls.Add(this.lbxGraph);
            this.pnlGraph.Controls.Add(this.pbxCity);
            this.pnlGraph.Location = new System.Drawing.Point(187, 12);
            this.pnlGraph.Name = "pnlGraph";
            this.pnlGraph.Size = new System.Drawing.Size(601, 568);
            this.pnlGraph.TabIndex = 0;
            // 
            // lbxGraph
            // 
            this.lbxGraph.FormattingEnabled = true;
            this.lbxGraph.ItemHeight = 16;
            this.lbxGraph.Location = new System.Drawing.Point(105, 152);
            this.lbxGraph.Name = "lbxGraph";
            this.lbxGraph.Size = new System.Drawing.Size(403, 340);
            this.lbxGraph.TabIndex = 1;
            // 
            // pbxCity
            // 
            this.pbxCity.Location = new System.Drawing.Point(158, 103);
            this.pbxCity.Name = "pbxCity";
            this.pbxCity.Size = new System.Drawing.Size(287, 248);
            this.pbxCity.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCity.TabIndex = 0;
            this.pbxCity.TabStop = false;
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.Controls.Add(this.lblDistance);
            this.pnlToolbox.Controls.Add(this.btnGetDistance);
            this.pnlToolbox.Controls.Add(this.lblDistanceIs);
            this.pnlToolbox.Controls.Add(this.lblDestination);
            this.pnlToolbox.Controls.Add(this.cbxEnd);
            this.pnlToolbox.Controls.Add(this.cbxStart);
            this.pnlToolbox.Controls.Add(this.lblSource);
            this.pnlToolbox.Controls.Add(this.lblDistanceBetweenNodes);
            this.pnlToolbox.Controls.Add(this.label4);
            this.pnlToolbox.Controls.Add(this.label3);
            this.pnlToolbox.Controls.Add(this.btnConnect);
            this.pnlToolbox.Controls.Add(this.cbxSource);
            this.pnlToolbox.Controls.Add(this.cbxDestination);
            this.pnlToolbox.Controls.Add(this.label2);
            this.pnlToolbox.Controls.Add(this.label1);
            this.pnlToolbox.Controls.Add(this.txtNodeName);
            this.pnlToolbox.Controls.Add(this.lblNodeName);
            this.pnlToolbox.Controls.Add(this.lblNewNode);
            this.pnlToolbox.Controls.Add(this.btnAdd);
            this.pnlToolbox.Location = new System.Drawing.Point(4, 12);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(177, 568);
            this.pnlToolbox.TabIndex = 1;
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(90, 495);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(0, 17);
            this.lblDistance.TabIndex = 19;
            // 
            // btnGetDistance
            // 
            this.btnGetDistance.Location = new System.Drawing.Point(3, 515);
            this.btnGetDistance.Name = "btnGetDistance";
            this.btnGetDistance.Size = new System.Drawing.Size(149, 35);
            this.btnGetDistance.TabIndex = 18;
            this.btnGetDistance.Text = "Get Distance";
            this.btnGetDistance.UseVisualStyleBackColor = true;
            this.btnGetDistance.Click += new System.EventHandler(this.BtnGetDistance_Click);
            // 
            // lblDistanceIs
            // 
            this.lblDistanceIs.AutoSize = true;
            this.lblDistanceIs.Location = new System.Drawing.Point(3, 495);
            this.lblDistanceIs.Name = "lblDistanceIs";
            this.lblDistanceIs.Size = new System.Drawing.Size(81, 17);
            this.lblDistanceIs.TabIndex = 17;
            this.lblDistanceIs.Text = "Distance Is:";
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(3, 448);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(79, 17);
            this.lblDestination.TabIndex = 16;
            this.lblDestination.Text = "Destination";
            // 
            // cbxEnd
            // 
            this.cbxEnd.FormattingEnabled = true;
            this.cbxEnd.Location = new System.Drawing.Point(0, 468);
            this.cbxEnd.Name = "cbxEnd";
            this.cbxEnd.Size = new System.Drawing.Size(138, 24);
            this.cbxEnd.TabIndex = 15;
            // 
            // cbxStart
            // 
            this.cbxStart.FormattingEnabled = true;
            this.cbxStart.Location = new System.Drawing.Point(3, 421);
            this.cbxStart.Name = "cbxStart";
            this.cbxStart.Size = new System.Drawing.Size(135, 24);
            this.cbxStart.TabIndex = 14;
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(3, 401);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(53, 17);
            this.lblSource.TabIndex = 13;
            this.lblSource.Text = "Source";
            // 
            // lblDistanceBetweenNodes
            // 
            this.lblDistanceBetweenNodes.AutoSize = true;
            this.lblDistanceBetweenNodes.Location = new System.Drawing.Point(3, 384);
            this.lblDistanceBetweenNodes.Name = "lblDistanceBetweenNodes";
            this.lblDistanceBetweenNodes.Size = new System.Drawing.Size(166, 17);
            this.lblDistanceBetweenNodes.TabIndex = 12;
            this.lblDistanceBetweenNodes.Text = "Distance Between Nodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Connect Nodes";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 278);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(131, 33);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // cbxSource
            // 
            this.cbxSource.FormattingEnabled = true;
            this.cbxSource.Location = new System.Drawing.Point(8, 190);
            this.cbxSource.Name = "cbxSource";
            this.cbxSource.Size = new System.Drawing.Size(135, 24);
            this.cbxSource.TabIndex = 8;
            // 
            // cbxDestination
            // 
            this.cbxDestination.FormattingEnabled = true;
            this.cbxDestination.Location = new System.Drawing.Point(8, 248);
            this.cbxDestination.Name = "cbxDestination";
            this.cbxDestination.Size = new System.Drawing.Size(140, 24);
            this.cbxDestination.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Destination";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // txtNodeName
            // 
            this.txtNodeName.Location = new System.Drawing.Point(8, 55);
            this.txtNodeName.Name = "txtNodeName";
            this.txtNodeName.Size = new System.Drawing.Size(135, 22);
            this.txtNodeName.TabIndex = 3;
            // 
            // lblNodeName
            // 
            this.lblNodeName.AutoSize = true;
            this.lblNodeName.Location = new System.Drawing.Point(8, 35);
            this.lblNodeName.Name = "lblNodeName";
            this.lblNodeName.Size = new System.Drawing.Size(83, 17);
            this.lblNodeName.TabIndex = 2;
            this.lblNodeName.Text = "Node Name";
            // 
            // lblNewNode
            // 
            this.lblNewNode.AutoSize = true;
            this.lblNewNode.Location = new System.Drawing.Point(8, 18);
            this.lblNewNode.Name = "lblNewNode";
            this.lblNewNode.Size = new System.Drawing.Size(69, 17);
            this.lblNewNode.TabIndex = 1;
            this.lblNewNode.Text = "NewNode";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 83);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 26);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // frmElViajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.pnlToolbox);
            this.Controls.Add(this.pnlGraph);
            this.Name = "frmElViajero";
            this.Text = "El Viajero";
            this.pnlGraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxCity)).EndInit();
            this.pnlToolbox.ResumeLayout(false);
            this.pnlToolbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlGraph;
        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.TextBox txtNodeName;
        private System.Windows.Forms.Label lblNodeName;
        private System.Windows.Forms.Label lblNewNode;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox cbxSource;
        private System.Windows.Forms.ComboBox cbxDestination;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGetDistance;
        private System.Windows.Forms.Label lblDistanceIs;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.ComboBox cbxEnd;
        private System.Windows.Forms.ComboBox cbxStart;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDistanceBetweenNodes;
        private System.Windows.Forms.PictureBox pbxCity;
        private System.Windows.Forms.ListBox lbxGraph;
        private System.Windows.Forms.Label lblDistance;
    }
}

