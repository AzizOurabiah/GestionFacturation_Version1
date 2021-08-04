Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub LblHassounaAcademy_Click(sender As Object, e As EventArgs) Handles LblHassounaAcademy.Click
        System.Diagnostics.Process.Start(LblHassounaAcademy.Text)
        'Dim pro As New Process
        'pro.Start(LblHassounaAcademy.Text)
    End Sub

    Private Sub TxtDateFacture_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDateFacture.KeyPress, TxtTotal.KeyPress
        e.Handled = True 'Pour bloquer la modification de l'input
    End Sub

    'Cette méthode pour empêcher le coller sur le textbox de date
    Private Sub TxtDateFacture_MouseDown(sender As Object, e As MouseEventArgs) Handles TxtDateFacture.MouseDown, TxtTotal.MouseDown, TxtPrice.MouseDown, TxtQte.MouseDown
        If e.Button = MouseButtons.Right Then
            sender.ContextMenuStrip = New ContextMenuStrip()
        End If
    End Sub

    Sub ShowPrice()
        TxtPrice.Text = cbxItem.SelectedValue.ToString
    End Sub

    'Méthode pour afficher la date actuel dans le text bos de date quand on charge l'interface
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtDateFacture.Text = Date.Now.ToString("yyyy/MM/dd")

        TxtNameCustomer.Focus()
        TxtNameCustomer.Select()
        'TxtNameCustomer.SelectAll()

        Dim itemsData As New Dictionary(Of Integer, String)

        itemsData.Add(100, "Pc Dell CPU i8")
        itemsData.Add(200, "Lenouvo think pad CPU i5")
        itemsData.Add(300, "Tablette Microsoft CPU i3")
        itemsData.Add(400, "Pc IBM CPU i5")
        itemsData.Add(500, "Pc HP CPU i8")
        itemsData.Add(700, "Clavier Digital")
        itemsData.Add(450, "Head Phone")
        itemsData.Add(900, "Blutooth")

        cbxItem.DataSource = New BindingSource(itemsData, Nothing)

        cbxItem.DisplayMember = "value"
        cbxItem.ValueMember = "key"

        ShowPrice()

        For Each col As DataGridViewColumn In dgvInvoice.Columns
            col.DefaultCellStyle.ForeColor = Color.Red
        Next
        dgvInvoice.Columns(0).DefaultCellStyle.ForeColor = Color.Navy
        dgvInvoice.Columns(1).DefaultCellStyle.ForeColor = Color.DarkGreen
        dgvInvoice.Columns(3).DefaultCellStyle.ForeColor = Color.DarkGreen
    End Sub

    Private Sub TxtNameCustomer_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtNameCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxItem.Focus()
        End If
    End Sub

    Private Sub cbxItem_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxItem.KeyDown
        If e.KeyCode = Keys.Enter Then
            TxtQte.Focus()
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        'MsgBox("Le item à été ajouté !")
        'MsgBox(cbxItem.SelectedIndex)
        If cbxItem.SelectedIndex > -1 Then

            Dim item As String = cbxItem.SelectedItem.ToString
            Dim price As Integer = TxtPrice.Text
            Dim qte As Integer = TxtQte.Text
            Dim subTotal As Integer
            subTotal = price * qte

            dgvInvoice.Rows.Add(item, qte, price, subTotal)
            'Dim Total As Integer = 0
            TxtTotal.Text += subTotal

            cbxItem.Focus()
        Else
            MessageBox.Show("Veuillez sélectioner un item parmi les types existant")
        End If
    End Sub

    Private Sub TxtQte_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtQte.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnAdd.PerformClick()
            TxtQte.SelectAll()
            cbxItem.Focus()
        End If
    End Sub

    Private Sub TxtQte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtQte.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtQte_TextChanged(sender As Object, e As EventArgs) Handles TxtQte.TextChanged
        If TxtQte.Text.Trim() = "" Or TxtQte.Text.Trim() = "0" Then
            TxtQte.Text = 1
        End If
    End Sub

    Private Sub cbxItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxItem.SelectedIndexChanged
        ShowPrice()
    End Sub

    Dim OldQte As Integer = 1
    Private Sub dgvInvoice_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgvInvoice.CellBeginEdit
        If Not dgvInvoice.CurrentRow.Cells(1).Value Then
            OldQte = dgvInvoice.CurrentRow.Cells(1).Value
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(OldQte)
    End Sub


    Private Sub dgvInvoice_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvInvoice.CellEndEdit
        If Not dgvInvoice.CurrentRow Is Nothing Then
            Dim newQte As String = dgvInvoice.CurrentRow.Cells(1).Value
            If OldQte = Val(newQte) Then
                Exit Sub
            End If

            If Not Regex.IsMatch(newQte.ToString(), "^\d+$") Or Val(newQte) = 0 Then
                dgvInvoice.CurrentRow.Cells(1).Value = OldQte
            Else
                Dim p As Integer = dgvInvoice.CurrentRow.Cells(2).Value
                Dim q As Integer = dgvInvoice.CurrentRow.Cells(1).Value

                dgvInvoice.CurrentRow.Cells(3).Value = p * q

                Dim newTotal As Integer = 0
                For Each r As DataGridViewRow In dgvInvoice.Rows
                    newTotal += (r.Cells(3)).Value
                Next

                TxtTotal.Text = newTotal
                'If OldQte > Val(newQte) Then
                '    TxtTotal.Text = Val(TxtTotal.Text) - p * (OldQte - Val(newQte))
                'Else
                '    TxtTotal.Text = Val(TxtTotal.Text) + p * (OldQte - Val(newQte))
                'End If
            End If
        End If
    End Sub
    Private Sub BtnPrint(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.Size = Me.Size()
        PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
        If PrintPreviewDialog1.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim margin As Single = 40
        Dim currentTop As Single = 0

        Dim fnt As New Font("Arial", 18, FontStyle.Bold)

        Dim strNo As String = "#NO " & NoFacture.Text
        Dim strDate As String = "date : " & TxtDateFacture.Text
        Dim strName As String = "Montant dû : " & TxtNameCustomer.Text

        Dim fontSizeNo As SizeF = e.Graphics.MeasureString(strNo, fnt)
        Dim fontSizeDate As SizeF = e.Graphics.MeasureString(strDate, fnt)
        Dim fontSizeName As SizeF = e.Graphics.MeasureString(strName, fnt)

        'e.Graphics.DrawImage(My.Resources., margin, margin, 150, 150)
    End Sub
End Class
