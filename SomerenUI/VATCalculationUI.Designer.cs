using System;

namespace SomerenUI
{
    partial class VATCalculationUI
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
            SelectQuarterVatCalculationLabel = new System.Windows.Forms.Label();
            QuarterSelectionComboBox = new System.Windows.Forms.ComboBox();
            VATCalcQuarterFromLabel = new System.Windows.Forms.Label();
            VATCALCQuarterto = new System.Windows.Forms.Label();
            CalcVatTextBoxFrom = new System.Windows.Forms.TextBox();
            CalcVatTextboxTo = new System.Windows.Forms.TextBox();
            CALCVAT6Label = new System.Windows.Forms.Label();
            CALCVAT21Label = new System.Windows.Forms.Label();
            VATCALCLabelTotalVAT = new System.Windows.Forms.Label();
            textBox6Vat = new System.Windows.Forms.TextBox();
            textBox21Vat = new System.Windows.Forms.TextBox();
            textBoxTotalVat = new System.Windows.Forms.TextBox();
            labelExtraInfoTotalVAT = new System.Windows.Forms.Label();
            QuarterForLabel = new System.Windows.Forms.Label();
            CalcVatTextBoxYear = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // SelectQuarterVatCalculationLabel
            // 
            SelectQuarterVatCalculationLabel.AutoSize = true;
            SelectQuarterVatCalculationLabel.Location = new System.Drawing.Point(21, 32);
            SelectQuarterVatCalculationLabel.Name = "SelectQuarterVatCalculationLabel";
            SelectQuarterVatCalculationLabel.Size = new System.Drawing.Size(174, 15);
            SelectQuarterVatCalculationLabel.TabIndex = 0;
            SelectQuarterVatCalculationLabel.Text = "Select quarter (Q1, Q2, Q3, Q4): ";
            // 
            // QuarterSelectionComboBox
            // 
            QuarterSelectionComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            QuarterSelectionComboBox.FormattingEnabled = true;
            QuarterSelectionComboBox.Items.AddRange(new object[] { "Q1", "Q2", "Q3", "Q4" });
            QuarterSelectionComboBox.Location = new System.Drawing.Point(237, 29);
            QuarterSelectionComboBox.Name = "QuarterSelectionComboBox";
            QuarterSelectionComboBox.Size = new System.Drawing.Size(121, 23);
            QuarterSelectionComboBox.TabIndex = 1;
            QuarterSelectionComboBox.Text = "Select quarter";
            QuarterSelectionComboBox.SelectedIndexChanged += QuarterSelectionComboBox_SelectedIndexChanged;
            // 
            // VATCalcQuarterFromLabel
            // 
            VATCalcQuarterFromLabel.AutoSize = true;
            VATCalcQuarterFromLabel.Location = new System.Drawing.Point(21, 105);
            VATCalcQuarterFromLabel.Name = "VATCalcQuarterFromLabel";
            VATCalcQuarterFromLabel.Size = new System.Drawing.Size(105, 15);
            VATCalcQuarterFromLabel.TabIndex = 2;
            VATCalcQuarterFromLabel.Text = "Quarter runs from:";
            // 
            // VATCALCQuarterto
            // 
            VATCALCQuarterto.AutoSize = true;
            VATCALCQuarterto.Location = new System.Drawing.Point(270, 105);
            VATCALCQuarterto.Name = "VATCALCQuarterto";
            VATCALCQuarterto.Size = new System.Drawing.Size(21, 15);
            VATCALCQuarterto.TabIndex = 3;
            VATCALCQuarterto.Text = "to:";
            // 
            // CalcVatTextBoxFrom
            // 
            CalcVatTextBoxFrom.Location = new System.Drawing.Point(142, 102);
            CalcVatTextBoxFrom.Name = "CalcVatTextBoxFrom";
            CalcVatTextBoxFrom.ReadOnly = true;
            CalcVatTextBoxFrom.Size = new System.Drawing.Size(100, 23);
            CalcVatTextBoxFrom.TabIndex = 4;
            // 
            // CalcVatTextboxTo
            // 
            CalcVatTextboxTo.Location = new System.Drawing.Point(321, 102);
            CalcVatTextboxTo.Name = "CalcVatTextboxTo";
            CalcVatTextboxTo.ReadOnly = true;
            CalcVatTextboxTo.Size = new System.Drawing.Size(100, 23);
            CalcVatTextboxTo.TabIndex = 5;
            // 
            // CALCVAT6Label
            // 
            CALCVAT6Label.AutoSize = true;
            CALCVAT6Label.Location = new System.Drawing.Point(21, 148);
            CALCVAT6Label.Name = "CALCVAT6Label";
            CALCVAT6Label.Size = new System.Drawing.Size(226, 15);
            CALCVAT6Label.TabIndex = 6;
            CALCVAT6Label.Text = "Total VAT (low tariff, 6%) amount payable:";
            // 
            // CALCVAT21Label
            // 
            CALCVAT21Label.AutoSize = true;
            CALCVAT21Label.Location = new System.Drawing.Point(21, 183);
            CALCVAT21Label.Name = "CALCVAT21Label";
            CALCVAT21Label.Size = new System.Drawing.Size(237, 15);
            CALCVAT21Label.TabIndex = 7;
            CALCVAT21Label.Text = "Total VAT (high tariff, 21%) amount payable:";
            // 
            // VATCALCLabelTotalVAT
            // 
            VATCALCLabelTotalVAT.AutoSize = true;
            VATCALCLabelTotalVAT.Location = new System.Drawing.Point(21, 221);
            VATCALCLabelTotalVAT.Name = "VATCALCLabelTotalVAT";
            VATCALCLabelTotalVAT.Size = new System.Drawing.Size(149, 15);
            VATCALCLabelTotalVAT.TabIndex = 8;
            VATCALCLabelTotalVAT.Text = "Total VAT amount payable: ";
            // 
            // textBox6Vat
            // 
            textBox6Vat.Location = new System.Drawing.Point(321, 148);
            textBox6Vat.Name = "textBox6Vat";
            textBox6Vat.ReadOnly = true;
            textBox6Vat.Size = new System.Drawing.Size(100, 23);
            textBox6Vat.TabIndex = 9;
            // 
            // textBox21Vat
            // 
            textBox21Vat.Location = new System.Drawing.Point(321, 183);
            textBox21Vat.Name = "textBox21Vat";
            textBox21Vat.ReadOnly = true;
            textBox21Vat.Size = new System.Drawing.Size(100, 23);
            textBox21Vat.TabIndex = 10;
            // 
            // textBoxTotalVat
            // 
            textBoxTotalVat.Location = new System.Drawing.Point(321, 221);
            textBoxTotalVat.Name = "textBoxTotalVat";
            textBoxTotalVat.ReadOnly = true;
            textBoxTotalVat.Size = new System.Drawing.Size(100, 23);
            textBoxTotalVat.TabIndex = 11;
            // 
            // labelExtraInfoTotalVAT
            // 
            labelExtraInfoTotalVAT.AutoSize = true;
            labelExtraInfoTotalVAT.Location = new System.Drawing.Point(465, 229);
            labelExtraInfoTotalVAT.Name = "labelExtraInfoTotalVAT";
            labelExtraInfoTotalVAT.Size = new System.Drawing.Size(184, 15);
            labelExtraInfoTotalVAT.TabIndex = 12;
            labelExtraInfoTotalVAT.Text = "(total of the two amounts above).";
            // 
            // QuarterForLabel
            // 
            QuarterForLabel.AutoSize = true;
            QuarterForLabel.Location = new System.Drawing.Point(386, 37);
            QuarterForLabel.Name = "QuarterForLabel";
            QuarterForLabel.Size = new System.Drawing.Size(22, 15);
            QuarterForLabel.TabIndex = 13;
            QuarterForLabel.Text = "for";
            // 
            // CalcVattextBoxYear
            // 
            CalcVatTextBoxYear.Location = new System.Drawing.Point(438, 34);
            CalcVatTextBoxYear.Name = "CalcVattextBoxYear";
            CalcVatTextBoxYear.Size = new System.Drawing.Size(100, 23);
            CalcVatTextBoxYear.TabIndex = 14;
            CalcVatTextBoxYear.Text = "2023";
            CalcVatTextBoxYear.TextChanged += CalcVattextBoxYear_TextChanged;
            // 
            // VATCalculationUI
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(CalcVatTextBoxYear);
            Controls.Add(QuarterForLabel);
            Controls.Add(labelExtraInfoTotalVAT);
            Controls.Add(textBoxTotalVat);
            Controls.Add(textBox21Vat);
            Controls.Add(textBox6Vat);
            Controls.Add(VATCALCLabelTotalVAT);
            Controls.Add(CALCVAT21Label);
            Controls.Add(CALCVAT6Label);
            Controls.Add(CalcVatTextboxTo);
            Controls.Add(CalcVatTextBoxFrom);
            Controls.Add(VATCALCQuarterto);
            Controls.Add(VATCalcQuarterFromLabel);
            Controls.Add(QuarterSelectionComboBox);
            Controls.Add(SelectQuarterVatCalculationLabel);
            Name = "VATCalculationUI";
            Text = "VATCalculationUI";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label SelectQuarterVatCalculationLabel;
        private System.Windows.Forms.ComboBox QuarterSelectionComboBox;
        private System.Windows.Forms.Label VATCalcQuarterFromLabel;
        private System.Windows.Forms.Label VATCALCQuarterto;
        private System.Windows.Forms.TextBox CalcVatTextBoxFrom;
        private System.Windows.Forms.TextBox CalcVatTextboxTo;
        private System.Windows.Forms.Label CALCVAT6Label;
        private System.Windows.Forms.Label CALCVAT21Label;
        private System.Windows.Forms.Label VATCALCLabelTotalVAT;
        private System.Windows.Forms.TextBox textBox6Vat;
        private System.Windows.Forms.TextBox textBox21Vat;
        private System.Windows.Forms.TextBox textBoxTotalVat;
        private System.Windows.Forms.Label labelExtraInfoTotalVAT;
        private System.Windows.Forms.Label QuarterForLabel;
        private System.Windows.Forms.TextBox CalcVatTextBoxYear;
    }
}