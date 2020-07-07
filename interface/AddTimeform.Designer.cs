namespace ManagerForm
{
    partial class AddTimeform
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
            this.cbbCustomer = new System.Windows.Forms.ComboBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbbTime = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnExecution = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbbCustomer
            // 
            this.cbbCustomer.DataSource = this.customerBindingSource;
            this.cbbCustomer.DisplayMember = "LoginID";
            this.cbbCustomer.FormattingEnabled = true;
            this.cbbCustomer.Location = new System.Drawing.Point(12, 26);
            this.cbbCustomer.Name = "cbbCustomer";
            this.cbbCustomer.Size = new System.Drawing.Size(121, 23);
            this.cbbCustomer.TabIndex = 0;
            this.cbbCustomer.ValueMember = "CustomerID";
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(data.Customer);
            // 
            // cbbTime
            // 
            this.cbbTime.DataSource = this.productBindingSource;
            this.cbbTime.DisplayMember = "Name";
            this.cbbTime.FormattingEnabled = true;
            this.cbbTime.Location = new System.Drawing.Point(168, 26);
            this.cbbTime.Name = "cbbTime";
            this.cbbTime.Size = new System.Drawing.Size(121, 23);
            this.cbbTime.TabIndex = 1;
            this.cbbTime.ValueMember = "ProductID";
            this.cbbTime.SelectedIndexChanged += new System.EventHandler(this.cbbTime_SelectedIndexChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(data.Product);
            // 
            // btnExecution
            // 
            this.btnExecution.Location = new System.Drawing.Point(49, 112);
            this.btnExecution.Name = "btnExecution";
            this.btnExecution.Size = new System.Drawing.Size(84, 35);
            this.btnExecution.TabIndex = 2;
            this.btnExecution.Text = "실행";
            this.btnExecution.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(205, 112);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddTimeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 175);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnExecution);
            this.Controls.Add(this.cbbTime);
            this.Controls.Add(this.cbbCustomer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTimeform";
            this.Text = "AddTimeform";
            this.Load += new System.EventHandler(this.AddTimeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox cbbCustomer;
    private System.Windows.Forms.ComboBox cbbTime;
    private System.Windows.Forms.BindingSource customerBindingSource;
    private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button btnExecution;
        private System.Windows.Forms.Button btnCancel;
    }
}