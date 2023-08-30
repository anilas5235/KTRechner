namespace KTRechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dtpRentStartDateInput = new System.Windows.Forms.DateTimePicker();
            this.dtpKTPaidUntilInput = new System.Windows.Forms.DateTimePicker();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.tbxRecoverySumeOutput = new System.Windows.Forms.TextBox();
            this.lbKTPaidUntilInput = new System.Windows.Forms.Label();
            this.lbRentStartDateInput = new System.Windows.Forms.Label();
            this.lbKTPerDayInput = new System.Windows.Forms.Label();
            this.tbxKTPerDayInput = new System.Windows.Forms.TextBox();
            this.tbxRentPerMonthInput = new System.Windows.Forms.TextBox();
            this.lbRentPerMonthInput = new System.Windows.Forms.Label();
            this.tbxDifferncePerDayOutput = new System.Windows.Forms.TextBox();
            this.lbfDifferncePerDayOutput = new System.Windows.Forms.Label();
            this.lbRecoverySumme = new System.Windows.Forms.Label();
            this.tbxRentPerDayOutput = new System.Windows.Forms.TextBox();
            this.lbRentPerDayOutput = new System.Windows.Forms.Label();
            this.tbxKTPerDayOutput = new System.Windows.Forms.TextBox();
            this.lbKTperdayOutput = new System.Windows.Forms.Label();
            this.tbxOverPaidDaysOutput = new System.Windows.Forms.TextBox();
            this.lbOverPaidDaysOutput = new System.Windows.Forms.Label();
            this.tbxRequireddDaysOutput = new System.Windows.Forms.TextBox();
            this.lbRequiredDaysOutput = new System.Windows.Forms.Label();
            this.tbxRecoveryOverPaidOutput = new System.Windows.Forms.TextBox();
            this.lbRecoeryOverPaidOutput = new System.Windows.Forms.Label();
            this.tbxRequiredDaysRecoveryOutput = new System.Windows.Forms.TextBox();
            this.lbRecoveryRequereddDaysOutput = new System.Windows.Forms.Label();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.gBPutput = new System.Windows.Forms.GroupBox();
            this.lbKTended = new System.Windows.Forms.Label();
            this.dtpKTended = new System.Windows.Forms.DateTimePicker();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.gbInput.SuspendLayout();
            this.gBPutput.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpRentStartDateInput
            // 
            this.dtpRentStartDateInput.Location = new System.Drawing.Point(191, 109);
            this.dtpRentStartDateInput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dtpRentStartDateInput.Name = "dtpRentStartDateInput";
            this.dtpRentStartDateInput.Size = new System.Drawing.Size(299, 26);
            this.dtpRentStartDateInput.TabIndex = 0;
            this.dtpRentStartDateInput.ValueChanged += new System.EventHandler(this.DtpRentenEintritt_ValueChanged);
            // 
            // dtpKTPaidUntilInput
            // 
            this.dtpKTPaidUntilInput.Location = new System.Drawing.Point(191, 61);
            this.dtpKTPaidUntilInput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.dtpKTPaidUntilInput.Name = "dtpKTPaidUntilInput";
            this.dtpKTPaidUntilInput.Size = new System.Drawing.Size(299, 26);
            this.dtpKTPaidUntilInput.TabIndex = 1;
            this.dtpKTPaidUntilInput.ValueChanged += new System.EventHandler(this.DtpKTGezahltBis_ValueChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCalculate.Font = new System.Drawing.Font("Arial Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(728, 8);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(162, 75);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "GO";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // tbxRecoverySumeOutput
            // 
            this.tbxRecoverySumeOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRecoverySumeOutput.Location = new System.Drawing.Point(390, 26);
            this.tbxRecoverySumeOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRecoverySumeOutput.Name = "tbxRecoverySumeOutput";
            this.tbxRecoverySumeOutput.ReadOnly = true;
            this.tbxRecoverySumeOutput.Size = new System.Drawing.Size(292, 31);
            this.tbxRecoverySumeOutput.TabIndex = 3;
            // 
            // lbKTPaidUntilInput
            // 
            this.lbKTPaidUntilInput.AutoSize = true;
            this.lbKTPaidUntilInput.Location = new System.Drawing.Point(52, 65);
            this.lbKTPaidUntilInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKTPaidUntilInput.Name = "lbKTPaidUntilInput";
            this.lbKTPaidUntilInput.Size = new System.Drawing.Size(110, 18);
            this.lbKTPaidUntilInput.TabIndex = 4;
            this.lbKTPaidUntilInput.Text = "KT gezahlt bis";
            // 
            // lbRentStartDateInput
            // 
            this.lbRentStartDateInput.AutoSize = true;
            this.lbRentStartDateInput.Location = new System.Drawing.Point(25, 118);
            this.lbRentStartDateInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRentStartDateInput.Name = "lbRentStartDateInput";
            this.lbRentStartDateInput.Size = new System.Drawing.Size(138, 18);
            this.lbRentStartDateInput.TabIndex = 5;
            this.lbRentStartDateInput.Text = "Rente erhalten ab";
            // 
            // lbKTPerDayInput
            // 
            this.lbKTPerDayInput.AutoSize = true;
            this.lbKTPerDayInput.Location = new System.Drawing.Point(577, 65);
            this.lbKTPerDayInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKTPerDayInput.Name = "lbKTPerDayInput";
            this.lbKTPerDayInput.Size = new System.Drawing.Size(62, 18);
            this.lbKTPerDayInput.TabIndex = 6;
            this.lbKTPerDayInput.Text = "KT/Tag:";
            // 
            // tbxKTPerDayInput
            // 
            this.tbxKTPerDayInput.Location = new System.Drawing.Point(681, 65);
            this.tbxKTPerDayInput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxKTPerDayInput.Name = "tbxKTPerDayInput";
            this.tbxKTPerDayInput.Size = new System.Drawing.Size(148, 26);
            this.tbxKTPerDayInput.TabIndex = 7;
            this.tbxKTPerDayInput.TextChanged += new System.EventHandler(this.TbxKTPerDayInput_TextChanged);
            // 
            // tbxRentPerMonthInput
            // 
            this.tbxRentPerMonthInput.Location = new System.Drawing.Point(681, 106);
            this.tbxRentPerMonthInput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRentPerMonthInput.Name = "tbxRentPerMonthInput";
            this.tbxRentPerMonthInput.Size = new System.Drawing.Size(148, 26);
            this.tbxRentPerMonthInput.TabIndex = 9;
            this.tbxRentPerMonthInput.TextChanged += new System.EventHandler(this.TbxRentPerMonthInput_TextChanged);
            // 
            // lbRentPerMonthInput
            // 
            this.lbRentPerMonthInput.AutoSize = true;
            this.lbRentPerMonthInput.Location = new System.Drawing.Point(538, 109);
            this.lbRentPerMonthInput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRentPerMonthInput.Name = "lbRentPerMonthInput";
            this.lbRentPerMonthInput.Size = new System.Drawing.Size(110, 18);
            this.lbRentPerMonthInput.TabIndex = 8;
            this.lbRentPerMonthInput.Text = "Rente(Monat):";
            // 
            // tbxDifferncePerDayOutput
            // 
            this.tbxDifferncePerDayOutput.Location = new System.Drawing.Point(171, 98);
            this.tbxDifferncePerDayOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxDifferncePerDayOutput.Name = "tbxDifferncePerDayOutput";
            this.tbxDifferncePerDayOutput.ReadOnly = true;
            this.tbxDifferncePerDayOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxDifferncePerDayOutput.TabIndex = 11;
            // 
            // lbfDifferncePerDayOutput
            // 
            this.lbfDifferncePerDayOutput.AutoSize = true;
            this.lbfDifferncePerDayOutput.Location = new System.Drawing.Point(30, 102);
            this.lbfDifferncePerDayOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbfDifferncePerDayOutput.Name = "lbfDifferncePerDayOutput";
            this.lbfDifferncePerDayOutput.Size = new System.Drawing.Size(123, 18);
            this.lbfDifferncePerDayOutput.TabIndex = 10;
            this.lbfDifferncePerDayOutput.Text = "Differrnenz/Tag:";
            // 
            // lbRecoverySumme
            // 
            this.lbRecoverySumme.AutoSize = true;
            this.lbRecoverySumme.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecoverySumme.Location = new System.Drawing.Point(20, 30);
            this.lbRecoverySumme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRecoverySumme.Name = "lbRecoverySumme";
            this.lbRecoverySumme.Size = new System.Drawing.Size(295, 30);
            this.lbRecoverySumme.TabIndex = 12;
            this.lbRecoverySumme.Text = "Rückforderungs-Summe:";
            // 
            // tbxRentPerDayOutput
            // 
            this.tbxRentPerDayOutput.Location = new System.Drawing.Point(171, 62);
            this.tbxRentPerDayOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRentPerDayOutput.Name = "tbxRentPerDayOutput";
            this.tbxRentPerDayOutput.ReadOnly = true;
            this.tbxRentPerDayOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxRentPerDayOutput.TabIndex = 14;
            // 
            // lbRentPerDayOutput
            // 
            this.lbRentPerDayOutput.AutoSize = true;
            this.lbRentPerDayOutput.Location = new System.Drawing.Point(60, 72);
            this.lbRentPerDayOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRentPerDayOutput.Name = "lbRentPerDayOutput";
            this.lbRentPerDayOutput.Size = new System.Drawing.Size(85, 18);
            this.lbRentPerDayOutput.TabIndex = 13;
            this.lbRentPerDayOutput.Text = "Rente/Tag:";
            // 
            // tbxKTPerDayOutput
            // 
            this.tbxKTPerDayOutput.Location = new System.Drawing.Point(171, 26);
            this.tbxKTPerDayOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxKTPerDayOutput.Name = "tbxKTPerDayOutput";
            this.tbxKTPerDayOutput.ReadOnly = true;
            this.tbxKTPerDayOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxKTPerDayOutput.TabIndex = 16;
            // 
            // lbKTperdayOutput
            // 
            this.lbKTperdayOutput.AutoSize = true;
            this.lbKTperdayOutput.Location = new System.Drawing.Point(82, 36);
            this.lbKTperdayOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbKTperdayOutput.Name = "lbKTperdayOutput";
            this.lbKTperdayOutput.Size = new System.Drawing.Size(62, 18);
            this.lbKTperdayOutput.TabIndex = 15;
            this.lbKTperdayOutput.Text = "KT/Tag:";
            // 
            // tbxOverPaidDaysOutput
            // 
            this.tbxOverPaidDaysOutput.Location = new System.Drawing.Point(489, 26);
            this.tbxOverPaidDaysOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxOverPaidDaysOutput.Name = "tbxOverPaidDaysOutput";
            this.tbxOverPaidDaysOutput.ReadOnly = true;
            this.tbxOverPaidDaysOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxOverPaidDaysOutput.TabIndex = 22;
            // 
            // lbOverPaidDaysOutput
            // 
            this.lbOverPaidDaysOutput.AutoSize = true;
            this.lbOverPaidDaysOutput.Location = new System.Drawing.Point(324, 30);
            this.lbOverPaidDaysOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbOverPaidDaysOutput.Name = "lbOverPaidDaysOutput";
            this.lbOverPaidDaysOutput.Size = new System.Drawing.Size(153, 18);
            this.lbOverPaidDaysOutput.TabIndex = 21;
            this.lbOverPaidDaysOutput.Text = "Tage zu viel gezahlt:";
            // 
            // tbxRequireddDaysOutput
            // 
            this.tbxRequireddDaysOutput.Location = new System.Drawing.Point(489, 66);
            this.tbxRequireddDaysOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRequireddDaysOutput.Name = "tbxRequireddDaysOutput";
            this.tbxRequireddDaysOutput.ReadOnly = true;
            this.tbxRequireddDaysOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxRequireddDaysOutput.TabIndex = 20;
            // 
            // lbRequiredDaysOutput
            // 
            this.lbRequiredDaysOutput.AutoSize = true;
            this.lbRequiredDaysOutput.Location = new System.Drawing.Point(354, 66);
            this.lbRequiredDaysOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRequiredDaysOutput.Name = "lbRequiredDaysOutput";
            this.lbRequiredDaysOutput.Size = new System.Drawing.Size(116, 36);
            this.lbRequiredDaysOutput.TabIndex = 19;
            this.lbRequiredDaysOutput.Text = "Nachleistungs-\r\npflicht Tage :";
            // 
            // tbxRecoveryOverPaidOutput
            // 
            this.tbxRecoveryOverPaidOutput.Location = new System.Drawing.Point(789, 30);
            this.tbxRecoveryOverPaidOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRecoveryOverPaidOutput.Name = "tbxRecoveryOverPaidOutput";
            this.tbxRecoveryOverPaidOutput.ReadOnly = true;
            this.tbxRecoveryOverPaidOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxRecoveryOverPaidOutput.TabIndex = 26;
            // 
            // lbRecoeryOverPaidOutput
            // 
            this.lbRecoeryOverPaidOutput.AutoSize = true;
            this.lbRecoeryOverPaidOutput.Location = new System.Drawing.Point(658, 35);
            this.lbRecoeryOverPaidOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRecoeryOverPaidOutput.Name = "lbRecoeryOverPaidOutput";
            this.lbRecoeryOverPaidOutput.Size = new System.Drawing.Size(120, 18);
            this.lbRecoeryOverPaidOutput.TabIndex = 25;
            this.lbRecoeryOverPaidOutput.Text = "Rückforderung:";
            // 
            // tbxRequiredDaysRecoveryOutput
            // 
            this.tbxRequiredDaysRecoveryOutput.Location = new System.Drawing.Point(789, 66);
            this.tbxRequiredDaysRecoveryOutput.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.tbxRequiredDaysRecoveryOutput.Name = "tbxRequiredDaysRecoveryOutput";
            this.tbxRequiredDaysRecoveryOutput.ReadOnly = true;
            this.tbxRequiredDaysRecoveryOutput.Size = new System.Drawing.Size(138, 26);
            this.tbxRequiredDaysRecoveryOutput.TabIndex = 24;
            // 
            // lbRecoveryRequereddDaysOutput
            // 
            this.lbRecoveryRequereddDaysOutput.AutoSize = true;
            this.lbRecoveryRequereddDaysOutput.Location = new System.Drawing.Point(658, 66);
            this.lbRecoveryRequereddDaysOutput.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbRecoveryRequereddDaysOutput.Name = "lbRecoveryRequereddDaysOutput";
            this.lbRecoveryRequereddDaysOutput.Size = new System.Drawing.Size(120, 18);
            this.lbRecoveryRequereddDaysOutput.TabIndex = 23;
            this.lbRecoveryRequereddDaysOutput.Text = "Rückforderung:";
            // 
            // gbInput
            // 
            this.gbInput.BackColor = System.Drawing.Color.SkyBlue;
            this.gbInput.Controls.Add(this.dtpKTPaidUntilInput);
            this.gbInput.Controls.Add(this.dtpRentStartDateInput);
            this.gbInput.Controls.Add(this.lbKTPaidUntilInput);
            this.gbInput.Controls.Add(this.lbRentStartDateInput);
            this.gbInput.Controls.Add(this.lbKTPerDayInput);
            this.gbInput.Controls.Add(this.tbxKTPerDayInput);
            this.gbInput.Controls.Add(this.lbRentPerMonthInput);
            this.gbInput.Controls.Add(this.tbxRentPerMonthInput);
            this.gbInput.Location = new System.Drawing.Point(16, 156);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(952, 165);
            this.gbInput.TabIndex = 27;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "EINGABE";
            // 
            // gBPutput
            // 
            this.gBPutput.BackColor = System.Drawing.Color.Thistle;
            this.gBPutput.Controls.Add(this.lbKTended);
            this.gBPutput.Controls.Add(this.dtpKTended);
            this.gBPutput.Controls.Add(this.tbxRentPerDayOutput);
            this.gBPutput.Controls.Add(this.tbxRecoveryOverPaidOutput);
            this.gBPutput.Controls.Add(this.lbRecoeryOverPaidOutput);
            this.gBPutput.Controls.Add(this.lbfDifferncePerDayOutput);
            this.gBPutput.Controls.Add(this.tbxRequiredDaysRecoveryOutput);
            this.gBPutput.Controls.Add(this.tbxDifferncePerDayOutput);
            this.gBPutput.Controls.Add(this.lbRecoveryRequereddDaysOutput);
            this.gBPutput.Controls.Add(this.lbRentPerDayOutput);
            this.gBPutput.Controls.Add(this.tbxOverPaidDaysOutput);
            this.gBPutput.Controls.Add(this.lbKTperdayOutput);
            this.gBPutput.Controls.Add(this.lbOverPaidDaysOutput);
            this.gBPutput.Controls.Add(this.tbxKTPerDayOutput);
            this.gBPutput.Controls.Add(this.tbxRequireddDaysOutput);
            this.gBPutput.Controls.Add(this.lbRequiredDaysOutput);
            this.gBPutput.Location = new System.Drawing.Point(16, 327);
            this.gBPutput.Name = "gBPutput";
            this.gBPutput.Size = new System.Drawing.Size(952, 168);
            this.gBPutput.TabIndex = 28;
            this.gBPutput.TabStop = false;
            this.gBPutput.Text = "AUSGABE";
            // 
            // lbKTended
            // 
            this.lbKTended.AutoSize = true;
            this.lbKTended.Location = new System.Drawing.Point(356, 116);
            this.lbKTended.Name = "lbKTended";
            this.lbKTended.Size = new System.Drawing.Size(116, 36);
            this.lbKTended.TabIndex = 28;
            this.lbKTended.Text = "Nachleistungs-\r\npflicht bis:\r\n";
            // 
            // dtpKTended
            // 
            this.dtpKTended.Location = new System.Drawing.Point(489, 116);
            this.dtpKTended.Name = "dtpKTended";
            this.dtpKTended.Size = new System.Drawing.Size(289, 26);
            this.dtpKTended.TabIndex = 27;
            // 
            // gbResult
            // 
            this.gbResult.BackColor = System.Drawing.Color.Khaki;
            this.gbResult.Controls.Add(this.lbRecoverySumme);
            this.gbResult.Controls.Add(this.tbxRecoverySumeOutput);
            this.gbResult.Controls.Add(this.btnCalculate);
            this.gbResult.Location = new System.Drawing.Point(44, 30);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(899, 88);
            this.gbResult.TabIndex = 29;
            this.gbResult.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(982, 514);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gBPutput);
            this.Controls.Add(this.gbInput);
            this.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 3, 6, 3);
            this.MaximumSize = new System.Drawing.Size(998, 553);
            this.MinimumSize = new System.Drawing.Size(998, 553);
            this.Name = "Form1";
            this.Text = "KTRechner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbInput.ResumeLayout(false);
            this.gbInput.PerformLayout();
            this.gBPutput.ResumeLayout(false);
            this.gBPutput.PerformLayout();
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpRentStartDateInput;
        private System.Windows.Forms.DateTimePicker dtpKTPaidUntilInput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox tbxRecoverySumeOutput;
        private System.Windows.Forms.Label lbKTPaidUntilInput;
        private System.Windows.Forms.Label lbRentStartDateInput;
        private System.Windows.Forms.Label lbKTPerDayInput;
        private System.Windows.Forms.TextBox tbxKTPerDayInput;
        private System.Windows.Forms.TextBox tbxRentPerMonthInput;
        private System.Windows.Forms.Label lbRentPerMonthInput;
        private System.Windows.Forms.TextBox tbxDifferncePerDayOutput;
        private System.Windows.Forms.Label lbfDifferncePerDayOutput;
        private System.Windows.Forms.Label lbRecoverySumme;
        private System.Windows.Forms.TextBox tbxRentPerDayOutput;
        private System.Windows.Forms.Label lbRentPerDayOutput;
        private System.Windows.Forms.TextBox tbxKTPerDayOutput;
        private System.Windows.Forms.Label lbKTperdayOutput;
        private System.Windows.Forms.TextBox tbxOverPaidDaysOutput;
        private System.Windows.Forms.Label lbOverPaidDaysOutput;
        private System.Windows.Forms.TextBox tbxRequireddDaysOutput;
        private System.Windows.Forms.Label lbRequiredDaysOutput;
        private System.Windows.Forms.TextBox tbxRecoveryOverPaidOutput;
        private System.Windows.Forms.Label lbRecoeryOverPaidOutput;
        private System.Windows.Forms.TextBox tbxRequiredDaysRecoveryOutput;
        private System.Windows.Forms.Label lbRecoveryRequereddDaysOutput;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.GroupBox gBPutput;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.DateTimePicker dtpKTended;
        private System.Windows.Forms.Label lbKTended;
    }
}

