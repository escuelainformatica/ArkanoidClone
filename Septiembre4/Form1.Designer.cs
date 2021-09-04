
namespace Septiembre4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "001-block.png");
            this.imageList1.Images.SetKeyName(1, "002-block.png");
            this.imageList1.Images.SetKeyName(2, "003-block.png");
            this.imageList1.Images.SetKeyName(3, "004-insert coin.png");
            this.imageList1.Images.SetKeyName(4, "005-1 up.png");
            this.imageList1.Images.SetKeyName(5, "006-shield.png");
            this.imageList1.Images.SetKeyName(6, "007-shield.png");
            this.imageList1.Images.SetKeyName(7, "008-gem.png");
            this.imageList1.Images.SetKeyName(8, "009-insert coin.png");
            this.imageList1.Images.SetKeyName(9, "010-barrel.png");
            this.imageList1.Images.SetKeyName(10, "011-heart.png");
            this.imageList1.Images.SetKeyName(11, "012-star.png");
            this.imageList1.Images.SetKeyName(12, "013-treasure.png");
            this.imageList1.Images.SetKeyName(13, "014-key.png");
            this.imageList1.Images.SetKeyName(14, "015-sword.png");
            this.imageList1.Images.SetKeyName(15, "016-diamond.png");
            this.imageList1.Images.SetKeyName(16, "017-block.png");
            this.imageList1.Images.SetKeyName(17, "018-bell.png");
            this.imageList1.Images.SetKeyName(18, "019-key.png");
            this.imageList1.Images.SetKeyName(19, "020-brickwall.png");
            this.imageList1.Images.SetKeyName(20, "021-insert coin.png");
            this.imageList1.Images.SetKeyName(21, "022-trophy.png");
            this.imageList1.Images.SetKeyName(22, "023-money bag.png");
            this.imageList1.Images.SetKeyName(23, "024-potion.png");
            this.imageList1.Images.SetKeyName(24, "025-axe.png");
            this.imageList1.Images.SetKeyName(25, "026-skull.png");
            this.imageList1.Images.SetKeyName(26, "027-bomb.png");
            this.imageList1.Images.SetKeyName(27, "028-block.png");
            this.imageList1.Images.SetKeyName(28, "029-mushroom.png");
            this.imageList1.Images.SetKeyName(29, "030-tetris.png");
            this.imageList1.Images.SetKeyName(30, "031-tetris.png");
            this.imageList1.Images.SetKeyName(31, "032-tetris.png");
            this.imageList1.Images.SetKeyName(32, "033-tetris.png");
            this.imageList1.Images.SetKeyName(33, "034-tetris.png");
            this.imageList1.Images.SetKeyName(34, "035-hourglass.png");
            this.imageList1.Images.SetKeyName(35, "036-stopclock.png");
            this.imageList1.Images.SetKeyName(36, "037-stopclock.png");
            this.imageList1.Images.SetKeyName(37, "038-stopclock.png");
            this.imageList1.Images.SetKeyName(38, "039-stopclock.png");
            this.imageList1.Images.SetKeyName(39, "040-stopclock.png");
            this.imageList1.Images.SetKeyName(40, "041-level.png");
            this.imageList1.Images.SetKeyName(41, "042-castle.png");
            this.imageList1.Images.SetKeyName(42, "043-level.png");
            this.imageList1.Images.SetKeyName(43, "044-level.png");
            this.imageList1.Images.SetKeyName(44, "045-crate.png");
            this.imageList1.Images.SetKeyName(45, "046-ghost.png");
            this.imageList1.Images.SetKeyName(46, "047-ghost.png");
            this.imageList1.Images.SetKeyName(47, "048-space invaders.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(861, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(844, 494);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 83);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(935, 494);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 83);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 589);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

