
namespace DadateJsonMsSQLServer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkedListBoxRowsDadata = new System.Windows.Forms.CheckedListBox();
            this.listBoxRows = new System.Windows.Forms.ListBox();
            this.buttonGetEmailDB = new System.Windows.Forms.Button();
            this.buttonSubmitDadata = new System.Windows.Forms.Button();
            this.buttonUpdateRows = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxRowsDadata
            // 
            this.checkedListBoxRowsDadata.FormattingEnabled = true;
            this.checkedListBoxRowsDadata.Location = new System.Drawing.Point(417, 12);
            this.checkedListBoxRowsDadata.Name = "checkedListBoxRowsDadata";
            this.checkedListBoxRowsDadata.Size = new System.Drawing.Size(363, 259);
            this.checkedListBoxRowsDadata.TabIndex = 0;
            // 
            // listBoxRows
            // 
            this.listBoxRows.FormattingEnabled = true;
            this.listBoxRows.Location = new System.Drawing.Point(12, 12);
            this.listBoxRows.Name = "listBoxRows";
            this.listBoxRows.Size = new System.Drawing.Size(361, 264);
            this.listBoxRows.TabIndex = 1;
            // 
            // buttonGetEmailDB
            // 
            this.buttonGetEmailDB.Location = new System.Drawing.Point(101, 336);
            this.buttonGetEmailDB.Name = "buttonGetEmailDB";
            this.buttonGetEmailDB.Size = new System.Drawing.Size(143, 59);
            this.buttonGetEmailDB.TabIndex = 2;
            this.buttonGetEmailDB.Text = "Получить email из БД";
            this.buttonGetEmailDB.UseVisualStyleBackColor = true;
            this.buttonGetEmailDB.Click += new System.EventHandler(this.buttonGetEmailDB_Click);
            // 
            // buttonSubmitDadata
            // 
            this.buttonSubmitDadata.Location = new System.Drawing.Point(345, 336);
            this.buttonSubmitDadata.Name = "buttonSubmitDadata";
            this.buttonSubmitDadata.Size = new System.Drawing.Size(110, 59);
            this.buttonSubmitDadata.TabIndex = 3;
            this.buttonSubmitDadata.Text = "Отправить данные в Dadata";
            this.buttonSubmitDadata.UseVisualStyleBackColor = true;
            this.buttonSubmitDadata.Click += new System.EventHandler(this.buttonSubmitDadata_Click);
            // 
            // buttonUpdateRows
            // 
            this.buttonUpdateRows.Location = new System.Drawing.Point(568, 336);
            this.buttonUpdateRows.Name = "buttonUpdateRows";
            this.buttonUpdateRows.Size = new System.Drawing.Size(143, 59);
            this.buttonUpdateRows.TabIndex = 4;
            this.buttonUpdateRows.Text = "Изменить строки в БД";
            this.buttonUpdateRows.UseVisualStyleBackColor = true;
            this.buttonUpdateRows.Click += new System.EventHandler(this.buttonUpdateRows_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonUpdateRows);
            this.Controls.Add(this.buttonSubmitDadata);
            this.Controls.Add(this.buttonGetEmailDB);
            this.Controls.Add(this.listBoxRows);
            this.Controls.Add(this.checkedListBoxRowsDadata);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxRowsDadata;
        private System.Windows.Forms.ListBox listBoxRows;
        private System.Windows.Forms.Button buttonGetEmailDB;
        private System.Windows.Forms.Button buttonSubmitDadata;
        private System.Windows.Forms.Button buttonUpdateRows;
    }
}

