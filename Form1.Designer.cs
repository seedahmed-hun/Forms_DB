namespace new_db;

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
        button = new Button();
        button1 = new Button();
        button2 = new Button();
        but_del = new Button();
        dataGridView = new DataGridView();
        textBox = new TextBox();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        label = new Label();
        label1 = new Label();
        label2 = new Label();
        ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
        SuspendLayout();
        // 
        // button
        // 
        button.Location = new Point(12, 200);
        button.Name = "button";
        button.Size = new Size(168, 34);
        button.TabIndex = 0;
        button.Text = "Exit";
        button.UseVisualStyleBackColor = true;
        button.Click += Exit_button_Click;
        //button.MouseClick += Show_button_Click;
        // 
        // button1
        // 
        button1.Location = new Point(205, 200);
        button1.Name = "button1";
        button1.Size = new Size(168, 34);
        button1.TabIndex = 1;
        button1.Text = "Show";
        button1.Click += Show_button_Click;
        // 
        // button2
        // 
        button2.Location = new Point(397, 200);
        button2.Name = "button2";
        button2.Size = new Size(168, 34);
        button2.TabIndex = 2;
        button2.Text = "Enter";
        button2.Click += Enter_button_Click;
        // 
        // but_del
        // 
        but_del.Location = new Point(450, 50);
        but_del.Name = "but_del";
        but_del.Size = new Size(130, 25);
        but_del.TabIndex = 3;
        but_del.Text = "Delete";
        but_del.Click += Delete_button;
        // 
        // dataGridView
        // 
        dataGridView.AllowUserToAddRows = false;
        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView.Location = new Point(12, 250);
        dataGridView.Name = "dataGridView";
        dataGridView.Size = new Size(550, 360);
        dataGridView.TabIndex = 10;
        dataGridView.Visible = false;
        // 
        // textBox
        // 
        textBox.Location = new Point(120, 50);
        textBox.Name = "textBox";
        textBox.Size = new Size(300, 23);
        textBox.TabIndex = 4;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(120, 90);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(300, 23);
        textBox1.TabIndex = 5;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(120, 130);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(300, 23);
        textBox2.TabIndex = 6;
        // 
        // label
        // 
        label.Location = new Point(50, 50);
        label.Name = "label";
        label.Size = new Size(100, 23);
        label.TabIndex = 7;
        label.Text = "Id :";
        // 
        // label1
        // 
        label1.Location = new Point(50, 90);
        label1.Name = "label1";
        label1.Size = new Size(100, 23);
        label1.TabIndex = 8;
        label1.Text = "F_Name :";
        // 
        // label2
        // 
        label2.Location = new Point(50, 130);
        label2.Name = "label2";
        label2.Size = new Size(100, 23);
        label2.TabIndex = 9;
        label2.Text = "L_Name :";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 247);
        Controls.Add(button);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(but_del);
        Controls.Add(textBox);
        Controls.Add(textBox1);
        Controls.Add(textBox2);
        Controls.Add(label);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(dataGridView);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }
    private System.Windows.Forms.Button button;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button but_del;
    private System.Windows.Forms.DataGridView dataGridView;
    private System.Windows.Forms.TextBox textBox;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.Label label;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    #endregion
}
