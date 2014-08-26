namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playpanel = new System.Windows.Forms.Panel();
            this.pauselbl = new System.Windows.Forms.Label();
            this.end = new System.Windows.Forms.Label();
            this.pointlbl = new System.Windows.Forms.Label();
            this.score_labl = new System.Windows.Forms.Label();
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.playpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // playpanel
            // 
            this.playpanel.Controls.Add(this.pauselbl);
            this.playpanel.Controls.Add(this.end);
            this.playpanel.Controls.Add(this.pointlbl);
            this.playpanel.Controls.Add(this.score_labl);
            this.playpanel.Controls.Add(this.racket);
            this.playpanel.Controls.Add(this.ball);
            this.playpanel.Location = new System.Drawing.Point(0, 24);
            this.playpanel.Name = "playpanel";
            this.playpanel.Size = new System.Drawing.Size(950, 458);
            this.playpanel.TabIndex = 0;
            // 
            // pauselbl
            // 
            this.pauselbl.AutoSize = true;
            this.pauselbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pauselbl.Location = new System.Drawing.Point(22, 81);
            this.pauselbl.Name = "pauselbl";
            this.pauselbl.Size = new System.Drawing.Size(433, 156);
            this.pauselbl.TabIndex = 5;
            this.pauselbl.Text = "Game Paused\r\n\r\nPress Space To Continue\r\nPress ESC To Quit";
            // 
            // end
            // 
            this.end.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.end.AutoSize = true;
            this.end.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.end.Location = new System.Drawing.Point(461, 81);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(322, 195);
            this.end.TabIndex = 4;
            this.end.Text = "Game Over\r\n\r\nPress F1 to restrat\r\n\r\nPress Esc to quit";
            this.end.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pointlbl
            // 
            this.pointlbl.AutoSize = true;
            this.pointlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointlbl.Location = new System.Drawing.Point(98, 9);
            this.pointlbl.Name = "pointlbl";
            this.pointlbl.Size = new System.Drawing.Size(25, 25);
            this.pointlbl.TabIndex = 3;
            this.pointlbl.Text = "0";
            // 
            // score_labl
            // 
            this.score_labl.AutoSize = true;
            this.score_labl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_labl.Location = new System.Drawing.Point(12, 9);
            this.score_labl.Name = "score_labl";
            this.score_labl.Size = new System.Drawing.Size(87, 25);
            this.score_labl.TabIndex = 2;
            this.score_labl.Text = "Score :";
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(210, 439);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(200, 20);
            this.racket.TabIndex = 1;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Orange;
            this.ball.Location = new System.Drawing.Point(103, 123);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 0;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startToolStripMenuItem.Text = "Start  (Space)";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 150;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 482);
            this.Controls.Add(this.playpanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.playpanel.ResumeLayout(false);
            this.playpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel playpanel;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label pointlbl;
        private System.Windows.Forms.Label score_labl;
        private System.Windows.Forms.Label end;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Label pauselbl;
        private System.Windows.Forms.Timer timer2;
    }
}

