namespace WindowsFormsApp1
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.btnvisitas = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnuser = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnout = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.Tomato;
            this.bunifuCards1.Controls.Add(this.btnout);
            this.bunifuCards1.Controls.Add(this.btnuser);
            this.bunifuCards1.Controls.Add(this.btnvisitas);
            this.bunifuCards1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(1212, 450);
            this.bunifuCards1.TabIndex = 0;
            this.bunifuCards1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuCards1_Paint);
            // 
            // btnvisitas
            // 
            this.btnvisitas.BackColor = System.Drawing.Color.SeaGreen;
            this.btnvisitas.color = System.Drawing.Color.SeaGreen;
            this.btnvisitas.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnvisitas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnvisitas.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnvisitas.ForeColor = System.Drawing.Color.White;
            this.btnvisitas.Image = ((System.Drawing.Image)(resources.GetObject("btnvisitas.Image")));
            this.btnvisitas.ImagePosition = 20;
            this.btnvisitas.ImageZoom = 50;
            this.btnvisitas.LabelPosition = 41;
            this.btnvisitas.LabelText = "Visitas";
            this.btnvisitas.Location = new System.Drawing.Point(49, 74);
            this.btnvisitas.Margin = new System.Windows.Forms.Padding(6);
            this.btnvisitas.Name = "btnvisitas";
            this.btnvisitas.Size = new System.Drawing.Size(320, 253);
            this.btnvisitas.TabIndex = 2;
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.SeaGreen;
            this.btnuser.color = System.Drawing.Color.SeaGreen;
            this.btnuser.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnuser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnuser.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Image = ((System.Drawing.Image)(resources.GetObject("btnuser.Image")));
            this.btnuser.ImagePosition = 20;
            this.btnuser.ImageZoom = 50;
            this.btnuser.LabelPosition = 41;
            this.btnuser.LabelText = "Usuarios";
            this.btnuser.Location = new System.Drawing.Point(443, 74);
            this.btnuser.Margin = new System.Windows.Forms.Padding(6);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(320, 253);
            this.btnuser.TabIndex = 3;
            // 
            // btnout
            // 
            this.btnout.BackColor = System.Drawing.Color.SeaGreen;
            this.btnout.color = System.Drawing.Color.SeaGreen;
            this.btnout.colorActive = System.Drawing.Color.MediumSeaGreen;
            this.btnout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnout.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.btnout.ForeColor = System.Drawing.Color.White;
            this.btnout.Image = ((System.Drawing.Image)(resources.GetObject("btnout.Image")));
            this.btnout.ImagePosition = 20;
            this.btnout.ImageZoom = 50;
            this.btnout.LabelPosition = 41;
            this.btnout.LabelText = "Cerrar sesion";
            this.btnout.Location = new System.Drawing.Point(840, 74);
            this.btnout.Margin = new System.Windows.Forms.Padding(6);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(320, 253);
            this.btnout.TabIndex = 4;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.bunifuCards1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.Text = "Menu";
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuTileButton btnvisitas;
        private Bunifu.Framework.UI.BunifuTileButton btnout;
        private Bunifu.Framework.UI.BunifuTileButton btnuser;
    }
}