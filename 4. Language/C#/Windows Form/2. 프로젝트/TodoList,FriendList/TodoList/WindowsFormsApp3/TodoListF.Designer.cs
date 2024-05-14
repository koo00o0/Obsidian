namespace WindowsFormsApp3
{
    partial class TodoListF
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
            this.label1 = new System.Windows.Forms.Label();
            this.Context = new System.Windows.Forms.TextBox();
            this.ContextInput = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTodo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 20F);
            this.label1.Location = new System.Drawing.Point(605, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Context
            // 
            this.Context.Location = new System.Drawing.Point(107, 97);
            this.Context.Name = "Context";
            this.Context.Size = new System.Drawing.Size(468, 25);
            this.Context.TabIndex = 1;
            this.Context.TextChanged += new System.EventHandler(this.Context_TextChanged);
            // 
            // ContextInput
            // 
            this.ContextInput.Location = new System.Drawing.Point(611, 99);
            this.ContextInput.Name = "ContextInput";
            this.ContextInput.Size = new System.Drawing.Size(130, 23);
            this.ContextInput.TabIndex = 2;
            this.ContextInput.Text = "입력";
            this.ContextInput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ContextInput.UseVisualStyleBackColor = true;
            this.ContextInput.Click += new System.EventHandler(this.ContextInput_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 22F);
            this.label2.Location = new System.Drawing.Point(246, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "TODOLIST";
            // 
            // listBoxTodo
            // 
            this.listBoxTodo.Font = new System.Drawing.Font("궁서체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBoxTodo.FormattingEnabled = true;
            this.listBoxTodo.ItemHeight = 20;
            this.listBoxTodo.Location = new System.Drawing.Point(107, 165);
            this.listBoxTodo.Name = "listBoxTodo";
            this.listBoxTodo.Size = new System.Drawing.Size(634, 284);
            this.listBoxTodo.TabIndex = 3;
            // 
            // TodoListF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 475);
            this.Controls.Add(this.listBoxTodo);
            this.Controls.Add(this.ContextInput);
            this.Controls.Add(this.Context);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TodoListF";
            this.Text = "TodoListcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Context;
        private System.Windows.Forms.Button ContextInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTodo;
    }
}