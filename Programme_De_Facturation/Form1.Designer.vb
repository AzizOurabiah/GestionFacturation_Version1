<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHassounaAcademy = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NoFacture = New System.Windows.Forms.TextBox()
        Me.TxtDateFacture = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNameCustomer = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtQte = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dgvInvoice = New System.Windows.Forms.DataGridView()
        Me.colItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQte = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.cbxItem = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(143, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(489, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INTERFACE DE LA FACTURE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblHassounaAcademy
        '
        Me.LblHassounaAcademy.AutoSize = True
        Me.LblHassounaAcademy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblHassounaAcademy.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.LblHassounaAcademy.ForeColor = System.Drawing.Color.Blue
        Me.LblHassounaAcademy.Location = New System.Drawing.Point(217, 47)
        Me.LblHassounaAcademy.Name = "LblHassounaAcademy"
        Me.LblHassounaAcademy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LblHassounaAcademy.Size = New System.Drawing.Size(328, 25)
        Me.LblHassounaAcademy.TabIndex = 1
        Me.LblHassounaAcademy.Text = "https://www.hassouna-academy.com/"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 104)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numéro facture"
        '
        'NoFacture
        '
        Me.NoFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoFacture.ForeColor = System.Drawing.Color.Red
        Me.NoFacture.Location = New System.Drawing.Point(152, 101)
        Me.NoFacture.Name = "NoFacture"
        Me.NoFacture.Size = New System.Drawing.Size(172, 32)
        Me.NoFacture.TabIndex = 4
        Me.NoFacture.Text = "0000001"
        Me.NoFacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtDateFacture
        '
        Me.TxtDateFacture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateFacture.ForeColor = System.Drawing.Color.Blue
        Me.TxtDateFacture.Location = New System.Drawing.Point(462, 101)
        Me.TxtDateFacture.Name = "TxtDateFacture"
        Me.TxtDateFacture.Size = New System.Drawing.Size(170, 32)
        Me.TxtDateFacture.TabIndex = 6
        Me.TxtDateFacture.Text = "01/01/2020"
        Me.TxtDateFacture.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Date facture"
        '
        'TxtNameCustomer
        '
        Me.TxtNameCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNameCustomer.ForeColor = System.Drawing.Color.Blue
        Me.TxtNameCustomer.Location = New System.Drawing.Point(152, 144)
        Me.TxtNameCustomer.Name = "TxtNameCustomer"
        Me.TxtNameCustomer.Size = New System.Drawing.Size(480, 32)
        Me.TxtNameCustomer.TabIndex = 8
        Me.TxtNameCustomer.Text = "Inconu"
        Me.TxtNameCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Nom du client"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(648, 34)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "_________________________________________________________________________________" &
    "_____________________________"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Type"
        '
        'TxtPrice
        '
        Me.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPrice.ForeColor = System.Drawing.Color.Blue
        Me.TxtPrice.Location = New System.Drawing.Point(66, 251)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(80, 32)
        Me.TxtPrice.TabIndex = 13
        Me.TxtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 258)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 25)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Prix"
        '
        'TxtQte
        '
        Me.TxtQte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtQte.ForeColor = System.Drawing.Color.Blue
        Me.TxtQte.Location = New System.Drawing.Point(243, 254)
        Me.TxtQte.Name = "TxtQte"
        Me.TxtQte.Size = New System.Drawing.Size(64, 32)
        Me.TxtQte.TabIndex = 15
        Me.TxtQte.Text = "1"
        Me.TxtQte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(152, 258)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 25)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Quantité"
        '
        'dgvInvoice
        '
        Me.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInvoice.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colItem, Me.colQte, Me.colPrice, Me.colTotal})
        Me.dgvInvoice.Location = New System.Drawing.Point(12, 316)
        Me.dgvInvoice.Name = "dgvInvoice"
        Me.dgvInvoice.RowTemplate.Height = 25
        Me.dgvInvoice.Size = New System.Drawing.Size(620, 150)
        Me.dgvInvoice.TabIndex = 16
        '
        'colItem
        '
        Me.colItem.HeaderText = "Type"
        Me.colItem.Name = "colItem"
        Me.colItem.ReadOnly = True
        '
        'colQte
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colQte.DefaultCellStyle = DataGridViewCellStyle1
        Me.colQte.HeaderText = "Quantité"
        Me.colQte.Name = "colQte"
        '
        'colPrice
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colPrice.DefaultCellStyle = DataGridViewCellStyle2
        Me.colPrice.HeaderText = "Prix"
        Me.colPrice.Name = "colPrice"
        Me.colPrice.ReadOnly = True
        '
        'colTotal
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colTotal.DefaultCellStyle = DataGridViewCellStyle3
        Me.colTotal.HeaderText = "Sous-Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.Blue
        Me.TxtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTotal.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TxtTotal.ForeColor = System.Drawing.Color.White
        Me.TxtTotal.Location = New System.Drawing.Point(313, 252)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(118, 35)
        Me.TxtTotal.TabIndex = 18
        Me.TxtTotal.Text = "0"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(328, 219)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Total"
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAdd.Location = New System.Drawing.Point(437, 219)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(88, 67)
        Me.BtnAdd.TabIndex = 19
        Me.BtnAdd.Text = "Ajouter"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button2.Location = New System.Drawing.Point(531, 218)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 67)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "Imprimé"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cbxItem
        '
        Me.cbxItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbxItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbxItem.FormattingEnabled = True
        Me.cbxItem.Location = New System.Drawing.Point(66, 210)
        Me.cbxItem.Name = "cbxItem"
        Me.cbxItem.Size = New System.Drawing.Size(241, 33)
        Me.cbxItem.TabIndex = 21
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 76)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 470)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cbxItem)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvInvoice)
        Me.Controls.Add(Me.TxtQte)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNameCustomer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDateFacture)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NoFacture)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblHassounaAcademy)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "INTERFACE DE LA FACTURE"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LblHassounaAcademy As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NoFacture As TextBox
    Friend WithEvents TxtDateFacture As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNameCustomer As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtQte As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents dgvInvoice As DataGridView
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnAdd As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cbxItem As ComboBox
    Friend WithEvents colItem As DataGridViewTextBoxColumn
    Friend WithEvents colQte As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
