namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            player2Input = new ComboBox();
            player1Input = new ComboBox();
            Done_Game = new Button();
            Poz0_0 = new ComboBox();
            Poz1_0 = new ComboBox();
            Poz2_0 = new ComboBox();
            Poz0_1 = new ComboBox();
            Poz0_2 = new ComboBox();
            Poz1_1 = new ComboBox();
            Poz2_1 = new ComboBox();
            Poz1_2 = new ComboBox();
            Poz2_2 = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(95, 15);
            label1.TabIndex = 0;
            label1.Text = "Player 1: (X or O)";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 80);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 12;
            label2.Text = "Player 2:(X or O)";
            // 
            // player2Input
            // 
            player2Input.FormattingEnabled = true;
            player2Input.Items.AddRange(new object[] { "X", "O" });
            player2Input.Location = new Point(119, 77);
            player2Input.Name = "player2Input";
            player2Input.Size = new Size(81, 23);
            player2Input.TabIndex = 13;
            player2Input.SelectedIndexChanged += player2Input_SelectedIndexChanged;
            // 
            // player1Input
            // 
            player1Input.FormattingEnabled = true;
            player1Input.Items.AddRange(new object[] { "X", "O" });
            player1Input.Location = new Point(119, 37);
            player1Input.Name = "player1Input";
            player1Input.Size = new Size(81, 23);
            player1Input.TabIndex = 14;
            player1Input.SelectedIndexChanged += player1Input_SelectedIndexChanged;
            player1Input.MouseClick += EnterButton_MouseClick;
            // 
            // Done_Game
            // 
            Done_Game.Location = new Point(179, 259);
            Done_Game.Name = "Done_Game";
            Done_Game.Size = new Size(96, 23);
            Done_Game.TabIndex = 15;
            Done_Game.Text = "Done_Game";
            Done_Game.UseVisualStyleBackColor = true;
            Done_Game.MouseClick += Done_Game_MouseClick;
            // 
            // Poz0_0
            // 
            Poz0_0.FormattingEnabled = true;
            Poz0_0.Items.AddRange(new object[] { "X", "O" });
            Poz0_0.Location = new Point(249, 37);
            Poz0_0.Name = "Poz0_0";
            Poz0_0.Size = new Size(58, 23);
            Poz0_0.TabIndex = 16;
            Poz0_0.SelectedIndexChanged += Poz0_0_SelectedIndexChanged;
            // 
            // Poz1_0
            // 
            Poz1_0.FormattingEnabled = true;
            Poz1_0.Items.AddRange(new object[] { "X", "O" });
            Poz1_0.Location = new Point(249, 80);
            Poz1_0.Name = "Poz1_0";
            Poz1_0.Size = new Size(58, 23);
            Poz1_0.TabIndex = 17;
            Poz1_0.SelectedIndexChanged += Poz1_1_SelectedIndexChanged;
            // 
            // Poz2_0
            // 
            Poz2_0.FormattingEnabled = true;
            Poz2_0.Items.AddRange(new object[] { "X", "O" });
            Poz2_0.Location = new Point(249, 122);
            Poz2_0.Name = "Poz2_0";
            Poz2_0.Size = new Size(58, 23);
            Poz2_0.TabIndex = 18;
            Poz2_0.SelectedIndexChanged += Poz2_0_SelectedIndexChanged;
            // 
            // Poz0_1
            // 
            Poz0_1.FormattingEnabled = true;
            Poz0_1.Items.AddRange(new object[] { "X", "O" });
            Poz0_1.Location = new Point(322, 37);
            Poz0_1.Name = "Poz0_1";
            Poz0_1.Size = new Size(59, 23);
            Poz0_1.TabIndex = 19;
            Poz0_1.SelectedIndexChanged += Poz0_1_SelectedIndexChanged;
            // 
            // Poz0_2
            // 
            Poz0_2.FormattingEnabled = true;
            Poz0_2.Items.AddRange(new object[] { "X", "O" });
            Poz0_2.Location = new Point(395, 37);
            Poz0_2.Name = "Poz0_2";
            Poz0_2.Size = new Size(53, 23);
            Poz0_2.TabIndex = 20;
            Poz0_2.SelectedIndexChanged += Poz0_2_SelectedIndexChanged;
            // 
            // Poz1_1
            // 
            Poz1_1.FormattingEnabled = true;
            Poz1_1.Items.AddRange(new object[] { "X", "O" });
            Poz1_1.Location = new Point(322, 80);
            Poz1_1.Name = "Poz1_1";
            Poz1_1.Size = new Size(59, 23);
            Poz1_1.TabIndex = 21;
            Poz1_1.SelectedIndexChanged += Poz1_1_SelectedIndexChanged_1;
            // 
            // Poz2_1
            // 
            Poz2_1.FormattingEnabled = true;
            Poz2_1.Items.AddRange(new object[] { "X", "O" });
            Poz2_1.Location = new Point(322, 122);
            Poz2_1.Name = "Poz2_1";
            Poz2_1.Size = new Size(59, 23);
            Poz2_1.TabIndex = 22;
            Poz2_1.SelectedIndexChanged += Poz2_1_SelectedIndexChanged;
            // 
            // Poz1_2
            // 
            Poz1_2.FormattingEnabled = true;
            Poz1_2.Items.AddRange(new object[] { "X", "O" });
            Poz1_2.Location = new Point(395, 80);
            Poz1_2.Name = "Poz1_2";
            Poz1_2.Size = new Size(53, 23);
            Poz1_2.TabIndex = 23;
            Poz1_2.SelectedIndexChanged += Poz1_2_SelectedIndexChanged;
            // 
            // Poz2_2
            // 
            Poz2_2.FormattingEnabled = true;
            Poz2_2.Items.AddRange(new object[] { "X", "O" });
            Poz2_2.Location = new Point(395, 122);
            Poz2_2.Name = "Poz2_2";
            Poz2_2.Size = new Size(53, 23);
            Poz2_2.TabIndex = 24;
            Poz2_2.SelectedIndexChanged += Poz2_2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(322, 9);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 25;
            label3.Text = "Game Board";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(452, 309);
            Controls.Add(label3);
            Controls.Add(Poz2_2);
            Controls.Add(Poz1_2);
            Controls.Add(Poz2_1);
            Controls.Add(Poz1_1);
            Controls.Add(Poz0_2);
            Controls.Add(Poz0_1);
            Controls.Add(Poz2_0);
            Controls.Add(Poz1_0);
            Controls.Add(Poz0_0);
            Controls.Add(Done_Game);
            Controls.Add(player1Input);
            Controls.Add(player2Input);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Tic-Tac Toe Game";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox player2Input;
        private ComboBox player1Input;
        private Button Done_Game;
        private ComboBox Poz0_0;
        private ComboBox Poz1_0;
        private ComboBox Poz2_0;
        private ComboBox Poz0_1;
        private ComboBox Poz0_2;
        private ComboBox Poz1_1;
        private ComboBox Poz2_1;
        private ComboBox Poz1_2;
        private ComboBox Poz2_2;
        private Label label3;
    }
}